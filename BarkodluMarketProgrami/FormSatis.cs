using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluMarketProgrami
{
    public partial class FormSatis : Form
    {
        BarkodEntities db = new BarkodEntities();
        int guncelKategoriID = 1;   
        bool basiliMi = false;
        int basiliBtnID = 0;
        Button basiliBtn = null;
        public double nakitKartTutar = 0; // Nakit olarak
        public double veresiyeTutar = 0;
        public double veresiyeNakitTutar = 0;
        public double veresiyeKartTutar = 0;
        public int veresiyeTur = 0; // 0 = Veresiye, 1 = Veresiye-Nakit, 3 = Veresiye-Kart
        DataGridView gridBeklet = null; // Bekletme işlemi için DataGridView
        public FormSatis()
        {
            InitializeComponent();
            timerAyarlamalari();
        }
        private void FormSatis_Load(object sender, EventArgs e)
        {
            hizliUrunDoldur(1);
            hizliKategorilerDoldur();
            hizliFiyatDoldur();
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkod.Text.Trim(); // Trim fonksiyonu ile boşlukları atıyoruz
                if (barkod.Length > 2)
                {
                    if (db.Urun.Any(a => a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                        double miktar = Convert.ToDouble(nudMiktar.Value);
                        urunGetirListeye(urun, miktar, barkod);
                    }
                    else
                    {
                        int onEk = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a => a.TeraziOnEk == onEk))
                        {
                            string teraziUrunNo = barkod.Substring(2, 5);
                            if (db.Urun.Any(a => a.Barkod == teraziUrunNo))
                            {
                                var urunTerazi = db.Urun.Where(a => a.Barkod == teraziUrunNo).FirstOrDefault();
                                double miktarKg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                urunGetirListeye(urunTerazi, miktarKg, barkod);
                            }
                            else
                            {
                                Console.Beep(900, 1000);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(200, 200);
                            FormUrunGiris formUrunGiris = new FormUrunGiris(barkod);
                            formUrunGiris.ShowDialog();
                        }
                    }
                }
                else
                {
                    // Barkod numarası 2 karakterden az ise
                    MessageBox.Show("Lütfen Geçerli Bir Barkod Giriniz.");
                }
                gridSatisListesi.ClearSelection(); // DataGridView'den seçimi temizliyoruz
                genelToplamYazdir();
                txtBarkod.Text = ""; // Barkod kutusunu temizliyoruz
                txtBarkod.Focus(); // Barkod kutusuna odaklıyoruz
                nudMiktar.Value = 1; // Miktar kutusunu 1'e alıyoruz
            }
        }
        private void urunGetirListeye(Urun urun, double miktar, string barkod)
        {
            int satirSayisi = gridSatisListesi.Rows.Count;
            bool eklendiMi = false;
            if (satirSayisi > 0)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (gridSatisListesi.Rows[i].Cells["urunBarkod"].Value.ToString() == barkod)
                    {
                        gridSatisListesi.Rows[i].Cells["urunMiktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value);
                        gridSatisListesi.Rows[i].Cells["urunToplam"].Value = Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunFiyat"].Value), 2);
                        eklendiMi = true;
                    }
                }
            }
            if (!eklendiMi)
            {
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirSayisi].Cells["urunBarkod"].Value = barkod;
                gridSatisListesi.Rows[satirSayisi].Cells["urunAdi"].Value = urun.UrunAd;
                gridSatisListesi.Rows[satirSayisi].Cells["urunGrup"].Value = urun.UrunGrup;
                gridSatisListesi.Rows[satirSayisi].Cells["urunBirim"].Value = urun.Birim;
                gridSatisListesi.Rows[satirSayisi].Cells["urunFiyat"].Value = urun.SatisFiyat;
                gridSatisListesi.Rows[satirSayisi].Cells["urunMiktar"].Value = miktar;
                gridSatisListesi.Rows[satirSayisi].Cells["urunToplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                gridSatisListesi.Rows[satirSayisi].Cells["urunKdv"].Value = urun.KdvTutari;
                gridSatisListesi.Rows[satirSayisi].Cells["urunAlisFiyat"].Value = urun.AlisFiyat;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                nudMiktar.Value += 1;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private double genelToplam()
        {
            double genelToplam = 0.00;
            for (int i = 0; i < gridSatisListesi.Rows.Count; i++)
            {
                genelToplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunToplam"].Value);
            }
            return genelToplam;
        }
        private void genelToplamYazdir()
        {
            txtToplam.Text = genelToplam().ToString("C2");
        }
        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView'den ürün silme işlemi
            if (e.ColumnIndex == 9) // DataGridView'den seçilenin sil tuşu olduğundan emin oluyoruz
            {
                if (Convert.ToDouble(gridSatisListesi.CurrentRow.Cells["urunMiktar"].Value) == 1) // Eğer ki ürün miktarı 1 ise zaten eksiltilemeyeceğine göre direkt olarak kaldırıyoruz
                {
                    gridSatisListesi.Rows.Remove(gridSatisListesi.CurrentRow); // DataGridView'den kaldırma işlemi
                }
                else // Ürün miktarı 1 değil ise direkt olarak DataGridView'den silmek yerine ürün miktarını birer birer azaltıyoruz
                {
                    gridSatisListesi.CurrentRow.Cells["urunMiktar"].Value = Convert.ToDouble(gridSatisListesi.CurrentRow.Cells["urunMiktar"].Value) - 1; // Ürün miktarınız 1 azaltıyoruz
                    // Ürün miktarını azalttığımız zaman ürün toplamındaki fiyatın değişikliği için her 1 eksilmede ürünün genel toplamı ile fiyatı çıkarıyoruz
                    gridSatisListesi.CurrentRow.Cells["urunToplam"].Value = Convert.ToDouble(gridSatisListesi.CurrentRow.Cells["urunToplam"].Value) - Convert.ToDouble(gridSatisListesi.CurrentRow.Cells["urunFiyat"].Value);
                    // DataGridView'den seçimi temizliyoruz
                    gridSatisListesi.ClearSelection();
                }
                genelToplamYazdir(); // Ürün silme işleminden sonra genel toplam bölümüne yazdırıyoruz C2 ile para birimi ekliyoruz(Bilgisayarın konumuna ve diline göre para birimi değişebilmekte)
                txtBarkod.Clear(); // Barkod kutusunu temizliyoruz
                txtBarkod.Focus(); // Barkod kutusuna odaklıyoruz
            }
        }
        public void hizliUrunDoldur(int hizliKategoriID)
        {
            using (var yeniDb = new BarkodEntities())
            {
                var hizliUrun = yeniDb.HizliUrun.Where(a => a.HizliKategoriID == hizliKategoriID).ToList(); // Veritabanındaki HizliUrun tablosunu listeledik
                var hizliUrunKategori = yeniDb.HizliKategori.Where(a => a.Id == hizliKategoriID).FirstOrDefault(); // Seçilen kategoriye göre HizliKategori tablosundan kategori bilgilerini alıyoruz
                int count = 0;
                foreach (var hUrun in hizliUrun) // Foreach döngüsü oluşturarak tüm Hızlı Ürün tuşlarının değerlerini otomatik değiştiriyoruz
                {
                    count++;
                    Button hUrunButton = this.Controls.Find("btnHizli" + count, true).FirstOrDefault() as Button;
                    if (hUrunButton != null)
                    {
                        hUrunButton.Text = hUrun.UrunAd + "\n" + Convert.ToDecimal(hUrun.Fiyat).ToString("C2");
                        hUrunButton.BackColor = Color.FromName(hizliUrunKategori.Renk); // Renkleri veritabanından alıp butonların arka plan rengini değiştiriyoruz
                        hUrunButton.FlatAppearance.BorderColor = Color.FromName(hizliUrunKategori.Renk); // Çerçeve rengini de aynı renk yapıyoruz
                    }
                }
            }
        }
        public int hizliUrunID(int hizliKategoriID, int hizliUrunID)
        {
            int btnId = 0;
            if (hizliKategoriID == 1)
            {
                return btnId = hizliUrunID;
            }
            if (hizliKategoriID == 2)
            {
                return btnId = hizliUrunID + 25;
            }
            if (hizliKategoriID == 3)
            {
                return btnId = hizliUrunID + 50;
            }
            if (hizliKategoriID == 4)
            {
                return btnId = hizliUrunID + 75;
            }
            if (hizliKategoriID == 5)
            {
                return btnId = hizliUrunID + 100;
            }
            return btnId; // Eğer ki hiçbir kategoriye uymadıysa 0 döndürüyoruz

        }
        private void hizliUrunEkle(object sender, EventArgs e)
        {
            Button hizliBtn = sender as Button; // Butonun kendisini alıyoruz
            int hizliID = Convert.ToInt32(hizliBtn.Name.Replace("btnHizli", "")); // Butonun ismine göre ID'sini alıyoruz

            if (hizliBtn.Text.StartsWith("-"))
            {
                FormHizliUrunEkle formHizliUrunEkle = new FormHizliUrunEkle(); // Hızlı ürün ekleme formunu oluşturuyoruz
                formHizliUrunEkle.gelenButtonID = hizliID; // Butonun ismine göre ID'sini alıyoruz
                formHizliUrunEkle.gelenButtonKategoriID = guncelKategoriID; // Hızlı kategori ID'sini alıyoruz
                formHizliUrunEkle.ShowDialog(); // Formu modal olarak açıyoruz
            }
            else
            {
                int btnId = hizliUrunID(guncelKategoriID, hizliID);
                var hizliUrun = db.HizliUrun.Where(a => a.Id == btnId && a.HizliKategoriID == guncelKategoriID).FirstOrDefault(); // Butonun ismine göre veritabanından hızlı ürünü 
                if (hizliUrun != null)
                {
                    var urun = db.Urun.Where(a => a.Barkod == hizliUrun.Barkod).FirstOrDefault(); // Hızlı ürüne göre veritabanından ürünü alıyoruz
                    double miktar = Convert.ToDouble(nudMiktar.Value); // Miktarı alıyoruz
                    urunGetirListeye(urun, miktar, hizliUrun.Barkod); // Ürünü listeye ekliyoruz
                    genelToplamYazdir(); // Genel toplamı hesaplıyoruz ve ekrana yazdırıyoruz
                    txtBarkod.Clear(); // Barkod kutusunu temizliyoruz
                    txtBarkod.Focus(); // Barkod kutusuna odaklıyoruz
                }
            }
        }
        private void hizliKategorilerDoldur()
        {
            var hizliKategori = db.HizliKategori.ToList(); // HizliKategori tablosunu listeliyoruz
            foreach (var hKategori in hizliKategori)
            {
                Button hKategoriButton = this.Controls.Find("btnHizliKategori" + hKategori.Id, true).FirstOrDefault() as Button;
                if (hKategoriButton != null)
                {
                    hKategoriButton.Text = hKategori.KategoriAd.ToString();
                }
            }
        }
        private void btnHizliKategori_Click(object sender, EventArgs e)
        {
            Button hKategoriButton = sender as Button;
            if (hKategoriButton != null)
            {
                string hKategoriButtonID = hKategoriButton.Name.Substring(hKategoriButton.Name.Length - 1, 1);
                int id = Convert.ToInt32(hKategoriButtonID);
                guncelKategoriID = id; // Hızlı kategori ID'sini güncelliyoruz
                hizliUrunDoldur(Convert.ToInt32(hKategoriButtonID));
            }
        }
        private void hizliFiyatDoldur()
        {
            var hizliFiyat = db.HizliFiyat.ToList(); // HizliFiyat tablosunu listeliyoruz
            foreach (var hFiyat in hizliFiyat)
            {
                Button hFiyatButton = this.Controls.Find("btnHFiyat" + hFiyat.Id, true).FirstOrDefault() as Button;
                if (hFiyatButton != null)
                {
                    hFiyatButton.Text = Convert.ToDecimal(hFiyat.Fiyat).ToString("C2");
                }
            }
        }
        private void timerAyarlamalari()
        {

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }
        private void btnHizli_MouseDown(object sender, MouseEventArgs e)
        {
            basiliMi = true; // Butona basıldığında değişkeni true yapıyoruz
            timer1.Start(); // Timer'ı başlatıyoruz
            basiliBtn = sender as Button; // Butonun kendisini alıyoruz
            basiliBtnID = Convert.ToInt32(basiliBtn.Name.Replace("btnHizli", "")); // Butonun ismine göre ID'sini alıyoruz
        }
        private void btnHizli_MouseUp(object sender, MouseEventArgs e)
        {
            basiliMi = false; // Butona basılmadığında değişkeni false yapıyoruz
            timer1.Stop(); // Timer'ı durduruyoruz
            basiliBtn = sender as Button; // Butonun kendisini alıyoruz
            basiliBtnID = Convert.ToInt32(basiliBtn.Name.Replace("btnHizli", "")); // Butonun ismine göre ID'sini alıyoruz
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (basiliMi) // Eğer butona basılı ise
            {
                if (!basiliBtn.Text.StartsWith("-"))
                {
                    ContextMenuStrip st = new ContextMenuStrip();
                    ToolStripMenuItem menuItem = new ToolStripMenuItem();
                    menuItem.Text = "Temizle: " + basiliBtn.Text.ToString();
                    menuItem.Click += hizliUrunSil;
                    st.Items.Add(menuItem);
                    this.ContextMenuStrip = st;
                    st.Show(basiliBtn, new Point(0, basiliBtn.Height));
                }

            }
        }
        private void hizliUrunSil(object sender, EventArgs e)
        {
            int hizliUrunId = hizliUrunID(guncelKategoriID, basiliBtnID); // Hızlı ürün ID'sini alıyoruz
            var hizliUrun = db.HizliUrun.Where(a=> a.Id == hizliUrunId).FirstOrDefault();
            if(hizliUrun != null)
            {
                hizliUrun.Barkod = "-";
                hizliUrun.UrunAd = "-";
                hizliUrun.Fiyat = 0;
                db.SaveChanges(); // Değişiklikleri kaydediyoruz
                hizliUrunDoldur(1);
            }
        }
        private void numClick(object sender, EventArgs e) 
        {
            Button btn = sender as Button;
            if(btn.Text == "<")
            {
                if (txtNum.Text.Length > 0)
                {
                    txtNum.Text = txtNum.Text.Substring(0, txtNum.Text.Length - 1);
                }
            }
            else if(btn.Text == ",")
            {
                int virgulSayisi = txtNum.Text.Count(a => a == ',');
                if (virgulSayisi<1)
                {
                    txtNum.Text += ",";
                }
            }
            else
            {
                txtNum.Text += btn.Text;
            }
        }
        private void btnMiktar_Click(object sender, EventArgs e)
        {
            nudMiktar.Value = Convert.ToDecimal(txtNum.Text);
            txtNum.Text = "";
            txtBarkod.Focus();
        }
        private void btnOdenen_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "") 
            { 
                double odenen = Convert.ToDouble(txtNum.Text);
                double paraUstu = Convert.ToDouble(txtNum.Text) - genelToplam();
                txtOdenen.Text = odenen.ToString("C2");
                txtParaUstu.Text = paraUstu.ToString("C2");
                txtNum.Text = "";
            }
        }
        private void hizliFiyatEkle(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int id = Convert.ToInt16(btn.Name.Replace("btnHFiyat", ""));
            var fiyat = db.HizliFiyat.Where(a => a.Id == id).FirstOrDefault();
            if (fiyat != null) {
                if(txtNum.Text == "")
                {
                    txtNum.Text = fiyat.Fiyat.ToString();
                }
                else
                {
                    double yeniNumVeri = Convert.ToDouble(txtNum.Text) + Convert.ToDouble(fiyat.Fiyat);
                    txtNum.Text = yeniNumVeri.ToString();
                }
            }
        }
        private void btnBarkod_Click(object sender, EventArgs e)
        {
            if(txtNum.Text != "")
            {
                string barkod = txtNum.Text;
                if(db.Urun.Where(a=> a.Barkod == barkod).Any())
                {
                    var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                    txtNum.Clear();
                    urunGetirListeye(urun, Convert.ToDouble(nudMiktar.Value), barkod);
                    txtBarkod.Focus();
                    genelToplamYazdir();
                }
                else
                {
                    MessageBox.Show("Ürün Ekleme Sayfası");
                }
            }
        }
        private void btnDigerUrun_Click(object sender, EventArgs e)
        {
            if(txtNum.Text != "")
            {
                int satirSayisi = gridSatisListesi.Rows.Count;
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirSayisi].Cells["urunBarkod"].Value = "-"; // Diger Urun olarak barkod veriyoruz
                gridSatisListesi.Rows[satirSayisi].Cells["urunAdi"].Value = "Diğer Ürün";
                gridSatisListesi.Rows[satirSayisi].Cells["urunGrup"].Value = "Diğer Ürün";
                gridSatisListesi.Rows[satirSayisi].Cells["urunBirim"].Value = "Adet";
                gridSatisListesi.Rows[satirSayisi].Cells["urunFiyat"].Value = Convert.ToDouble(txtNum.Text);
                gridSatisListesi.Rows[satirSayisi].Cells["urunMiktar"].Value = nudMiktar.Value;
                gridSatisListesi.Rows[satirSayisi].Cells["urunToplam"].Value = Convert.ToDouble(txtNum.Text) * Convert.ToDouble(nudMiktar.Value);
                gridSatisListesi.Rows[satirSayisi].Cells["urunKdv"].Value = 0;
                gridSatisListesi.Rows[satirSayisi].Cells["urunAlisFiyat"].Value = 0;
                genelToplamYazdir(); // Genel toplamı hesaplıyoruz ve ekrana yazdırıyoruz
                gridSatisListesi.ClearSelection(); // DataGridView'den seçimi temizliyoruz
                txtNum.Clear(); // Numara kutusunu temizliyoruz
                nudMiktar.Value = 1; // Miktar kutusunu 1'e alıyoruz
                txtBarkod.Focus(); // Barkod kutusuna odaklıyoruz
            }

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle(); // Temizle fonksiyonunu çağırıyoruz
        }
        private void Temizle()
        {
            nudMiktar.Value = 1; // Miktar kutusunu 1'e alıyoruz
            txtBarkod.Clear(); // Barkod kutusunu temizliyoruz
            txtOdenen.Clear(); // Ödenen kutusunu temizliyoruz
            txtParaUstu.Clear(); // Para üstü kutusunu temizliyoruz
            txtToplam.Text = 0.ToString("C2"); // Toplam kutusunu temizliyoruz
            gridSatisListesi.Rows.Clear(); // DataGridView'den tüm satırları temizliyoruz
            cbxSatis.Checked = false; // Satış kutusunu Satış Yapılıyor olarak ayarlıyoruz

        }
        private void btnIade_Click(object sender, EventArgs e)
        {
            if(!cbxSatis.Checked)
            {
                cbxSatis.Checked = true;
                cbxSatis.Text = "İADE YAPILIYOR";
            }
            else
            {
                cbxSatis.Checked = false;
                cbxSatis.Text = "SATIŞ YAPILIYOR";
            }
            satisYap("Nakit");
        }
        public void satisYap(string odemeTuru)
        {
            int satirSayisi = gridSatisListesi.Rows.Count;
            bool iade = cbxSatis.Checked;
            double alisFiyatToplam = 0.00;
            if(satirSayisi > 0)
            {
                int? islemNo = db.Islem.First().IslemNo;
                Satis satis = new Satis();
                for(int i = 0; i < satirSayisi; i++)
                {
                    satis.IslemNo = islemNo;
                    satis.UrunBarkod = gridSatisListesi.Rows[i].Cells["urunBarkod"].Value.ToString();
                    satis.UrunAd = gridSatisListesi.Rows[i].Cells["urunAdi"].Value.ToString();
                    satis.UrunGrup = gridSatisListesi.Rows[i].Cells["urunGrup"].Value.ToString();
                    satis.UrunBirim = gridSatisListesi.Rows[i].Cells["urunBirim"].Value.ToString();
                    satis.AlisFiyat = Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunAlisFiyat"].Value.ToString().Replace("₺", "").Trim());
                    satis.SatisFiyat = Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunFiyat"].Value.ToString().Replace("₺", "").Trim());
                    satis.Miktar = Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value);
                    satis.Toplam = Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunToplam"].Value.ToString().Replace("₺", "").Trim());
                    satis.KdvTutari = Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunKdv"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value);
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lblKullanici.Text;
                    satis.Iade = iade;
                    satis.OdemeSekli = odemeTuru;
                    db.Satis.Add(satis);
                    db.SaveChanges();
                    alisFiyatToplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunAlisFiyat"].Value.ToString().Replace("₺", "").Trim());
                    if (!iade)
                    {
                        StokAzalt.stokAzalt(gridSatisListesi.Rows[i].Cells["urunBarkod"].Value.ToString(), Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value));
                    }
                    else
                    {
                        StokArttir.stokArttir(gridSatisListesi.Rows[i].Cells["urunBarkod"].Value.ToString(), Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value));
                    }
                }
                IslemOzet islemOzet = new IslemOzet();
                islemOzet.IslemNo = islemNo;
                islemOzet.Iade = iade;
                islemOzet.AlisFiyatToplam = alisFiyatToplam;
                islemOzet.Gelir = false;
                islemOzet.Gider = false;
                if (!iade)
                {
                    if (odemeTuru == "Nakit" || odemeTuru == "Kart" || odemeTuru == "Kart-Nakit")
                    {
                        islemOzet.Aciklama = "Satış İşlemi (" + odemeTuru + ")";
                    }
                    else if (odemeTuru == "Veresiye" || odemeTuru == "Veresiye-Kart" || odemeTuru == "Veresiye-Nakit")
                    {
                        islemOzet.Aciklama = "Veresiye İşlemi (" + odemeTuru + ")";
                        Veresiye veresiye = new Veresiye();
                        veresiye.IslemNo = islemNo;
                        veresiye.Odeme = false; // Veresiye ödemesi henüz yapılmadı
                        db.Veresiye.Add(veresiye);
                    }
                }
                else
                {
                    islemOzet.Aciklama = "İade İşlemi (" + odemeTuru + ")";
                }
                islemOzet.OdemeSekli = odemeTuru;
                islemOzet.Tarih = DateTime.Now;
                islemOzet.Kullanici = lblKullanici.Text;
                switch(odemeTuru)
                {
                    case "Nakit":
                        islemOzet.Nakit = genelToplam();
                        islemOzet.Kart = 0;
                        break;
                    case "Kart":
                        islemOzet.Nakit = 0;
                        islemOzet.Kart = genelToplam();
                        break;
                    case "Kart-Nakit":
                        islemOzet.Nakit = nakitKartTutar;
                        islemOzet.Kart = genelToplam() - nakitKartTutar;
                        break;
                    case "Veresiye":
                        islemOzet.Nakit = 0;
                        islemOzet.Kart = 0;
                        break;
                    case "Veresiye-Kart":
                        islemOzet.Kart = veresiyeKartTutar;
                        islemOzet.Nakit = 0;
                        break;
                    case "Veresiye-Nakit":
                        islemOzet.Nakit = veresiyeNakitTutar;
                        islemOzet.Kart = 0;
                        break;
                }
                db.IslemOzet.Add(islemOzet);
                db.Islem.First().IslemNo = db.Islem.First().IslemNo + 1;
                db.SaveChanges();
                MessageBox.Show("Yazdırma işlemi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnNakit_Click(object sender, EventArgs e)
        {
            satisYap("Nakit");
        }
        private void btnKart_Click(object sender, EventArgs e)
        {
            satisYap("Kart");
        }
        private void btnKartNakit_Click(object sender, EventArgs e)
        {
            FormNakitKart nakitKartForm = new FormNakitKart(genelToplam(), this);
            nakitKartForm.ShowDialog();
        }
        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            FormVeresiye veresiyeForm = new FormVeresiye(genelToplam(), this);
            veresiyeForm.ShowDialog();
        }
        private void btnBeklet_Click(object sender, EventArgs e)
        {
            islemBeklet(); // Bekletme işlemini yapıyoruz
        }
        private void islemBeklet()
        {
            if (gridSatisListesi.Rows.Count > 0)
            {
                btnBeklet.Text = "İŞLEM BEKLİYOR";
                btnBeklet.BackColor = Color.OrangeRed;
                btnBeklet.FlatAppearance.BorderColor = Color.OrangeRed;
                gridBeklet = new DataGridView();
                gridBeklet.Name = "gridBeklet";
                gridBeklet.Location = new Point(0,0);
                gridBeklet.AllowUserToAddRows = false;
                int satirSayisi = gridSatisListesi.Rows.Count;
                int sutunSayisi = gridSatisListesi.Columns.Count;
                foreach (DataGridViewColumn col in gridSatisListesi.Columns)
                {
                    gridBeklet.Columns.Add((DataGridViewColumn)col.Clone());
                }
                if (satirSayisi > 0)
                {
                    for (int i = 0; i < satirSayisi; i++)
                    {
                        gridBeklet.Rows.Add();
                        for (int a = 0; a < sutunSayisi; a++)
                        {
                            gridBeklet.Rows[i].Cells[a].Value = gridSatisListesi.Rows[i].Cells[a].Value;
                        }
                    }
                    Temizle(); // Temizleme işlemini yapıyoruz
                }
            }
            else
            {
                if(gridBeklet != null)
                {
                    btnBeklet.Text = "İŞLEM BEKLET";
                    btnBeklet.BackColor = Color.Navy;
                    btnBeklet.FlatAppearance.BorderColor = Color.Navy;
                    int satirSayisi = gridBeklet.Rows.Count;
                    int sutunSayisi = gridBeklet.Columns.Count;
                    for (int i = 0; i < satirSayisi; i++)
                    {
                        gridSatisListesi.Rows.Add();
                        for (int a = 0; a < sutunSayisi-1; a++)
                        {
                            gridSatisListesi.Rows[i].Cells[a].Value = gridBeklet.Rows[i].Cells[a].Value;
                        }
                    }
                    gridBeklet = null; // Bekletme işlemi tamamlandıktan sonra gridBeklet'i null yapıyoruz
                    genelToplamYazdir(); // Bekletme işlemi tamamlandıktan sonra genel toplamı yazdırıyoruz

                }

            }
        }

    }
}
