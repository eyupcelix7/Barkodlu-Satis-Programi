using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluMarketProgrami
{
    internal class StokHareketEkle
    {
        public StokHareketEkle(string barkod, string urunAd, string birim, string urunGrup, double miktar, string kullanici, DateTime tarih)
        {
            using (BarkodEntities db = new BarkodEntities())
            {
                if(db.Urun.Any(x => x.Barkod == barkod))
                {
                    var stokHareket = new StokHareket
                    {
                        Barkod = barkod,
                        UrunAd = urunAd,
                        Birim = birim,
                        UrunGrup = urunGrup,
                        Miktar = miktar,
                        Aciklama = "Stok Güncelleme İşlemi",
                        Kullanici = kullanici,
                        Tarih = tarih
                    };
                    db.StokHareket.Add(stokHareket);
                    db.SaveChanges();
                }
                else
                {
                    var stokHareket = new StokHareket
                    {
                        Barkod = barkod,
                        UrunAd = urunAd,
                        Birim = birim,
                        UrunGrup = urunGrup,
                        Miktar = miktar,
                        Aciklama = "Stok Ekleme İşlemi",
                        Kullanici = kullanici,
                        Tarih = tarih
                    };
                    db.StokHareket.Add(stokHareket);
                    db.SaveChanges();

                }
            }
        }
    }
}
