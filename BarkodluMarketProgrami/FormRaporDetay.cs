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
            this.Text = "#" + islemId.ToString() + " İşlem Detayları";
            lblIslemId.Text = "#"+islemId.ToString()+" Numaralı İşlem";
            using(var db = new BarkodEntities())
            {
                if (db.IslemOzet.Where(x => x.Id == islemId).Any()) 
                {
                    var islemOzet = db.IslemOzet.Where(x => x.Id == islemId).FirstOrDefault();
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
                }
            }
        }
    }
}
