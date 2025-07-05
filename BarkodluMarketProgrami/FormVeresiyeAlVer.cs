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
        // ** Satış Formu İçin **
        double _toplamTutar = 0.0;
        private FormSatis _formSatis;
        bool satis = false;
        public FormVeresiyeAlVer(double toplamTutar = 0.0, FormSatis form = null)
        {
            InitializeComponent();
            if(form != null)
            {
                _toplamTutar = toplamTutar;
                _formSatis = form;
                satis = true;
                txtNumarator.Text = _toplamTutar.ToString();
            }
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
            if (txtNumarator.Text != "" && cbxKisiler.Text != "")
            {
                double borcTutar = Convert.ToDouble(txtNumarator.Text);
                if (veresiyeTur == "ver")
                {
                    DialogResult dR = MessageBox.Show("**Veresiye İşlemi**\n\n" + cbxKisiler.Text + " İsimli Kişiye\n" + borcTutar.ToString("C2") + " Lira Tutarında Veresiye Yazılma İşlemini Onaylıyor Musunuz?", "Veresiye İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dR == DialogResult.OK)
                    {
                        Veresiye vK = new Veresiye();
                        if (satis) { vK.IslemNo = db.Islem.Single().IslemNo; } else { vK.IslemNo = null; }
                        vK.Tutar = Convert.ToDouble(txtNumarator.Text);
                        vK.KullaniciId = (int)cbxKisiler.SelectedValue;
                        vK.Odeme = false;
                        vK.Tarih = DateTime.Now;
                        vK.Kullanici = lblKullanici.Text;
                        db.Veresiye.Add(vK);
                        db.SaveChanges();
                        if (satis)
                        {
                            _formSatis.veresiyeTutar = Convert.ToDouble(txtNumarator.Text);
                            _formSatis.satisYap("Veresiye");
                            this.Close();
                        }
                        else{ MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        Temizle();
                    }
                }
                else if (veresiyeTur == "al")
                {
                    var guncelBorc = db.Veresiye.Where(x => x.KullaniciId == (int)cbxKisiler.SelectedValue && x.Odeme == false).Sum(x => x.Tutar);
                    var odenmisTutar = db.Veresiye.Where(x => x.KullaniciId == (int)cbxKisiler.SelectedValue && x.Odeme == true).Sum(x => x.Tutar);
                    if (guncelBorc == null) { guncelBorc = 0.0; }
                    if (odenmisTutar == null) { odenmisTutar = 0.0; }
                    double borcT = (double)guncelBorc - (double)odenmisTutar;

                    if (borcT < Convert.ToDouble(txtNumarator.Text))
                    {
                        MessageBox.Show("Girilen Ödeme Tutarı Kadar Borç Bulunmuyor !!\nGüncel Borç: "+ borcT, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult dR = MessageBox.Show("**Veresiye Ödeme İşlemi**\n\n" + cbxKisiler.Text + " İsimli Kişinin\n" + borcTutar.ToString("C2") + " Lira Tutarında Veresiye Ödeme İşlemini Onaylıyor Musunuz?", "Veresiye Ödeme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dR == DialogResult.OK)
                        {
                            Veresiye vK = new Veresiye();
                            vK.IslemNo = null;
                            vK.Tutar = Convert.ToDouble(txtNumarator.Text);
                            vK.KullaniciId = (int)cbxKisiler.SelectedValue;
                            vK.Odeme = true;
                            vK.Tarih = DateTime.Now;
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
                var borcTutar = db.Veresiye.Where(x => x.KullaniciId == (int)cbxKisiler.SelectedValue && x.Odeme == false).Sum(x=>x.Tutar);
                var odenmisTutar = db.Veresiye.Where(x => x.KullaniciId == (int)cbxKisiler.SelectedValue && x.Odeme == true).Sum(x => x.Tutar);
                if(odenmisTutar == null) { odenmisTutar = 0.0; }
                if(borcTutar == null) { borcTutar = 0.0; }
                double guncelBorc = (double)borcTutar - (double)odenmisTutar;
                string telefonNo = detaylar.Telefon;
                string aciklama = detaylar.Aciklama;
                MessageBox.Show(cbxKisiler.Text + ", Detayları :\n\n" + "Telefon Numarası: " + telefonNo + "\n\nAçıklama: \n" + aciklama + "\n\nGüncel Borcu: \n" + guncelBorc.ToString("C2"), cbxKisiler.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
