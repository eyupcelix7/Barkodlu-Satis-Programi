using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BarkodluMarketProgrami
{
    public partial class FormHizliUrunEkle : Form
    {
        public int gelenButtonID = 0;
        public int gelenButtonKategoriID = 0;
        BarkodEntities db = new BarkodEntities();
        public FormHizliUrunEkle()
        {
            InitializeComponent();
        }
        private void FormHizliUrunEkle_Load(object sender, EventArgs e)
        {
        }

        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (txtUrunAd.Text.Length > 2)
            {
                var urunler = db.Urun.Where(a=> a.UrunAd.Contains(txtUrunAd.Text)).ToList();
                int satirSayisi = gridUrunListesi.Rows.Count;
                bool eklendiMi = false;
                int i = 0;
                if (urunler != null)
                {
                    foreach (var urun in urunler)
                    {
                        if(satirSayisi > 0)
                        {
                            if (gridUrunListesi.Rows[i].Cells["urunBarkod"].Value.ToString() == urun.Barkod.ToString())
                            {
                                eklendiMi = true;
                            }
                        }
                        if (eklendiMi == false)
                        {
                            string barkod = urun.Barkod;
                            string urunAd = urun.UrunAd;
                            string birim = urun.Birim;
                            double miktar = (double)urun.Miktar;
                            double fiyat = (double)urun.SatisFiyat;
                            gridUrunListesi.Rows.Add();
                            gridUrunListesi.Rows[satirSayisi].Cells["urunBarkod"].Value = barkod;
                            gridUrunListesi.Rows[satirSayisi].Cells["urunAdi"].Value = urunAd;
                            gridUrunListesi.Rows[satirSayisi].Cells["urunBirim"].Value = birim;
                            gridUrunListesi.Rows[satirSayisi].Cells["urunMiktar"].Value = miktar.ToString();
                            gridUrunListesi.Rows[satirSayisi].Cells["urunFiyat"].Value = fiyat.ToString("C2");
                        }
                    }
                }
            }
        }
        private void gridUrunListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridUrunListesi.Rows.Count > 0)
            {
                string urunBarkod = gridUrunListesi.Rows[e.RowIndex].Cells["urunBarkod"].Value.ToString();
                string urunAd = gridUrunListesi.Rows[e.RowIndex].Cells["urunAdi"].Value.ToString();
                double urunFiyat = Convert.ToDouble(gridUrunListesi.Rows[e.RowIndex].Cells["urunFiyat"].Value.ToString().Replace("₺", "").Trim());
                FormSatis formSatis = (FormSatis)Application.OpenForms["FormSatis"];
                int btnId = formSatis.hizliUrunID(gelenButtonKategoriID, gelenButtonID);
                var urunBul = db.HizliUrun.SingleOrDefault(a => a.Id == btnId && a.HizliKategoriID == gelenButtonKategoriID);
                urunBul.Barkod = urunBarkod;
                urunBul.UrunAd = urunAd;
                urunBul.Fiyat = urunFiyat;
                db.SaveChanges();
                MessageBox.Show("Hızlı ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (formSatis != null)
                {
                    Button btn = (Button)formSatis.Controls.Find("btnHizli" + gelenButtonID, true).FirstOrDefault();
                    btn.Text = urunAd + "\n" + urunFiyat.ToString("C2");
                    this.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUrunAd.Text = "";
                var urunler = db.Urun.ToList();
                int i = 0;
                if (urunler != null)
                {
                    foreach (var urun in urunler)
                    {
                        string barkod = urun.Barkod;
                        string urunAd = urun.UrunAd;
                        string birim = urun.Birim;
                        double miktar = (double)urun.Miktar;
                        double fiyat = (double)urun.SatisFiyat;
                        gridUrunListesi.Rows.Add();
                        gridUrunListesi.Rows[i].Cells["urunBarkod"].Value = barkod;
                        gridUrunListesi.Rows[i].Cells["urunAdi"].Value = urunAd;
                        gridUrunListesi.Rows[i].Cells["urunBirim"].Value = birim;
                        gridUrunListesi.Rows[i].Cells["urunMiktar"].Value = miktar.ToString();
                        gridUrunListesi.Rows[i].Cells["urunFiyat"].Value = fiyat.ToString("C2");
                        i++;
                    }
                }
            }
            else
            {
                gridUrunListesi.Rows.Clear();
            }
        }
    }
}
