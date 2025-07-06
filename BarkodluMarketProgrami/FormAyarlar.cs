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
    public partial class FormAyarlar : Form
    {
        BarkodEntities db = new BarkodEntities();
        public FormAyarlar()
        {
            InitializeComponent();
        }
        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            Ayardoldur();
            hizliFiyatDoldur();
            hizliKategoriDoldur();
        }
        private void Ayardoldur()
        {
            var ayarlar = db.Ayarlar.SingleOrDefault();
            var terazi = db.Terazi.SingleOrDefault();
            if (ayarlar != null)
            {
                txtFirmaAd.Text = ayarlar.FirmaAd;
                txtAdSoyad.Text = ayarlar.AdSoyad;
                txtAdres.Text = ayarlar.Adres;
                txtTelNo.Text = ayarlar.Telefon;
                nudKartKomisyon.Value = (decimal) ayarlar.KartKomisyon;
                cbxYazici.Checked = (bool)ayarlar.Yazici;
                txtTeraziOnEk.Text = terazi.TeraziOnEk.ToString();
            }
        }
        private void hizliFiyatDoldur()
        {
            var hizliFiyatlar = db.HizliFiyat.ToList();
            foreach (var fiyat in hizliFiyatlar)
            {
                txtHF1.Text = hizliFiyatlar[0].Fiyat.ToString();
                txtHF2.Text = hizliFiyatlar[1].Fiyat.ToString();
                txtHF3.Text = hizliFiyatlar[2].Fiyat.ToString();
                txtHF4.Text = hizliFiyatlar[3].Fiyat.ToString();
                txtHF5.Text = hizliFiyatlar[4].Fiyat.ToString();
            }
        }
        private void hizliKategoriDoldur()
        {
            var hizliKategoriler = db.HizliKategori.ToList();
            foreach (var kategori in hizliKategoriler)
            {
                txtHK1.Text = hizliKategoriler[0].KategoriAd.ToString();
                txtHK2.Text = hizliKategoriler[1].KategoriAd.ToString();
                txtHK3.Text = hizliKategoriler[2].KategoriAd.ToString();
                txtHK4.Text = hizliKategoriler[3].KategoriAd.ToString();
                txtHK5.Text = hizliKategoriler[4].KategoriAd.ToString();
            }

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ayarlar = db.Ayarlar.SingleOrDefault();
            var terazi = db.Terazi.SingleOrDefault();
            if(ayarlar != null)
            {
                ayarlar.AdSoyad = txtAdSoyad.Text.Trim();
                ayarlar.Adres = txtAdres.Text.Trim();
                ayarlar.Telefon = txtTelNo.Text.Trim();
                ayarlar.KartKomisyon = (double) nudKartKomisyon.Value;
                ayarlar.Yazici = cbxYazici.Checked;
                ayarlar.FirmaAd = txtFirmaAd.Text.Trim();
                terazi.TeraziOnEk = Convert.ToInt16(txtTeraziOnEk.Text.Trim());
                db.SaveChanges();
                MessageBox.Show("Ayarlar Kaydedildi","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnHFiyatKaydet_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 5; i++)
            {
                TextBox hFiyat = this.Controls.Find("txtHF" + i, true).FirstOrDefault() as TextBox;
                db.HizliFiyat.Where(x=> x.Id == i).FirstOrDefault().Fiyat = Convert.ToInt32(hFiyat.Text.Trim());
            }
            db.SaveChanges();
            MessageBox.Show("Hızlı Fiyatlar Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHKKaydet_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                TextBox hKategori = this.Controls.Find("txtHK" + i, true).FirstOrDefault() as TextBox;
                db.HizliKategori.Where(x => x.Id == i).FirstOrDefault().KategoriAd = hKategori.Text.Trim().ToString();
            }
            db.SaveChanges();
            MessageBox.Show("Hızlı Kategoriler Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
