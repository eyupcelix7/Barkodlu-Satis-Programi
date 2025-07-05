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
    public partial class FormVeresiyeAlVer : Form
    {
        public string veresiyeTur { get; set; } // Al - Ver
        BarkodEntities db = new BarkodEntities();
        public FormVeresiyeAlVer()
        {
            InitializeComponent();
        }
        private void FormVeresiyeAlVer_Load(object sender, EventArgs e)
        {
            if (veresiyeTur == "ver")
            {
                this.Text = "Veresiye Ver";
            }
            else
            {
                this.Text = "Veresiye Al";
            }
        }
        private void btnNumClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "<")
            {
                txtNumarator.Text = txtNumarator.Text.Substring(0, txtNumarator.Text.Length - 1);
            }
            else if (btn.Text == ",")
            {
                if (txtNumarator.Text.Length > 0)
                {
                    txtNumarator.Text += btn.Text;
                }
            }
            else
            {
                txtNumarator.Text += btn.Text;
            }
        }
        private void txtKisiAra_TextChanged(object sender, EventArgs e)
        {
            if (txtKisiAra.Text.Length > 1)
            {
               var kisiler = db.VeresiyeKullanicilar.Where(x => x.AdSoyad.Contains(txtKisiAra.Text)).Select(x => new
                {
                    x.AdSoyad,
                    x.Id
                }).ToList();
                if(kisiler.Count > 0)
                {
                    cbxKisiler.DataSource = kisiler;
                    cbxKisiler.DisplayMember = "AdSoyad";
                    cbxKisiler.ValueMember = "Id";
                }
                else
                {
                    cbxKisiler.DataSource = null;
                }
            }
            else
            {
                if(txtKisiAra.Text == "")
                {
                    cbxKisiler.DataSource = null;
                    pnlSecilenKisi.Visible = false;
                }
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtNumarator.Text != "" && cbxKisiler.Text != "")
            {
                double borcTutar = Convert.ToDouble(txtNumarator.Text);
                if(veresiyeTur == "ver")
                {
                    DialogResult dR = MessageBox.Show("**Veresiye İşlemi**\n\n" + cbxKisiler.Text + " İsimli Kişiye\n" + borcTutar.ToString("C2") + " Lira Tutarında Veresiye Yazılma İşlemini Onaylıyor Musunuz?", "Veresiye İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dR == DialogResult.OK)
                    {
                        Veresiye vK = new Veresiye();
                        vK.IslemNo = null;
                        vK.Tutar = Convert.ToDouble(txtNumarator.Text);
                        vK.KullaniciId = (int)cbxKisiler.SelectedValue;
                        vK.Odeme = false;
                        vK.AlinmaTarih = null;
                        vK.AlinmaTarih = DateTime.Now;
                        vK.Kullanici = lblKullanici.Text;
                        db.Veresiye.Add(vK);
                        db.SaveChanges();
                        MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kişi Seçip, Bir Tutar Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbxKisiler_TextChanged(object sender, EventArgs e)
        {
            pnlSecilenKisi.Visible = true;
            lblSecilenKisiDeger.Text = cbxKisiler.Text;
        }
        private void lblSecilenKisiDeger_Click(object sender, EventArgs e)
        {
            if(lblSecilenKisiDeger.Text != "")
            {
                var detaylar = db.VeresiyeKullanicilar.Where(x => x.Id == (int)cbxKisiler.SelectedValue).SingleOrDefault();
                var borclar = db.Veresiye.Where(x => x.KullaniciId == (int)cbxKisiler.SelectedValue).OrderByDescending(x=> x.AlinmaTarih).ToList();
                string telefonNo = detaylar.Telefon;
                string aciklama = detaylar.Aciklama;
                double guncelBorcTutar = 0.00;
                string odenmemisBorcTarihleri = string.Empty;
                if(veresiyeTur == "ver")
                {
                    foreach (var borc in borclar)
                    {
                        if (!(bool)borc.Odeme)
                        {
                            double borcu = Convert.ToDouble(borc.Tutar);
                            guncelBorcTutar += borcu;
                            odenmemisBorcTarihleri += "\n" + borc.AlinmaTarih.ToString() + " - " + borcu.ToString("C2");
                        }
                    }
                    MessageBox.Show(cbxKisiler.Text + ", Detayları :\n\n" + "Telefon Numarası: " + telefonNo + "\n\nAçıklama: \n" + aciklama + "\n\nGüncel Borcu: \n" + guncelBorcTutar.ToString("C2") + "\n\nÖdenmemiş Borçların Alınma Tarihleri: \n" + odenmemisBorcTarihleri, cbxKisiler.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            FormVeresiyeYeniKullanici fVYK = new FormVeresiyeYeniKullanici();
            fVYK.ShowDialog();
        }
        private void Temizle()
        {
            pnlSecilenKisi.Visible = false;
            txtKisiAra.Text = string.Empty;
            cbxKisiler.DataSource = null;
            txtNumarator.Text = string.Empty;
        }
    }
}
