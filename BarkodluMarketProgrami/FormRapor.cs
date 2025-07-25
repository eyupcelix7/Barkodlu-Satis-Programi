﻿using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BarkodluMarketProgrami
{
    public partial class FormRapor : Form
    {
        bool basiliMi = false;
        int basiliRowIndex = 0, hitX = 0, hitY = 0;
        BarkodEntities db = new BarkodEntities();
        List<IslemOzet> tumKayitlar = new List<IslemOzet>();
        public FormRapor()
        {
            InitializeComponent();
        }
        private void FormRapor_Load(object sender, EventArgs e)
        {
            KartKomisyon kartKomisyon = new KartKomisyon();
            nudKartKomisyon.Value = (decimal) kartKomisyon.KartKomisyonHesapla();
            tumKayitlar = db.IslemOzet.ToList();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Cursor guncelCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangicTarihi = DateTime.Parse(dtpBaslangicTarihi.Value.ToShortDateString());
            DateTime bitisTarihi = DateTime.Parse(dtpBitisTarihi.Value.ToShortDateString()).AddDays(1);
            using(var db = new BarkodEntities())
            {
                if (rdbTumu.Checked)
                {
                    var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).OrderByDescending(a => a.Tarih).ToList();
                    var satisOzet = db.Satis.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).ToList();
                    tabloDoldur(islemOzet,satisOzet);
                }
                else if (rdbSatislar.Checked)
                {
                    var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == false && x.Gelir == false && x.Gider == false).OrderByDescending(a => a.Tarih).ToList();
                    var satisOzet = db.Satis.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).ToList();
                    tabloDoldur(islemOzet, satisOzet);
                }
                else if (rdbIadeler.Checked)
                {
                    var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == true && x.Gelir == false && x.Gider == false).OrderByDescending(a => a.Tarih).ToList();
                    var satisOzet = db.Satis.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).ToList();
                    tabloDoldur(islemOzet, satisOzet);
                }
                else if (rdbGelirler.Checked)
                {
                    var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == false && x.Gelir == true && x.Gider == false).OrderByDescending(a => a.Tarih).ToList();
                    tabloDoldur(islemOzet, null);
                }
                else if (rdbGiderler.Checked)
                {
                    var islemOzet = db.IslemOzet.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi && x.Iade == false && x.Gelir == false && x.Gider == true).OrderByDescending(a => a.Tarih).ToList();
                    tabloDoldur(islemOzet, null);
                }
            }
            Cursor.Current = guncelCursor;
        }
        private void tabloDoldur(List<IslemOzet> islemOzet, List<Satis> satisOzet)
        {
            if(satisOzet != null)
            {
                double satisKdvToplam = Convert.ToDouble(satisOzet.Where(x => x.Iade == false).Sum(x => x.KdvTutari));
                double iadeKdvToplam = Convert.ToDouble(satisOzet.Where(x => x.Iade == true).Sum(x => x.KdvTutari));
                nudKdvToplam.Value = (decimal)Convert.ToDouble(satisKdvToplam - iadeKdvToplam);
            }
            else 
            { 
                nudKdvToplam.Value = 0; 
            }
            nudSatisToplamNakit.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == false && x.Gider == false && x.Iade == false).Sum(x => x.Nakit));
            nudSatisToplamKart.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == false && x.Gider == false && x.Iade == false).Sum(x => x.Kart));
            nudSatislarToplam.Value = Convert.ToDecimal(nudSatisToplamNakit.Value) + Convert.ToDecimal(nudSatisToplamKart.Value);
            nudSatisSayisi.Value = islemOzet.Where(x => x.Gelir == false && x.Gider == false && x.Iade == false).Count();
            nudIadeToplamNakit.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == false && x.Gider == false && x.Iade == true).Sum(x => x.Nakit));
            nudIadeToplamKart.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == false && x.Gider == false && x.Iade == true).Sum(x => x.Kart));
            nudIadelerToplam.Value = Convert.ToDecimal(nudIadeToplamNakit.Value) + Convert.ToDecimal(nudIadeToplamKart.Value);
            nudIadeSayisi.Value = islemOzet.Where(x => x.Gelir == false && x.Gider == false && x.Iade == true).Count();
            nudGelirNakit.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == true && x.Gider == false && x.Iade == false).Sum(x => x.Nakit));
            nudGelirKart.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == true && x.Gider == false && x.Iade == false).Sum(x => x.Kart));
            nudGelirlerToplam.Value = Convert.ToDecimal(nudGelirNakit.Value) + Convert.ToDecimal(nudGelirKart.Value);
            nudGiderNakit.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == false && x.Gider == true && x.Iade == false).Sum(x => x.Nakit));
            nudGiderKart.Value = (decimal)Convert.ToDouble(islemOzet.Where(x => x.Gelir == false && x.Gider == true && x.Iade == false).Sum(x => x.Kart));
            nudGiderlerToplam.Value = Convert.ToDecimal(nudGiderNakit.Value) + Convert.ToDecimal(nudGiderKart.Value);
            gridSonucListesi.DataSource = islemOzet;
            tabloDuzenle();
            pnlIstatistik.Visible = true;
            if (islemOzet.Count == 0)
            {
                MessageBox.Show("Belirtilen tarihler arasında işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tabloDuzenle()
        {
            /* 
             * 0 - Id
             * 1 - Satış Numarası
             * 2 - İade
             * 3 - Ödeme Şekli
             * 4 - Nakit
             * 5 - Kart
             * 6 - Gelir
             * 7 - Gider
             * 8 - Alış Fiyat Toplam
             * 9 - Açıklama
             * 10 - Tarih
             * 11 - Kullanıcı
             */
            gridSonucListesi.Columns[0].Visible = false; // ID gizliyoruz
            gridSonucListesi.Columns[1].HeaderText = "Satış Numarası";
            gridSonucListesi.Columns[2].HeaderText = "İşlem";
            gridSonucListesi.Columns[3].HeaderText = "Ödeme Şekli";
            gridSonucListesi.Columns[4].DefaultCellStyle.Format = "C2";
            gridSonucListesi.Columns[5].DefaultCellStyle.Format = "C2";
            gridSonucListesi.Columns[6].Visible = false;
            gridSonucListesi.Columns[7].Visible = false;
            gridSonucListesi.Columns[8].HeaderText = "Alış Toplam";
            gridSonucListesi.Columns[8].DefaultCellStyle.Format = "C2";
            gridSonucListesi.Columns[9].HeaderText = "Açıklama";
            gridSonucListesi.Columns[11].HeaderText = "Kullanıcı";
        }
        private void gridSonucListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7) 
            {
                int id = (int)gridSonucListesi.Rows[e.RowIndex].Cells[0].Value;
                var kayit = tumKayitlar.FirstOrDefault(x => x.Id == id);
                bool iade = (bool)kayit.Iade;
                bool gelir = (bool)kayit.Gelir;
                bool gider = (bool)kayit.Gider;
                if (kayit != null)
                {
                    if (iade && !gelir && !gider)
                    {
                        e.Value = "İade";
                    }
                    else if (!iade && !gelir && !gider)
                    {
                        e.Value = "Satış";
                    }
                    else if (gelir && !iade && !gider)
                    {
                        e.Value = "Gelir";
                    }
                    else if (gider && !gelir && !iade)
                    {
                        e.Value = "Gider";
                    }
                }
            }
        }
        private void gridSonucListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string detay = gridSonucListesi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (detay == "False")
            {
                detay = "Hayır";
            }
            else if (detay == "True") 
            {
                detay = "Evet";
            }
            MessageBox.Show(detay);
        }
        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            FormGelirGiderEkle formGelirGiderEkle = new FormGelirGiderEkle();
            formGelirGiderEkle.gelir = true;
            formGelirGiderEkle.ShowDialog();
        }
        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            FormGelirGiderEkle formGelirGiderEkle = new FormGelirGiderEkle();
            formGelirGiderEkle.gelir = false;
            formGelirGiderEkle.ShowDialog();

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
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel(gridSonucListesi, "Genel Rapor");
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            Pdf pdf = new Pdf(gridSonucListesi, "Genel Rapor");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (basiliMi)
            {
                ContextMenuStrip st = new ContextMenuStrip();
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = "Detaylar";
                st.Items.Add(menuItem);
                menuItem.Click += detayGoster;
                this.ContextMenuStrip = st;
                st.Show(gridSonucListesi,new Point(hitX,hitY));
            }
        }
        private void detayGoster(object sender, EventArgs e)
        {
            int id = (int) gridSonucListesi.Rows[basiliRowIndex].Cells[0].Value;
            FormRaporDetay formRaporDetay = new FormRaporDetay();
            formRaporDetay.islemId = id;
            formRaporDetay.ShowDialog();
        }
    }
}
