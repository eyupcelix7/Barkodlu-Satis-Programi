﻿using DocumentFormat.OpenXml.Bibliography;
using iTextSharp.text;
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
    public partial class FormKullaniciAyarlari : Form
    {
        public FormKullaniciAyarlari()
        {
            InitializeComponent();
        }
        BarkodEntities db = new BarkodEntities();
        Random rastgele = new Random();
        bool basiliMi = false;
        int basiliRowIndex = 0, hitX = 0, hitY = 0;
        private void FormKullaniciAyarlari_Load(object sender, EventArgs e)
        {
            tabloDoldur();
            txtAdSoyad.Focus();
        }
        private void tabloDoldur(int kullaniciKod = 0)
        {
            var kullanicilar = db.Kullanici.Select(
            x => new
            {
                x.Id,
                x.AdSoyad,
                x.Telefon,
                x.KullaniciKod,
                x.Sifre,
                x.Satis,
                x.GenelRapor,
                x.StokTakibi,
                x.UrunGiris,
                x.FiyatGuncelle,
                x.Veresiye,
                x.Ayarlar,
                x.Yedekleme,
                x.KullaniciAyarlari
            }).ToList();

            gridSonucListesi.DataSource = kullanicilar;
            gridSonucListesi.Columns[0].Visible = false;
            gridSonucListesi.Columns["KullaniciKod"].HeaderText = "Kullanıcı Kodu";
            gridSonucListesi.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            gridSonucListesi.Columns["Sifre"].HeaderText = "Şifre";
            gridSonucListesi.Columns["Satis"].HeaderText = "Satış";
            gridSonucListesi.Columns["GenelRapor"].HeaderText = "Raporlama";
            gridSonucListesi.Columns["StokTakibi"].HeaderText = "Stok Takibi";
            gridSonucListesi.Columns["UrunGiris"].HeaderText = "Ürün Giriş";
            gridSonucListesi.Columns["FiyatGuncelle"].HeaderText = "Fiyat Güncelleme";
            gridSonucListesi.Columns["Veresiye"].HeaderText = "Veresiye İşlemleri";
            gridSonucListesi.Columns["KullaniciAyarlari"].HeaderText = "Kullanıcı Ayarları";
        }
        private void gridSonucListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "Evet";
                }
                else if (e.Value.ToString() == "False")
                {
                    e.Value = "Hayır";
                }
                else if (gridSonucListesi.Columns[e.ColumnIndex].HeaderText == "Şifre")
                {
                    e.Value = "*******";
                }
            }
        }
        private void rastgeleKullaniciKodu()
        {
            txtKullaniciKodu.Text = rastgele.Next(100, 999).ToString();
        }
        private void Temizle()
        {
            txtAdSoyad.Text = string.Empty;
            txtTelNo.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSifreTkr.Text = string.Empty;
            cbxSatis.Checked = false;
            cbxAyarlar.Checked = false;
            cbxGenelRapor.Checked = false;
            cbxStokTakibi.Checked = false;
            cbxKullaniciAyarlari.Checked = false;
            cbxUrunGiris.Checked = false;
            cbxUrunGuncelle.Checked = false;
            cbxVeresiye.Checked = false;
            cbxYedekleme.Checked = false;
            rastgeleKullaniciKodu();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciKodu.Text) && !string.IsNullOrEmpty(txtAdSoyad.Text) && !string.IsNullOrEmpty(txtSifre.Text) && !string.IsNullOrEmpty(txtSifreTkr.Text))
            {
                if(txtSifreTkr.Text.Trim() == txtSifre.Text.Trim())
                {
                    int kKod = Convert.ToInt16(txtKullaniciKodu.Text.Trim());
                    if (db.Kullanici.Where(x => x.KullaniciKod == kKod).Any())
                    {
                        var kullanici = db.Kullanici.Where(x => x.KullaniciKod == kKod).FirstOrDefault();
                        kullanici.AdSoyad = txtAdSoyad.Text.Trim();
                        kullanici.Telefon = txtTelNo.Text.Trim();
                        kullanici.KullaniciKod = Convert.ToInt16(txtKullaniciKodu.Text);
                        kullanici.Sifre = txtSifre.Text.Trim();
                        kullanici.Satis = cbxSatis.Checked;
                        kullanici.GenelRapor = cbxGenelRapor.Checked;
                        kullanici.StokTakibi = cbxStokTakibi.Checked;
                        kullanici.UrunGiris = cbxUrunGiris.Checked;
                        kullanici.FiyatGuncelle = cbxUrunGuncelle.Checked;
                        kullanici.Veresiye = cbxVeresiye.Checked;
                        kullanici.Ayarlar = cbxAyarlar.Checked;
                        kullanici.Yedekleme = cbxYedekleme.Checked;
                        kullanici.KullaniciAyarlari = cbxKullaniciAyarlari.Checked;
                        kullanici.Tarih = DateTime.Now;
                        db.SaveChanges();
                    }
                    else
                    {
                        Kullanici kullanici = new Kullanici();
                        kullanici.AdSoyad = txtAdSoyad.Text.Trim();
                        kullanici.Telefon = txtTelNo.Text.Trim();
                        kullanici.KullaniciKod = Convert.ToInt16(txtKullaniciKodu.Text.Trim());
                        kullanici.Sifre = txtSifre.Text.Trim();
                        kullanici.Satis = cbxSatis.Checked;
                        kullanici.GenelRapor = cbxGenelRapor.Checked;
                        kullanici.StokTakibi = cbxStokTakibi.Checked;
                        kullanici.UrunGiris = cbxUrunGiris.Checked;
                        kullanici.FiyatGuncelle = cbxUrunGuncelle.Checked;
                        kullanici.Veresiye = cbxVeresiye.Checked;
                        kullanici.Ayarlar = cbxAyarlar.Checked;
                        kullanici.Yedekleme = cbxYedekleme.Checked;
                        kullanici.KullaniciAyarlari = cbxAyarlar.Checked;
                        kullanici.Tarih = DateTime.Now;
                        db.Kullanici.Add(kullanici);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Kullanıcı başarı ile kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabloDoldur();
                    Temizle();

                }
                else
                {
                    MessageBox.Show("Şifreler birbiri ile uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridSonucListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kKod = Convert.ToInt16(gridSonucListesi.Rows[e.RowIndex].Cells[3].Value);
            if (db.Kullanici.Where(x => x.KullaniciKod == kKod).Any()) 
            { 
                var kullanici = db.Kullanici.Where(x => x.KullaniciKod == kKod).FirstOrDefault();
                txtKullaniciKodu.Text = kullanici.KullaniciKod.ToString();
                txtAdSoyad.Text = kullanici.AdSoyad;
                txtTelNo.Text = kullanici.Telefon;
                txtSifre.Text = kullanici.Sifre;
                txtSifreTkr.Text = kullanici.Sifre;
                cbxSatis.Checked = kullanici.Satis ?? false;
                cbxGenelRapor.Checked = kullanici.GenelRapor ?? false;
                cbxStokTakibi.Checked = kullanici.StokTakibi ?? false;
                cbxUrunGiris.Checked = kullanici.UrunGiris ?? false;
                cbxUrunGuncelle.Checked = kullanici.FiyatGuncelle ?? false;
                cbxVeresiye.Checked = kullanici.Veresiye ?? false;
                cbxAyarlar.Checked = kullanici.Ayarlar ?? false;
                cbxYedekleme.Checked = kullanici.Yedekleme ?? false;
                cbxKullaniciAyarlari.Checked = kullanici.KullaniciAyarlari ?? false;
            }
        }
        private void btnKullaniciKodOlustur_Click(object sender, EventArgs e)
        {
            rastgeleKullaniciKodu();
        }
        private void gridSonucListesi_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = gridSonucListesi.HitTest(e.X, e.Y);
            hitX = e.X;
            hitY = e.Y;
            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
            {
                basiliMi = true;
                timer1.Start();
                basiliRowIndex = hit.RowIndex;
            }
        }
        private void gridSonucListesi_MouseUp(object sender, MouseEventArgs e)
        {
            var hit = gridSonucListesi.HitTest(e.X, e.Y);
            hitX = e.X;
            hitY = e.Y;
            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
            {
                basiliMi = false;
                timer1.Stop();
                basiliRowIndex = hit.RowIndex;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (basiliMi)
            {
                ContextMenuStrip st = new ContextMenuStrip();
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = "Kullanıcıyı Sil";
                st.Items.Add(menuItem);
                menuItem.Click += Sil;
                this.ContextMenuStrip = st;
                st.Show(gridSonucListesi, new Point(hitX, hitY));
            }
        }
        private void Sil(object sender, EventArgs e)
        {
            int id = (int)gridSonucListesi.Rows[basiliRowIndex].Cells[0].Value;
            if(db.Kullanici.Where(x=> x.Id == id).Any())
            {
                var kullanici = db.Kullanici.Where(x => x.Id == id).SingleOrDefault();
                db.Kullanici.Remove(kullanici);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                tabloDoldur();
            }
        }
    }
}
