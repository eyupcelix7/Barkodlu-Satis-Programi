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
    public partial class FormFiyatGuncelle : Form
    {
        public FormFiyatGuncelle()
        {
            InitializeComponent();
        }
        BarkodEntities db = new BarkodEntities();
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Barkod ile ürün bilgilerini getiriryotuz
                string barkod = txtBarkod.Text.Trim();
                if(!string.IsNullOrEmpty(barkod))
                {
                    // Veritabanından ürün bilgilerini alıyoruz
                    if(db.Urun.Any(x=> x.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(x=> x.Barkod == barkod).FirstOrDefault();
                        txtBarkodSonuc.Text = urun.Barkod;
                        txtUrunAdiSonuc.Text = urun.UrunAd;
                        // Güncel Fiyatlar
                        nudGuncelSatisFiyat.Value = (decimal)urun.SatisFiyat;
                        nudGuncelSatisFiyat.Maximum = (decimal)urun.SatisFiyat;
                        nudGuncelSatisFiyat.Minimum = (decimal)urun.SatisFiyat;
                        nudGuncelAlisFiyat.Value = (decimal)urun.AlisFiyat;
                        nudGuncelAlisFiyat.Maximum = (decimal)urun.AlisFiyat;
                        nudGuncelAlisFiyat.Minimum = (decimal)urun.AlisFiyat;
                        // Yeni Fiyatlar
                        nudYeniSatisFiyat.Value = (decimal)urun.SatisFiyat;
                        nudYeniAlisFiyat.Value = (decimal)urun.AlisFiyat;
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir barkod bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir barkod giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUrunuGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBarkodSonuc.Text))
            {
                string barkod = txtBarkodSonuc.Text;
                var urun = db.Urun.Where(x => x.Barkod == barkod).FirstOrDefault();
                urun.SatisFiyat = (double) nudYeniSatisFiyat.Value;
                urun.AlisFiyat = (double)nudYeniAlisFiyat.Value;
                urun.KdvTutari = Math.Round(Convert.ToDouble(nudYeniSatisFiyat.Value) * Convert.ToInt32(urun.KdvOrani) / 100, 2);
                db.SaveChanges();
                MessageBox.Show("Ürün fiyatı başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarkod.Text = string.Empty;
                txtBarkodSonuc.Text = string.Empty;
                txtUrunAdiSonuc.Text = string.Empty;
                nudGuncelSatisFiyat.Maximum = 99999999;
                nudGuncelAlisFiyat.Maximum = 99999999;
                nudGuncelSatisFiyat.Minimum = 0;
                nudGuncelAlisFiyat.Minimum = 0;
                nudGuncelSatisFiyat.Value = 0;
                nudGuncelAlisFiyat.Value = 0;
                nudYeniSatisFiyat.Value = 0;
                txtBarkod.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen bir barkod giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
