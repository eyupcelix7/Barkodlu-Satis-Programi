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
    public partial class FormVeresiyeRapor : Form
    {
        public FormVeresiyeRapor()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblUyari.Text = "("+dtpBaslangicTarihi.Value.ToString("dd-MM-yyyy")+" - "+ dtpBitisTarihi.Value.ToString("dd-MM-yyyy") + "\r\nARASINDAKİ KAYITLAR)";

            DateTime baslangicTarihi = DateTime.Parse(dtpBaslangicTarihi.Value.ToShortDateString());
            DateTime bitisTarihi = DateTime.Parse(dtpBitisTarihi.Value.ToShortDateString()).AddDays(1);
            using (var db = new BarkodEntities())
            {
                if (rdbTumu.Checked)
                {
                    var veresiyeOzet = db.Veresiye.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).Select(x=> new
                    {
                        x.Id,
                        x.Odeme,
                        x.KullaniciId,
                        x.IslemNo,
                        x.Tutar,
                        x.Tarih,
                        x.Kullanici
                    }).OrderByDescending(a => a.Tarih).ToList();
                    nudTopVerVT.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == false).Sum(x => x.Tutar));
                    nudTopOdVT.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == true).Sum(x => x.Tutar));
                    nudTopVerV.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == false).Count());
                    nudTopOdV.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == true).Count());
                    gridSonucListesi.DataSource = veresiyeOzet;
                    tabloDuzenle();
                    lblUyari.Visible = true;
                    if (veresiyeOzet.Count == 0)
                    {
                        MessageBox.Show("Belirtilen tarihler arasında işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rdbOdenilmemisV.Checked)
                {
                    var veresiyeOzet = db.Veresiye.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Odeme == false).Select(x => new
                    {
                        x.Id,
                        x.Odeme,
                        x.KullaniciId,
                        x.IslemNo,
                        x.Tutar,
                        x.Tarih,
                        x.Kullanici
                    }).OrderByDescending(a => a.Tarih).ToList();
                    nudTopVerVT.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == false).Sum(x => x.Tutar));
                    nudTopOdVT.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == true).Sum(x => x.Tutar));
                    nudTopVerV.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == false).Count());
                    nudTopOdV.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == true).Count());
                    gridSonucListesi.DataSource = veresiyeOzet;
                    tabloDuzenle();
                    lblUyari.Visible = true;
                    if (veresiyeOzet.Count == 0)
                    {
                        MessageBox.Show("Belirtilen tarihler arasında işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rdbOdenilmisV.Checked)
                {
                    var veresiyeOzet = db.Veresiye.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Odeme == true).Select(x => new
                    {
                        x.Id,
                        x.Odeme,
                        x.KullaniciId,
                        x.IslemNo,
                        x.Tutar,
                        x.Tarih,
                        x.Kullanici
                    }).OrderByDescending(a => a.Tarih).ToList();
                    nudTopVerVT.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == false).Sum(x => x.Tutar));
                    nudTopOdVT.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == true).Sum(x => x.Tutar));
                    nudTopVerV.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == false).Count());
                    nudTopOdV.Value = (decimal)Convert.ToDouble(veresiyeOzet.Where(x => x.Odeme == true).Count());
                    gridSonucListesi.DataSource = veresiyeOzet;
                    tabloDuzenle();
                    lblUyari.Visible = true;
                    if (veresiyeOzet.Count == 0)
                    {
                        MessageBox.Show("Belirtilen tarihler arasında işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private void tabloDuzenle()
        {
            gridSonucListesi.Columns[0].Visible = false; // ID gizliyoruz
            gridSonucListesi.Columns[1].HeaderText = "İşlem";
            gridSonucListesi.Columns[2].HeaderText = "Ad Soyad";
            gridSonucListesi.Columns[3].HeaderText = "Satış Mı?";
            gridSonucListesi.Columns[4].HeaderText = "Tutar";
            gridSonucListesi.Columns[6].HeaderText = "Kullanıcı";
            gridSonucListesi.Columns[4].DefaultCellStyle.Format = "C2";
        }
        private void btnVeresiyeAl_Click(object sender, EventArgs e)
        {
            FormVeresiyeAlVer fV = new FormVeresiyeAlVer();
            fV.veresiyeTur = "al";
            fV.ShowDialog();

        }
        private void btnVeresiyeVer_Click(object sender, EventArgs e)
        {
            FormVeresiyeAlVer fV = new FormVeresiyeAlVer();
            fV.veresiyeTur = "ver";
            fV.ShowDialog();
        }

        private void gridSonucListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            using(var db = new BarkodEntities())
            {
                if (e.ColumnIndex == 1)
                {
                    if (e.Value.ToString() == "True")
                    {
                        e.Value = "Veresiye";
                    }
                    else
                    {
                        e.Value = "Ödeme";
                    }
                }
                if (e.ColumnIndex == 2)
                {
                    int kulId = Convert.ToInt32(e.Value);
                    string adSoyad = db.VeresiyeKullanicilar.Where(x => x.Id == kulId).SingleOrDefault().AdSoyad;
                    e.Value = adSoyad;
                }
                else if(e.ColumnIndex == 3)
                {
                    if(e.Value != null && e.Value.ToString() != "")
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
        private void gridSonucListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormVeresiyeRaporDetay fVRPD = new FormVeresiyeRaporDetay();
            fVRPD.veresiyeId = Convert.ToInt32(gridSonucListesi.Rows[e.RowIndex].Cells[0].Value);
            fVRPD.kulId = Convert.ToInt32(gridSonucListesi.Rows[e.RowIndex].Cells[2].Value);
            fVRPD.ShowDialog();
        }
    }
}
