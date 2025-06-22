using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluMarketProgrami
{
    internal class StokAzalt
    {
        public static void stokAzalt(string barkod, double miktar)
        {
            using (var db = new BarkodEntities())
            {
                var urun = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                if (urun != null)
                {
                    urun.Miktar = urun.Miktar - miktar;
                    db.SaveChanges();
                }
                else
                {
                    //throw new Exception("Ürün bulunamadı.");
                }
            }
        }
    }
}
