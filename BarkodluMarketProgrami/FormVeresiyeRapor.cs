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
            //Cursor.Current = Cursors.WaitCursor;
            //DateTime baslangicTarihi = DateTime.Parse(dtpBaslangicTarihi.Value.ToShortDateString());
            //DateTime bitisTarihi = DateTime.Parse(dtpBitisTarihi.Value.ToShortDateString()).AddDays(1);
            //using (var db = new BarkodEntities())
            //{
            //    if (rdbTumu.Checked)
            //    {
            //        var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).OrderByDescending(a => a.Tarih).ToList();
            //        var satisOzet = db.Satis.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).ToList();
            //        tabloDoldur(islemOzet, satisOzet);
            //    }
            //    else if (rdbSatislar.Checked)
            //    {
            //        var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == false && x.Gelir == false && x.Gider == false).OrderByDescending(a => a.Tarih).ToList();
            //        var satisOzet = db.Satis.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).ToList();
            //        tabloDoldur(islemOzet, satisOzet);
            //    }
            //    else if (rdbIadeler.Checked)
            //    {
            //        var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == true && x.Gelir == false && x.Gider == false).OrderByDescending(a => a.Tarih).ToList();
            //        var satisOzet = db.Satis.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).ToList();
            //        tabloDoldur(islemOzet, satisOzet);
            //    }
            //    else if (rdbGelirler.Checked)
            //    {
            //        var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == false && x.Gelir == true && x.Gider == false).OrderByDescending(a => a.Tarih).ToList();
            //        tabloDoldur(islemOzet, null);
            //    }
            //    else if (rdbGiderler.Checked)
            //    {
            //        var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == false && x.Gelir == false && x.Gider == true).OrderByDescending(a => a.Tarih).ToList();
            //        tabloDoldur(islemOzet, null);
            //    }
            //}
            //Cursor.Current = guncelCursor;
        }
        private void tabloDoldur(List<IslemOzet> islemOzet, List<Satis> satisOzet)
        {
        }

        private void btnVeresiyeAl_Click(object sender, EventArgs e)
        {
            FormVeresiyeEkle fV = new FormVeresiyeEkle();
            fV.ShowDialog();
        }
    }
}
