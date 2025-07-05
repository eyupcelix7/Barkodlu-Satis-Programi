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
    public partial class FormVeresiyeYeniKullanici : Form
    {
        public FormVeresiyeYeniKullanici()
        {
            InitializeComponent();
        }
        private void FormVeresiyeYeniKullanici_Load(object sender, EventArgs e)
        {
            kayitliKullanicilariGetir();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAdSoyad.Text != "")
            {
                string adSoyad = txtAdSoyad.Text.Trim();
                string telNo = txtTelNo.Text.Trim();
                string aciklama = rtbAciklama.Text.Trim();
                using(var db = new BarkodEntities())
                {
                    if(telNo != "")
                    {
                        if(db.VeresiyeKullanicilar.Where(x => x.Telefon != telNo).Any())
                        {
                            VeresiyeKullanicilar vK = new VeresiyeKullanicilar();
                            vK.AdSoyad = adSoyad;
                            vK.Telefon = telNo;
                            vK.Aciklama = aciklama;
                            db.VeresiyeKullanicilar.Add(vK);
                            db.SaveChanges();
                            MessageBox.Show("Kayıt Başarıyla Oluşturuldu\nAd Soyad: "+adSoyad+"\nTelefon Numarası: "+telNo+"\nAçıklama: "+aciklama, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Bu Telefon Numarası Ile Daha Önce Kayıt Yapılmış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        VeresiyeKullanicilar vK = new VeresiyeKullanicilar();
                        vK.AdSoyad = adSoyad;
                        vK.Telefon = telNo;
                        vK.Aciklama = aciklama;
                        db.VeresiyeKullanicilar.Add(vK);
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Başarıyla Oluşturuldu\n\nAd Soyad: " + adSoyad + "\nTelefon Numarası: " + telNo + "\nAçıklama: " + aciklama, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }

                }
            }
        }
        private void Temizle()
        {
            txtAdSoyad.Text = string.Empty;
            txtTelNo.Text = string.Empty;
            rtbAciklama.Text = string.Empty;
            kayitliKullanicilariGetir();
        }
        private void kayitliKullanicilariGetir()
        {
            using (var db = new BarkodEntities())
            {
                var kayitliKullanicilar = db.VeresiyeKullanicilar.Select(x => x.AdSoyad).ToList();
                cbxKayitliListesi.DataSource = kayitliKullanicilar;
            }
        }
    }
}
