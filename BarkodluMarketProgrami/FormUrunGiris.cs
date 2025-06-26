using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace BarkodluMarketProgrami
{
    public partial class FormUrunGiris : Form
    {
        BarkodEntities db = new BarkodEntities();
        Random rastgeleBarkod = new Random();
        public FormUrunGiris(string barkod = "")
        {
            InitializeComponent();
            txtBarkod.Text = barkod;
            kayitliUrunSayisiGetir();
            urunGrubuDoldur();
            
        }
        private void btnEkranKlavyesi_Click(object sender, EventArgs e)
        {
            Process.Start("osk.exe");
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Barkod girildiğinde yapılacak işlemler
                if (txtBarkod.Text.Trim() != "")
                {
                    if(db.Urun.Any(x=> x.Barkod == txtBarkod.Text.Trim()))
                    {
                        var urun = db.Urun.Where(x => x.Barkod == txtBarkod.Text.Trim()).SingleOrDefault();
                        txtUrunAdi.Text = urun.UrunAd;
                        txtUrunAciklama.Text = urun.Aciklama;
                        cmbUrunGrubu.Text = urun.UrunGrup;
                        cmbBirim.Text = urun.Birim;
                        nudAlisFiyati.Value = Convert.ToDecimal(urun.AlisFiyat);
                        nudSatisFiyati.Value = Convert.ToDecimal(urun.SatisFiyat);
                        nudMiktar.Value = Convert.ToDecimal(urun.Miktar);
                        nudKdvOrani.Value = Convert.ToInt32(urun.KdvOrani);
                    }
                    else
                    {
                        MessageBox.Show("Ürün kayıtlı değil ekleyebilirsiniz..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir barkod giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Temizle();
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBarkod.Text.ToString()) && !String.IsNullOrEmpty(txtUrunAdi.Text.ToString()) && !String.IsNullOrEmpty(cmbBirim.Text.ToString()) && !String.IsNullOrEmpty(cmbUrunGrubu.Text.ToString()))
            {
                if (db.Urun.Any(x => x.Barkod == txtBarkod.Text.Trim()))
                {
                    var guncellenecekUrun = db.Urun.Where(x => x.Barkod == txtBarkod.Text.Trim()).SingleOrDefault();
                    guncellenecekUrun.UrunAd = txtUrunAdi.Text.Trim();
                    guncellenecekUrun.Aciklama = txtUrunAciklama.Text.Trim();
                    guncellenecekUrun.UrunGrup = cmbUrunGrubu.Text.Trim();
                    guncellenecekUrun.Birim = cmbBirim.Text.Trim();
                    guncellenecekUrun.AlisFiyat = Convert.ToDouble(nudAlisFiyati.Value);
                    guncellenecekUrun.SatisFiyat = Convert.ToDouble(nudSatisFiyati.Value);
                    guncellenecekUrun.KdvOrani = Convert.ToInt32(nudKdvOrani.Value);
                    guncellenecekUrun.KdvTutari = Math.Round(Convert.ToDouble(nudSatisFiyati.Value) * Convert.ToInt32(nudKdvOrani.Value) / 100, 2);
                    guncellenecekUrun.Miktar = Convert.ToDouble(nudMiktar.Value);
                    guncellenecekUrun.Tarih = DateTime.Now;
                    guncellenecekUrun.Kullanici = lblKullanici.Text.Trim();
                    db.SaveChanges();
                    MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StokHareketEkle stokHareketEkle = new StokHareketEkle(txtBarkod.Text.Trim(), txtUrunAdi.Text.Trim(), cmbBirim.Text.Trim(), cmbUrunGrubu.Text.Trim(), Convert.ToDouble(nudMiktar.Value), lblKullanici.Text.Trim(), DateTime.Now);
                    Temizle();
                    kayitliUrunSayisiGetir();
                }
                else
                {
                    if (!db.Urun.Any(x => x.Barkod == txtBarkod.Text.Trim()))
                    {
                        Urun urun = new Urun();
                        urun.Barkod = txtBarkod.Text.Trim();
                        urun.UrunAd = txtUrunAdi.Text.Trim();
                        urun.Aciklama = txtUrunAciklama.Text.Trim();
                        urun.UrunGrup = cmbUrunGrubu.Text.Trim();
                        urun.Birim = cmbBirim.Text.Trim();
                        urun.AlisFiyat = Convert.ToDouble(nudAlisFiyati.Value);
                        urun.SatisFiyat = Convert.ToDouble(nudSatisFiyati.Value);
                        urun.KdvOrani = Convert.ToInt32(nudKdvOrani.Value);
                        urun.KdvTutari = Math.Round(Convert.ToDouble(nudSatisFiyati.Value) * Convert.ToInt32(nudKdvOrani.Value) / 100, 2);
                        urun.Miktar = Convert.ToDouble(nudMiktar.Value);
                        urun.Tarih = DateTime.Now;
                        urun.Kullanici = lblKullanici.Text.Trim();
                        db.Urun.Add(urun);
                        db.SaveChanges();
                        MessageBox.Show("Ürün başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StokHareketEkle stokHareketEkle = new StokHareketEkle(txtBarkod.Text.Trim(), txtUrunAdi.Text.Trim(), cmbBirim.Text.Trim(), cmbUrunGrubu.Text.Trim(), Convert.ToDouble(nudMiktar.Value), lblKullanici.Text.Trim(), DateTime.Now);
                        Temizle();
                        kayitliUrunSayisiGetir();
                    }
                    else
                    {
                        var urun = db.Urun.Where(x => x.Barkod == txtBarkod.Text.Trim()).SingleOrDefault();
                        txtUrunAdi.Text = urun.UrunAd;
                        txtUrunAciklama.Text = urun.Aciklama;
                        cmbUrunGrubu.Text = urun.UrunGrup;
                        cmbBirim.Text = urun.Birim;
                        nudAlisFiyati.Value = Convert.ToDecimal(urun.AlisFiyat);
                        nudSatisFiyati.Value = Convert.ToDecimal(urun.SatisFiyat);
                        nudMiktar.Value = Convert.ToDecimal(urun.Miktar);
                        nudKdvOrani.Value = Convert.ToInt32(urun.KdvOrani);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli tüm alanları doldurunuz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Temizle()
        {
            if (cbxSonUrunleriGoster.Checked) { cbxSonUrunleriGoster.Checked = false; }
            gridSonucListesi.Rows.Clear();
            txtUrunAdiAranan.Clear();
            txtBarkod.Clear();
            txtUrunAdi.Clear();
            txtUrunAciklama.Clear();
            cmbUrunGrubu.Text = "";
            cmbBirim.Text = "";
            nudAlisFiyati.Value = 1;
            nudSatisFiyati.Value = 1;
            nudMiktar.Value = 1;
            nudKdvOrani.Value = 1;
            txtBarkod.Focus();
        }
        private void sonUrunler(int max = 20)
        {
            var urunler = db.Urun.OrderByDescending(a => a.Tarih).Take(max).ToList();
            int i = 0;
            foreach (var urun in urunler)
            {
                gridSonucListesi.Rows.Add();
                gridSonucListesi.Rows[i].Cells["urunBarkod"].Value = urun.Barkod;
                gridSonucListesi.Rows[i].Cells["urunAdi"].Value = urun.UrunAd;
                gridSonucListesi.Rows[i].Cells["urunAciklama"].Value = urun.Aciklama;
                gridSonucListesi.Rows[i].Cells["urunGrup"].Value = urun.UrunGrup;
                gridSonucListesi.Rows[i].Cells["urunAlisFiyati"].Value = Convert.ToDouble(urun.AlisFiyat).ToString("C2");
                gridSonucListesi.Rows[i].Cells["urunSatisFiyati"].Value = Convert.ToDouble(urun.SatisFiyat).ToString("C2");
                gridSonucListesi.Rows[i].Cells["urunKdvTutari"].Value = urun.KdvTutari;
                gridSonucListesi.Rows[i].Cells["urunBirim"].Value = urun.Birim;
                gridSonucListesi.Rows[i].Cells["urunMiktar"].Value = urun.Miktar;
                gridSonucListesi.Rows[i].Cells["urunTarih"].Value = urun.Tarih;
                gridSonucListesi.Rows[i].Cells["urunKullanici"].Value = urun.Kullanici;
                i++;
            }
        }
        private void cbxSonUrunleriGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSonUrunleriGoster.Checked) 
            {
                sonUrunler();
                txtUrunAdiAranan.Text = "";
                nudBulunanUrunSayisi.Value = gridSonucListesi.Rows.Count;
                nudKayitliUrunSayisi.Value = db.Urun.Count();
            }
            else
            {
                gridSonucListesi.Rows.Clear();
                nudBulunanUrunSayisi.Value = 0;
            }
        }
        private void txtUrunAdiAranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtUrunAdiAranan.Text.Length > 2)
            {
                cbxSonUrunleriGoster.Checked = false;
                var bulunanUrunler = db.Urun.Where(x => x.UrunAd.Contains(txtUrunAdiAranan.Text)).ToList();
                nudBulunanUrunSayisi.Value = bulunanUrunler.Count();
                if(bulunanUrunler != null)
                {
                    foreach (var urun in bulunanUrunler)
                    {
                        if(!string.IsNullOrEmpty(urun.Barkod.ToString()))
                        {
                            bool barkodZatenVar = false;
                            
                            foreach(DataGridViewRow row in gridSonucListesi.Rows)
                            {
                                if(row.Cells["urunBarkod"].Value.ToString() == urun.Barkod.ToString())
                                {
                                    barkodZatenVar = true;
                                    break;
                                }
                            }
                            if (!barkodZatenVar)
                            {
                                int yeniSatir = gridSonucListesi.Rows.Add();
                                gridSonucListesi.Rows[yeniSatir].Cells["urunBarkod"].Value = urun.Barkod;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunAdi"].Value = urun.UrunAd;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunAciklama"].Value = urun.Aciklama;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunGrup"].Value = urun.UrunGrup;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunAlisFiyati"].Value = Convert.ToDouble(urun.AlisFiyat).ToString("C2");
                                gridSonucListesi.Rows[yeniSatir].Cells["urunSatisFiyati"].Value = Convert.ToDouble(urun.SatisFiyat).ToString("C2");
                                gridSonucListesi.Rows[yeniSatir].Cells["urunKdvTutari"].Value = urun.KdvTutari;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunBirim"].Value = urun.Birim;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunMiktar"].Value = urun.Miktar;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunTarih"].Value = urun.Tarih;
                                gridSonucListesi.Rows[yeniSatir].Cells["urunKullanici"].Value = urun.Kullanici;
                            }
                        }
                    }
                }
            }
            else
            {
                gridSonucListesi.Rows.Clear();
                nudBulunanUrunSayisi.Value = 0;
            } 
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void kayitliUrunSayisiGetir()
        {
            nudKayitliUrunSayisi.Value = db.Urun.Count();
        }
        private void gridSonucListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 12 && e.RowIndex != -1)
            {
                txtBarkod.Text = gridSonucListesi.Rows[e.RowIndex].Cells["urunBarkod"].Value.ToString();
                txtUrunAdi.Text = gridSonucListesi.Rows[e.RowIndex].Cells["urunAdi"].Value.ToString();
                txtUrunAciklama.Text = gridSonucListesi.Rows[e.RowIndex].Cells["urunAciklama"].Value.ToString();
                cmbUrunGrubu.Text = gridSonucListesi.Rows[e.RowIndex].Cells["urunGrup"].Value.ToString();
                cmbBirim.Text = gridSonucListesi.Rows[e.RowIndex].Cells["urunBirim"].Value.ToString();
                nudAlisFiyati.Value = Convert.ToDecimal(gridSonucListesi.Rows[e.RowIndex].Cells["urunAlisFiyati"].Value.ToString().Replace("₺",""));
                nudSatisFiyati.Value = Convert.ToDecimal(gridSonucListesi.Rows[e.RowIndex].Cells["urunSatisFiyati"].Value.ToString().Replace("₺", ""));
                nudMiktar.Value = Convert.ToDecimal(gridSonucListesi.Rows[e.RowIndex].Cells["urunMiktar"].Value);
            }
        }
        private void btnUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            FormUrunGrubuEkle formUrunGrubuEkle = new FormUrunGrubuEkle(this);
            formUrunGrubuEkle.ShowDialog();
        }
        public void urunGrubuDoldur()
        {
            cmbUrunGrubu.DisplayMember = "GrupAdi";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = db.UrunGrubu.OrderBy(a=> a.GrupAdi).ToList();
            cmbUrunGrubu.SelectedIndex = -1; // İlk başta seçili olmasın
        }
        private void btnBarkod_Click(object sender, EventArgs e)
        {
            String yeniBarkod = barkodOlustur();
            if (!String.IsNullOrEmpty(yeniBarkod))
            {
                if(!db.Urun.Any(x=> x.Barkod == yeniBarkod))
                {
                    txtBarkod.Text = yeniBarkod;
                }
                else
                {
                    MessageBox.Show("Lütfen tekrar deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string barkodOlustur()
        {
            string yeniBarkod = 0.ToString() + 0.ToString() + rastgeleBarkod.Next(100000, 999999).ToString();
            return yeniBarkod;

        }
        private void gridSonucListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                DialogResult result = MessageBox.Show(gridSonucListesi.Rows[e.RowIndex].Cells["urunAdi"].Value.ToString() +" ürünü adlı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string barkod = gridSonucListesi.Rows[e.RowIndex].Cells["urunBarkod"].Value.ToString();
                    var urun = db.Urun.Where(x => x.Barkod == barkod).SingleOrDefault();
                    if (urun != null)
                    {
                        db.Urun.Remove(urun);
                        db.SaveChanges();
                        MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kayitliUrunSayisiGetir();
                        Temizle();
                        cbxSonUrunleriGoster.Checked = true;
                        //sonUrunler();
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
