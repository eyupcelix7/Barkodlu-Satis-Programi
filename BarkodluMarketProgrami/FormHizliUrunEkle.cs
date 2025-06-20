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
            if(txtUrunAd.Text.Length > 2)
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
                int btnId = 0;
                if (gelenButtonKategoriID == 1)
                {
                    btnId = gelenButtonID;
                }
                if (gelenButtonKategoriID == 2)
                {
                    btnId = gelenButtonID + 25;
                }
                if (gelenButtonKategoriID == 3)
                {
                    btnId = gelenButtonID + 50;
                }
                if (gelenButtonKategoriID == 4)
                {
                    btnId = gelenButtonID + 75;
                }
                if (gelenButtonKategoriID == 5)
                {
                    btnId = gelenButtonID + 100;
                }
                var urunBul = db.HizliUrun.SingleOrDefault(a => a.Id == btnId && a.HizliKategoriID == gelenButtonKategoriID);
                urunBul.Barkod = urunBarkod;
                urunBul.UrunAd = urunAd;
                urunBul.Fiyat = urunFiyat;
                db.SaveChanges();
                MessageBox.Show("Hızlı ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormSatis formSatis = (FormSatis)Application.OpenForms["FormSatis"];
                if (formSatis != null)
                {
                    Button btn = (Button)formSatis.Controls.Find("btnHizli" + gelenButtonID, true).FirstOrDefault();
                    btn.Text = urunAd + "\n" + urunFiyat.ToString("C2");
                }
            }
        }
    }
}
