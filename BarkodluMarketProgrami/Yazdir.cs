using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluMarketProgrami
{
    internal class Yazdir
    {
        PrintDocument printDoc = new PrintDocument();
        int _islemNo = 0;
        public Yazdir(int? islemNo)
        {
            _islemNo = (int)islemNo;
            try
            {
                printDoc.PrintPage += PrintDoc_PrintPage;
                printDoc.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show("Bir hata oluştu: "+e.Message);
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            BarkodEntities db = new BarkodEntities();
            var firma = db.Ayarlar.SingleOrDefault();
            var satisListe = db.Satis.Where(x=> x.IslemNo == _islemNo).ToList();
            if (satisListe != null)
            {
                int kagitUzunlugu = 125;
                for (int j = 0; j < satisListe.Count; j++)
                {
                    kagitUzunlugu += 20;
                }
                PaperSize ps58 = new PaperSize("58mm Termal", 220, kagitUzunlugu + 120);
                printDoc.DefaultPageSettings.PaperSize = ps58;

                Font baslikFont = new Font("Arial", 7, FontStyle.Bold);
                Font bilgiFont = new Font("Arial", 5,FontStyle.Bold);
                Font icerikBaslik = new Font("Arial", 5,FontStyle.Underline);
                StringFormat baslikOrtala = new StringFormat(StringFormatFlags.FitBlackBox);
                baslikOrtala.Alignment = StringAlignment.Center;
                RectangleF rcBaslik = new RectangleF(0, 20, 220, 20);
                e.Graphics.DrawString(firma.FirmaAd, baslikFont, Brushes.Black, rcBaslik,baslikOrtala);
                e.Graphics.DrawString("İşlem No: " + _islemNo.ToString(), bilgiFont, Brushes.Black, new Point(5,45));
                e.Graphics.DrawString("Telefon Numarası: "+ firma.Telefon, bilgiFont, Brushes.Black, new Point(5,60));
                e.Graphics.DrawString("Tarih: "+DateTime.Now.ToString(), bilgiFont, Brushes.Black, new Point(5,75));
                e.Graphics.DrawString("----------------------------------------------------------------------------------------", bilgiFont, Brushes.Black, new Point(5,90));
                
                e.Graphics.DrawString("Ürün Adı", icerikBaslik, Brushes.Black, new Point(5, 105));
                e.Graphics.DrawString("Miktar", icerikBaslik, Brushes.Black, new Point(90, 105));
                e.Graphics.DrawString("Br.Fiyat", icerikBaslik, Brushes.Black, new Point(130, 105));
                e.Graphics.DrawString("Tutar", icerikBaslik, Brushes.Black, new Point(180, 105));

                int i = 125;
                double genelToplam = 0;
                foreach (var satisBilgi in satisListe)
                {
                    e.Graphics.DrawString(satisBilgi.UrunAd, bilgiFont, Brushes.Black, new Point(5, i));
                    e.Graphics.DrawString(satisBilgi.Miktar.ToString(), bilgiFont, Brushes.Black, new Point(90, i));
                    e.Graphics.DrawString(Convert.ToDouble(satisBilgi.SatisFiyat).ToString("C2"), bilgiFont, Brushes.Black, new Point(130, i));
                    e.Graphics.DrawString(Convert.ToDouble(satisBilgi.Toplam).ToString("C2"), bilgiFont, Brushes.Black, new Point(180, i));
                    i += 20;
                    genelToplam += (double)satisBilgi.Toplam;
                }
                e.Graphics.DrawString("----------------------------------------------------------------------------------------", bilgiFont, Brushes.Black, new Point(5, i));
                e.Graphics.DrawString("Toplam Tutar: "+genelToplam.ToString("C2"), bilgiFont, Brushes.Black, new Point(5, i+20));
                e.Graphics.DrawString("----------------------------------------------------------------------------------------", bilgiFont, Brushes.Black, new Point(5, i+40));
                e.Graphics.DrawString("(Mali Değeri Yoktur)", bilgiFont, Brushes.Black, new Point(5, i+60));
            }
        }
    }
}
