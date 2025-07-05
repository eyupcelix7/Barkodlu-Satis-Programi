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
    public partial class FormVeresiyeRaporDetay : Form
    {
        public int veresiyeId { get; set; }
        public int kulId { get; set; }
        public FormVeresiyeRaporDetay()
        {
            InitializeComponent();
        }

        private void FormVeresiyeRaporDetay_Load(object sender, EventArgs e)
        {
            using (var db = new BarkodEntities())
            {
                veresiyeId = (int)db.Veresiye.Where(x => x.Id == veresiyeId).FirstOrDefault().Id;
                this.Text = "#" + veresiyeId.ToString() + " İşlem Detayları";

                if (db.Veresiye.Where(x => x.Id == veresiyeId).Any())
                {
                    // Tekli Sorgu Page
                    var veresiyeOzet = db.Veresiye.Where(x => x.Id == veresiyeId).FirstOrDefault();
                    var veresiyeKullanici = db.VeresiyeKullanicilar.Where(x => x.Id == kulId).FirstOrDefault();

                    txtAdSoyad.Text = veresiyeKullanici.AdSoyad;
                    if (veresiyeOzet.IslemNo == null) { txtSatis.Text = "Hayır"; } else { txtSatis.Text = "Evet"; lblDetaylar.Visible = true; }
                    nudTutar.Value = (decimal)veresiyeOzet.Tutar;
                    nudTutar.Maximum = (decimal)veresiyeOzet.Tutar;
                    nudTutar.Minimum = (decimal)veresiyeOzet.Tutar;

                    if (!(bool)veresiyeOzet.Odeme) { txtOdeme.Text = "Hayır"; } else { txtOdeme.Text = "Evet"; }
                    dtpTarih.Value = (DateTime)veresiyeOzet.Tarih;
                    dtpTarih.MaxDate = (DateTime)veresiyeOzet.Tarih;
                    dtpTarih.MinDate = (DateTime)veresiyeOzet.Tarih;

                    txtKullanici.Text = veresiyeOzet.Kullanici;

                    // Tüm İşlem Page
                    //var urunler = db.Satis.Where(x => x.IslemNo == islemId).Select(x => new
                    //{
                    //    x.UrunAd,
                    //    x.SatisFiyat,
                    //    x.Miktar,
                    //    x.Toplam,
                    //    x.Tarih
                    //}).ToList();
                    //gridUrunListesi.DataSource = urunler;
                    //gridUrunListesi.Columns[0].HeaderText = "Ürün Adı";
                    //gridUrunListesi.Columns[1].HeaderText = "Satış Fiyatı";
                    //gridUrunListesi.Columns[1].DefaultCellStyle.Format = "C2";
                    //gridUrunListesi.Columns[3].HeaderText = "Toplam Fiyat";
                    //gridUrunListesi.Columns[3].DefaultCellStyle.Format = "C2";

                }
            }
        }
    }
}
