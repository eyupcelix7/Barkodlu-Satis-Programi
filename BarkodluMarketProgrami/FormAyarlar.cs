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
    public partial class FormAyarlar : Form
    {
        BarkodEntities db = new BarkodEntities();
        public FormAyarlar()
        {
            InitializeComponent();
        }
        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            Ayardoldur();
        }
        private void Ayardoldur()
        {
            var ayarlar = db.Ayarlar.SingleOrDefault();
            if (ayarlar != null)
            { 
                txtAdSoyad.Text = ayarlar.AdSoyad.ToString();
                txtAdres.Text = ayarlar.Adres.ToString();
                txtTelNo.Text = ayarlar.Telefon.ToString();
                nudKartKomisyon.Value = (decimal) ayarlar.KartKomisyon;
                cbxYazici.Checked = (bool)ayarlar.Yazici;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ayarlar = db.Ayarlar.SingleOrDefault();
            if(ayarlar != null)
            {
                ayarlar.AdSoyad = txtAdSoyad.Text.Trim();
                ayarlar.Adres = txtAdres.Text.Trim();
                ayarlar.Telefon = txtTelNo.Text.Trim();
                ayarlar.KartKomisyon = (double) nudKartKomisyon.Value;
                ayarlar.Yazici = cbxYazici.Checked;
                db.SaveChanges();
                MessageBox.Show("Ayarlar Başarı İle Kaydedildi","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
