using iTextSharp.text;
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
    public partial class FormKullaniciAyarlari : Form
    {
        public FormKullaniciAyarlari()
        {
            InitializeComponent();
        }
        BarkodEntities db = new BarkodEntities();
        Random rastgele = new Random();
        private void FormKullaniciAyarlari_Load(object sender, EventArgs e)
        {
            tabloDoldur();
            rastgeleKullaniciKodu();
            txtAdSoyad.Focus();
        }
        private void tabloDoldur(int kullaniciKod = 0)
        {
            var kullanicilar = db.Kullanici.Select(
            x => new
            {
                x.AdSoyad,
                x.Telefon,
                x.KullaniciKod,
                x.Sifre,
                x.Satis,
                x.GenelRapor,
                x.StokTakibi,
                x.UrunGiris,
                x.FiyatGuncelle,
                x.Veresiye,
                x.Ayarlar,
                x.Yedekleme,
                x.KullaniciAyarlari,
                x.Tarih
            }).ToList();

            gridSonucListesi.DataSource = kullanicilar;
            gridSonucListesi.Columns["KullaniciKod"].HeaderText = "Kullanıcı Kodu";
            gridSonucListesi.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            gridSonucListesi.Columns["Sifre"].HeaderText = "Şifre";
            gridSonucListesi.Columns["Satis"].HeaderText = "Satış";
            gridSonucListesi.Columns["GenelRapor"].HeaderText = "Raporlama";
            gridSonucListesi.Columns["StokTakibi"].HeaderText = "Stok Takibi";
            gridSonucListesi.Columns["UrunGiris"].HeaderText = "Ürün Giriş";
            gridSonucListesi.Columns["FiyatGuncelle"].HeaderText = "Fiyat Güncelleme";
            gridSonucListesi.Columns["Veresiye"].HeaderText = "Veresiye İşlemleri";
            gridSonucListesi.Columns["KullaniciAyarlari"].HeaderText = "Kullanıcı Ayarları";
        }
        private void gridSonucListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.ToString() == "True")
            {
                e.Value = "Evet";
            }
            else if (e.Value.ToString() == "False")
            {
                e.Value = "Hayır";
            }
            else if (gridSonucListesi.Columns[e.ColumnIndex].HeaderText == "Şifre")
            {
                e.Value = "*******";
            }
        }
        private void rastgeleKullaniciKodu()
        {
            txtKullaniciKodu.Text = rastgele.Next(000, 999).ToString();
        }
        private void Temizle()
        {
            txtAdSoyad.Text = string.Empty;
            txtTelNo.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSifreTkr.Text = string.Empty;
            cbxSatis.Checked = false;
            cbxAyarlar.Checked = false;
            cbxGenelRapor.Checked = false;
            cbxStokTakibi.Checked = false;
            cbxKullaniciAyarlari.Checked = false;
            cbxUrunGiris.Checked = false;
            cbxUrunGuncelle.Checked = false;
            cbxVeresiye.Checked = false;
            cbxYedekleme.Checked = false;
            rastgeleKullaniciKodu();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciKodu.Text) && !string.IsNullOrEmpty(txtAdSoyad.Text) && !string.IsNullOrEmpty(txtSifre.Text) && !string.IsNullOrEmpty(txtSifreTkr.Text))
            {
                if(txtSifreTkr.Text.Trim() == txtSifre.Text.Trim())
                {
                    Kullanici kullanici = new Kullanici();
                    kullanici.AdSoyad = txtAdSoyad.Text.Trim();
                    kullanici.Telefon = txtTelNo.Text.Trim();
                    kullanici.KullaniciKod = Convert.ToInt16(txtKullaniciKodu.Text.Trim());
                    kullanici.Sifre = txtSifre.Text.Trim();
                    kullanici.Satis = cbxSatis.Checked;
                    kullanici.GenelRapor = cbxGenelRapor.Checked;
                    kullanici.StokTakibi = cbxStokTakibi.Checked;
                    kullanici.UrunGiris = cbxUrunGiris.Checked;
                    kullanici.FiyatGuncelle = cbxUrunGuncelle.Checked;
                    kullanici.Veresiye = cbxVeresiye.Checked;
                    kullanici.Ayarlar = cbxAyarlar.Checked;
                    kullanici.Yedekleme = cbxYedekleme.Checked;
                    kullanici.KullaniciAyarlari = cbxAyarlar.Checked;
                    kullanici.Tarih = DateTime.Now;
                    db.Kullanici.Add(kullanici);
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı başarı ile kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabloDoldur();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Şifreler birbiri ile uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridSonucListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           int kKod = Convert.ToInt16(gridSonucListesi.Rows[e.RowIndex].Cells[2].Value);
            if (db.Kullanici.Where(x => x.KullaniciKod == kKod).Any()) 
            { 
                var kullanici = db.Kullanici.Where(x => x.KullaniciKod == kKod).FirstOrDefault();
                txtKullaniciKodu.Text = kullanici.KullaniciKod.ToString();
                txtAdSoyad.Text = kullanici.AdSoyad;
                txtTelNo.Text = kullanici.Telefon;
                txtSifre.Text = kullanici.Sifre;
                txtSifreTkr.Text = kullanici.Sifre;
                cbxSatis.Checked = kullanici.Satis ?? false;
                cbxGenelRapor.Checked = kullanici.GenelRapor ?? false;
                cbxStokTakibi.Checked = kullanici.StokTakibi ?? false;
                cbxUrunGiris.Checked = kullanici.UrunGiris ?? false;
                cbxUrunGuncelle.Checked = kullanici.FiyatGuncelle ?? false;
                cbxVeresiye.Checked = kullanici.Veresiye ?? false;
                cbxAyarlar.Checked = kullanici.Ayarlar ?? false;
                cbxYedekleme.Checked = kullanici.Yedekleme ?? false;
                cbxKullaniciAyarlari.Checked = kullanici.KullaniciAyarlari ?? false;
            }
        }
    }
}
