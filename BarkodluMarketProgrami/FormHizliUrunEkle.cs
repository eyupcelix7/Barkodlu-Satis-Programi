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
        bool eklendiMi = false;
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
                if (urunler != null)
                {
                    foreach (var urun in urunler)
                    {
                        if (!string.IsNullOrEmpty(urun.Barkod.ToString()))
                        {
                            bool barkodZatenVar = false;
                            foreach (DataGridViewRow row in gridUrunListesi.Rows)
                            {
                                if (row.Cells["urunBarkod"].Value.ToString() == urun.Barkod.ToString())
                                {
                                    barkodZatenVar = true;
                                    break;
                                }
                            }
                            if (!barkodZatenVar)
                            {
                                int yeniSatir = gridUrunListesi.Rows.Add();
                                gridUrunListesi.Rows[yeniSatir].Cells["urunBarkod"].Value = urun.Barkod;
                                gridUrunListesi.Rows[yeniSatir].Cells["urunAdi"].Value = urun.UrunAd;
                                gridUrunListesi.Rows[yeniSatir].Cells["urunBirim"].Value = urun.Birim;
                                gridUrunListesi.Rows[yeniSatir].Cells["urunMiktar"].Value = urun.Miktar.ToString();
                                gridUrunListesi.Rows[yeniSatir].Cells["urunFiyat"].Value = Convert.ToDouble(urun.SatisFiyat).ToString("C2");
                            }
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
                eklendiMi = false;
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
