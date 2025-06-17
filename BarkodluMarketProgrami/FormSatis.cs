using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluMarketProgrami
{
    public partial class FormSatis : Form
    {
        private void FormSatis_Load(object sender, EventArgs e)
        {
            hizliUrunDoldur(1);
            hizliKategorileriDoldur();
        }
        BarkodEntities db = new BarkodEntities();
        public FormSatis()
        {
            InitializeComponent();
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                string barkod = txtBarkod.Text.Trim(); // Trim fonksiyonu ile boşlukları atıyoruz
                if (barkod.Length > 2)
                {
                    if(db.Urun.Any(a=> a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a=> a.Barkod == barkod).FirstOrDefault();
                        double miktar = Convert.ToDouble(nudMiktar.Value);
                        urunGetirListeye(urun, miktar, barkod);
                    }
                    else
                    {
                        int onEk = Convert.ToInt32(barkod.Substring(0,2));
                        if(db.Terazi.Any(a=> a.TeraziOnEk == onEk))
                        {
                            string teraziUrunNo = barkod.Substring(2, 5);
                            if(db.Urun.Any(a=> a.Barkod == teraziUrunNo))
                            {
                                var urunTerazi = db.Urun.Where(a => a.Barkod == teraziUrunNo).FirstOrDefault();
                                double miktarKg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                urunGetirListeye(urunTerazi, miktarKg, barkod);
                            }
                            else
                            {
                                Console.Beep(900,1000);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(900, 1000);
                            MessageBox.Show("Normal Ürün Ekleme Sayfası");
                        }
                    }
                }
                else
                {
                    // Barkod numarası 2 karakterden az ise
                    MessageBox.Show("Lütfen Geçerli Bir Barkod Giriniz.");
                }
                gridSatisListesi.ClearSelection();
                txtToplam.Text = genelToplam().ToString("C2");
                txtBarkod.Focus();
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
        private void FormSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) 
            {
                // Her F5 Tuşlayışında Miktar 1 artıcak
                nudMiktar.Value = nudMiktar.Value++;
            }
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
        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView'den ürün silme işlemi
            if (e.ColumnIndex == 9) // DataGridView'den seçilenin sil tuşu olduğundan emin oluyoruz
            {
                if(Convert.ToDouble(gridSatisListesi.CurrentRow.Cells["urunMiktar"].Value) == 1) // Eğer ki ürün miktarı 1 ise zaten eksiltilemeyeceğine göre direkt olarak kaldırıyoruz
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
                txtToplam.Text = genelToplam().ToString("C2"); // Ürün silme işleminden sonra genel toplam bölümüne yazdırıyoruz C2 ile para birimi ekliyoruz(Bilgisayarın konumuna ve diline göre para birimi değişebilmekte)
                txtBarkod.Clear(); // Barkod kutusunu temizliyoruz
                txtBarkod.Focus(); // Barkod kutusuna odaklıyoruz
            }
        }
        private void hizliUrunDoldur(int hizliKategoriID)
        {
            var hizliUrun = db.HizliUrun.Where(a => a.HizliKategoriID == hizliKategoriID).ToList(); // Veritabanındaki HizliUrun tablosunu listeledik
            int count = 0;
            foreach (var hUrun in hizliUrun) // Foreach döngüsü oluşturarak tüm Hızlı Ürün tuşlarının değerlerini otomatik değiştiriyoruz
            {
                count++;
                Button hUrunButton = this.Controls.Find("btnHizli" + count, true).FirstOrDefault() as Button;
                if (hUrunButton != null)
                {
                    hUrunButton.Text = hUrun.UrunAd + "\n" + hUrun.Fiyat.ToString();
                }
            }
        }
        private void hizliKategorileriDoldur()
        {
            var hizliKategori = db.HizliKategori.ToList(); // HizliKategori tablosunu listeliyoruz
            foreach(var hKategori in hizliKategori)
            {
                Button hKategoriButton = this.Controls.Find("btnHizliKategori" + hKategori.Id, true).FirstOrDefault() as Button;
                if(hKategoriButton != null)
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
                hizliUrunDoldur(Convert.ToInt32(hKategoriButtonID));
            }
        }
    }
}
