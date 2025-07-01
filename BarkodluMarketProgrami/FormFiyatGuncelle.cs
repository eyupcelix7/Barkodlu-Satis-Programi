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
                        nudGuncelFiyatSonuc.Value = (decimal)urun.SatisFiyat;
                        nudGuncelFiyatSonuc.Maximum = (decimal)urun.SatisFiyat;
                        nudGuncelFiyatSonuc.Minimum = (decimal)urun.SatisFiyat;
                        nudYeniFiyatSonuc.Value = (decimal)urun.SatisFiyat;
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
                urun.SatisFiyat = (double) nudYeniFiyatSonuc.Value;
                db.SaveChanges();
                MessageBox.Show("Ürün fiyatı başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarkod.Text = string.Empty;
                txtBarkodSonuc.Text = string.Empty;
                txtUrunAdiSonuc.Text = string.Empty;
                nudGuncelFiyatSonuc.Maximum = 99999999;
                nudGuncelFiyatSonuc.Minimum = 0;
                nudGuncelFiyatSonuc.Value = 0;
                nudYeniFiyatSonuc.Value = 0;
            }
            else
            {
                MessageBox.Show("Lütfen bir barkod giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
