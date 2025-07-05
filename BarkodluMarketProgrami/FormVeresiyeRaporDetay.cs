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
        int islemNo = 0;
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
                    if (veresiyeOzet.IslemNo == null)
                    {
                        txtSatis.Text = "Hayır"; 
                    }
                    else { 
                        txtSatis.Text = "Evet";
                        lblDetaylar.Visible = true;
                        var islemNoIdBul = (int)db.Veresiye.Where(x => x.Id == veresiyeId).FirstOrDefault().IslemNo;
                        islemNo = (int)db.IslemOzet.Where(x => x.IslemNo == islemNoIdBul).FirstOrDefault().Id;
                    }
                    nudTutar.Value = (decimal)veresiyeOzet.Tutar;
                    nudTutar.Maximum = (decimal)veresiyeOzet.Tutar;
                    nudTutar.Minimum = (decimal)veresiyeOzet.Tutar;

                    if (!(bool)veresiyeOzet.Odeme) { txtOdeme.Text = "Hayır"; } else { txtOdeme.Text = "Evet"; }
                    dtpTarih.Value = (DateTime)veresiyeOzet.Tarih;
                    dtpTarih.MaxDate = (DateTime)veresiyeOzet.Tarih;
                    dtpTarih.MinDate = (DateTime)veresiyeOzet.Tarih;

                    txtKullanici.Text = veresiyeOzet.Kullanici;

                    // Page 2 - 3
                    var borclar = db.Veresiye.Where(x => x.KullaniciId == kulId && x.Odeme == false).Select(x => new
                    {
                        x.Id,
                        x.KullaniciId,
                        x.IslemNo,
                        x.Tutar,
                        x.Tarih,
                        x.Kullanici
                    }).OrderByDescending(a => a.Tarih).ToList();
                    var odemeler = db.Veresiye.Where(x => x.KullaniciId == kulId && x.Odeme == true).Select(x => new
                    {
                        x.Id,
                        x.KullaniciId,
                        x.IslemNo,
                        x.Tutar,
                        x.Tarih,
                        x.Kullanici
                    }).OrderByDescending(a => a.Tarih).ToList();
                    gridUrunListesi.DataSource = borclar;
                    gridUrunListesi2.DataSource = odemeler;
                    gridUrunListesi.Columns[0].Visible = false; // ID gizliyoruz
                    gridUrunListesi.Columns[1].HeaderText = "Ad Soyad";
                    gridUrunListesi.Columns[2].HeaderText = "Satış Mı?";
                    gridUrunListesi.Columns[3].HeaderText = "Tutar";
                    gridUrunListesi.Columns[5].HeaderText = "Kullanıcı";
                    gridUrunListesi.Columns[3].DefaultCellStyle.Format = "C2";
                    gridUrunListesi2.Columns[0].Visible = false; // ID gizliyoruz
                    gridUrunListesi2.Columns[1].HeaderText = "Ad Soyad";
                    gridUrunListesi2.Columns[2].HeaderText = "Satış Mı?";
                    gridUrunListesi2.Columns[3].HeaderText = "Tutar";
                    gridUrunListesi2.Columns[5].HeaderText = "Kullanıcı";
                    gridUrunListesi2.Columns[3].DefaultCellStyle.Format = "C2";
                }
            }
        }

        private void tableCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            using (var db = new BarkodEntities())
            {
                if (e.ColumnIndex == 1)
                {
                    int kulId = Convert.ToInt32(e.Value);
                    string adSoyad = db.VeresiyeKullanicilar.Where(x => x.Id == kulId).SingleOrDefault().AdSoyad;
                    e.Value = adSoyad;
                }
                else if (e.ColumnIndex == 2)
                {
                    if (e.Value != null && e.Value.ToString() != "")
                    {
                        e.Value = "Evet";
                    }
                    else
                    {
                        e.Value = "Hayır";
                    }
                }
            }
        }

        private void lblDetaylar_Click(object sender, EventArgs e)
        {
            if(txtSatis.Text == "Evet")
            {
                FormRaporDetay fRPD = new FormRaporDetay();
                fRPD.islemId = islemNo;
                fRPD.ShowDialog();
            }
        }
    }
}
