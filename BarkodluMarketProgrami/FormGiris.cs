using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluMarketProgrami
{
    public partial class FormGiris : Form
    {
        public int kulKodu = 0;
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            using(var db = new BarkodEntities())
            {
                var kullanici = db.Kullanici.Where(x=> x.KullaniciKod == kulKodu).SingleOrDefault();
                btnSatis.Enabled = (bool)kullanici.Satis;
                btnGenelRapor.Enabled = (bool)kullanici.GenelRapor;
                btnStokTakibi.Enabled = (bool)kullanici.StokTakibi;
                btnUrunGiris.Enabled = (bool)kullanici.UrunGiris;
                btnFiyatGuncelle.Enabled = (bool)kullanici.FiyatGuncelle;
                btnAyarlar.Enabled = (bool)kullanici.Ayarlar;
                btnKullaniciAyarlari.Enabled = (bool)kullanici.KullaniciAyarlari;
                btnVeresiyeIslemleri.Enabled = (bool)kullanici.Veresiye;
                btnYedekleme.Enabled = (bool)kullanici.Yedekleme;
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            FormSatis form = new FormSatis();
            form.lblKullanici.Text = lblKullanici.Text;
            form.ShowDialog();
        }

        private void btnGenelRapor_Click(object sender, EventArgs e)
        {
            FormRapor form = new FormRapor();
            form.lblKullanici.Text = lblKullanici.Text;
            form.ShowDialog();
        }
        private void btnStokTakibi_Click(object sender, EventArgs e)
        {
            FormStokIzleme form = new FormStokIzleme();
            form.lblKullanici.Text = lblKullanici.Text;
            form.ShowDialog();
        }
        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            FormUrunGiris form = new FormUrunGiris();
            form.lblKullanici.Text = lblKullanici.Text;
            form.ShowDialog();

        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            FormFiyatGuncelle form = new FormFiyatGuncelle();
            form.lblKullanici.Text = lblKullanici.Text;
            form.ShowDialog();
        }

        private void btnKullaniciAyarlari_Click(object sender, EventArgs e)
        {
            FormKullaniciAyarlari form = new FormKullaniciAyarlari();
            form.lblKullanici.Text = lblKullanici.Text;
            form.ShowDialog();

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FormAyarlar form = new FormAyarlar();
            form.lblKullanici.Text = lblKullanici.Text;
            form.ShowDialog();

        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            new Yedekle();
        }

        private void btnYedekYükle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\BarkodluSatisProgramiRestore.exe");
            Application.Exit();
        }

    }
}
