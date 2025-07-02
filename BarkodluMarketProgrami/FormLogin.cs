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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtKulKod.Text != "" && txtSifre.Text != "")
            {
                using (var db = new BarkodEntities())
                {
                    try
                    {
                        int kulKodu = Convert.ToInt16(txtKulKod.Text);
                        string sifre = txtSifre.Text;
                        if (db.Kullanici.Where(x=> x.KullaniciKod == kulKodu && x.Sifre == sifre).Any())
                        {
                            string adSoyad = db.Kullanici.Where(x => x.KullaniciKod == kulKodu).SingleOrDefault().AdSoyad;
                            FormGiris form = new FormGiris();
                            form.lblKullanici.Text = adSoyad;
                            form.kulKodu = kulKodu;
                            MessageBox.Show("Hoşgeldiniz, "+adSoyad, "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı Giriş", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: "+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
