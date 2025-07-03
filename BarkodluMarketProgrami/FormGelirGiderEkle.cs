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
    public partial class FormGelirGiderEkle : Form
    {
        public FormGelirGiderEkle()
        {
            InitializeComponent();
        }
        public bool gelir { get; set; }
        BarkodEntities db = new BarkodEntities();
        private void FormGelirGiderEkle_Load(object sender, EventArgs e)
        {
            if (gelir)
            {
                this.Text = "Gelir Ekle";
                lblGelirGider.Text = "Gelir Ekle";
            }
            else if(!gelir)
            {
                this.Text = "Gider Ekle";
                lblGelirGider.Text = "Gider Ekle";
            }
            nudKart.Enabled = false;
            nudNakit.Enabled = false;
        }
        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.SelectedIndex == 0) // Nakit
            {
                nudNakit.Enabled = true;
                nudKart.Enabled = false;
            }
            else if(cmbOdemeTuru.SelectedIndex == 1) // Kart
            {
                nudNakit.Enabled = false;
                nudKart.Enabled = true;
            }
            else if(cmbOdemeTuru.SelectedIndex == 2)
            {
                nudNakit.Enabled = true;
                nudKart.Enabled = true;
            }
            else
            {
                nudKart.Enabled = false;
                nudNakit.Enabled = false;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbOdemeTuru.SelectedIndex != -1)
            {
                int? islemNo = db.Islem.First().IslemNo;
                IslemOzet islemOzet = new IslemOzet();
                islemOzet.IslemNo = islemNo;
                islemOzet.Iade = false;
                islemOzet.OdemeSekli = cmbOdemeTuru.Text.Trim();
                islemOzet.Nakit = (double) nudNakit.Value;
                islemOzet.Kart = (double) nudKart.Value;
                islemOzet.Gelir = gelir;
                islemOzet.Gider = !gelir; // Gelir değişkeninin tam tersi yani gider ise otomatik false olacak gider
                islemOzet.AlisFiyatToplam = 0;
                islemOzet.Aciklama = rtbAciklama.Text.Trim();
                islemOzet.Tarih = dtpTarih.Value;
                islemOzet.Kullanici = lblKasiyer.Text.Trim();
                db.IslemOzet.Add(islemOzet);
                db.Islem.SingleOrDefault().IslemNo = islemNo+1;
                db.SaveChanges();
                switch (gelir) 
                {
                    case true:
                        MessageBox.Show("Gelir Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case false:
                        MessageBox.Show("Gider Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ödeme Türü Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Temizle()
        {
            cmbOdemeTuru.SelectedIndex = -1;
            nudNakit.Enabled = false;
            nudNakit.Value = 0;
            nudKart.Enabled = false;
            nudKart.Value = 0;
            rtbAciklama.Text = String.Empty;
            dtpTarih.Value = DateTime.Now;
        }
    }
}
