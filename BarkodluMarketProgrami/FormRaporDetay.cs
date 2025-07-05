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
    public partial class FormRaporDetay : Form
    {
        public int islemId { get; set; }
        public FormRaporDetay()
        {
            InitializeComponent();
        }
        private void FormRaporDetay_Load(object sender, EventArgs e)
        {
            using(var db = new BarkodEntities())
            {
                islemId = (int)db.IslemOzet.Where(x=> x.Id == islemId).FirstOrDefault().IslemNo;
                this.Text = "#" + islemId.ToString() + " İşlem Detayları";
                lblIslemId.Text = "#" + islemId.ToString() + " Numaralı İşlem";
                if (db.IslemOzet.Where(x => x.IslemNo == islemId).Any()) 
                {
                    // Tekli İşlem Page
                    var islemOzet = db.IslemOzet.Where(x => x.IslemNo == islemId).FirstOrDefault();
                    txtIadeMi.Text = (bool)islemOzet.Iade ? "Evet" : "Hayır";
                    txtOdemeSekli.Text = islemOzet.OdemeSekli;
                    txtGelirMi.Text = (bool)islemOzet.Gelir ? "Evet" : "Hayır";
                    txtGiderMi.Text = (bool)islemOzet.Gider ? "Evet" : "Hayır";
                    nudNakit.Value = (decimal)islemOzet.Nakit;
                    nudNakit.Maximum = (decimal)islemOzet.Nakit;
                    nudNakit.Minimum = (decimal)islemOzet.Nakit;

                    nudKart.Value = (decimal)islemOzet.Kart;
                    nudKart.Maximum = (decimal)islemOzet.Kart;
                    nudKart.Minimum = (decimal)islemOzet.Kart;
                    
                    nudAlisFiyatToplam.Value = (decimal)islemOzet.AlisFiyatToplam;
                    nudAlisFiyatToplam.Maximum = (decimal)islemOzet.AlisFiyatToplam;
                    nudAlisFiyatToplam.Minimum = (decimal)islemOzet.AlisFiyatToplam;

                    dtpTarih.Value = (DateTime) islemOzet.Tarih;
                    dtpTarih.MaxDate = (DateTime)islemOzet.Tarih;
                    dtpTarih.MinDate = (DateTime)islemOzet.Tarih;
                    txtKullanici.Text = islemOzet.Kullanici;
                    rtbAciklama.Text = islemOzet.Aciklama;

                    // Tüm İşlem Page
                    var urunler = db.Satis.Where(x => x.IslemNo == islemId).Select(x => new
                    {
                        x.UrunAd,
                        x.SatisFiyat,
                        x.Miktar,
                        x.Toplam,
                        x.Tarih
                    }).ToList();
                    gridUrunListesi.DataSource = urunler;
                    gridUrunListesi.Columns[0].HeaderText = "Ürün Adı";
                    gridUrunListesi.Columns[1].HeaderText = "Satış Fiyatı";
                    gridUrunListesi.Columns[1].DefaultCellStyle.Format = "C2";
                    gridUrunListesi.Columns[3].HeaderText = "Toplam Fiyat";
                    gridUrunListesi.Columns[3].DefaultCellStyle.Format = "C2";
                }
            }
        }
    }
}
