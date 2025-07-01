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
        private void tabloDoldur()
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
    }
}
