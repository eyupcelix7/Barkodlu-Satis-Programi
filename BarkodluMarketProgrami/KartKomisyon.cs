using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluMarketProgrami
{
    internal class KartKomisyon
    {
        public double KartKomisyonHesapla() {
            using (var db = new BarkodEntities())
            {
                if (db.Ayarlar.Any())
                {
                    return (double) db.Ayarlar.First().KartKomisyon;
                }
                else
                {
                    return (double) 0;
                }
            }

        }
    }
}
