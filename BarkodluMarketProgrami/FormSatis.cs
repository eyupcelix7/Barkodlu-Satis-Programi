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
    public partial class FormSatis : Form
    {
        BarkodEntities db = new BarkodEntities();
        public FormSatis()
        {
            InitializeComponent();
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                string barkod = txtBarkod.Text.Trim(); // Trim fonksiyonu ile boşlukları atıyoruz
                if (barkod.Length > 2)
                {
                    if(db.Urun.Any(a=> a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a=> a.Barkod == barkod).FirstOrDefault();
                        int satirSayisi = gridSatisListesi.Rows.Count;
                        double miktar = Convert.ToDouble(nudMiktar.Value);
                        bool eklendiMi = false;
                        if (satirSayisi > 0)
                        {
                            for (int i = 0; i < satirSayisi; i++)
                            {
                                if (gridSatisListesi.Rows[i].Cells["urunBarkod"].Value.ToString() == barkod)
                                {
                                    gridSatisListesi.Rows[i].Cells["urunMiktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value);
                                    gridSatisListesi.Rows[i].Cells["urunToplam"].Value = Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunMiktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunFiyat"].Value),2);
                                    eklendiMi = true;
                                }
                            }
                        }
                        if (!eklendiMi)
                        {
                            gridSatisListesi.Rows.Add();
                            gridSatisListesi.Rows[satirSayisi].Cells["urunBarkod"].Value = barkod;
                            gridSatisListesi.Rows[satirSayisi].Cells["urunAdi"].Value = urun.UrunAd;
                            gridSatisListesi.Rows[satirSayisi].Cells["urunGrup"].Value = urun.UrunGrup;
                            gridSatisListesi.Rows[satirSayisi].Cells["urunBirim"].Value = urun.Birim;
                            gridSatisListesi.Rows[satirSayisi].Cells["urunFiyat"].Value = urun.SatisFiyat;
                            gridSatisListesi.Rows[satirSayisi].Cells["urunMiktar"].Value = miktar;
                            gridSatisListesi.Rows[satirSayisi].Cells["urunToplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                            gridSatisListesi.Rows[satirSayisi].Cells["urunKdv"].Value = urun.KdvTutari;
                            gridSatisListesi.Rows[satirSayisi].Cells["urunAlisFiyat"].Value = urun.AlisFiyat;
                        }
                    }
                }
                else
                {
                    // Barkod numarası 2 karakterden az ise
                    MessageBox.Show("Lütfen Geçerli Bir Barkod Giriniz.");
                }
                gridSatisListesi.ClearSelection();
                txtToplam.Text = genelToplam().ToString("C2");
                txtBarkod.Focus();
            }
        }
        private double genelToplam()
        {
            double genelToplam = 0.00;
            for (int i = 0; i < gridSatisListesi.Rows.Count; i++) 
            {
                genelToplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["urunToplam"].Value);
            }
            return genelToplam;
        }
        private void FormSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) 
            {
                // Her F5 Tuşlayışında Miktar 1 artıcak
                nudMiktar.Value = nudMiktar.Value++;
            }
        }
    }
}
