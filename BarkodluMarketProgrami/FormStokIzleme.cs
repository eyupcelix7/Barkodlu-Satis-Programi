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
    public partial class FormStokIzleme : Form
    {
        BarkodEntities db = new BarkodEntities();
        DateTime baslangicTarihi = DateTime.Now;
        DateTime bitisTarihi = DateTime.Now;
        public FormStokIzleme()
        {
            InitializeComponent();
        }
        private void FormStokIzleme_Load(object sender, EventArgs e)
        {
            UrunGrubuDoldur();
        }
        private void UrunGrubuDoldur()
        {
            cmbUrunGrubu.DisplayMember = "GrupAdi";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = db.UrunGrubu.OrderBy(a => a.GrupAdi).ToList();
            cmbUrunGrubu.SelectedIndex = -1; // İlk başta seçili olmasın
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if(cmbIslemTuru.SelectedIndex != -1)
            {
                if(dtpBaslangicTarihi.Enabled == false && dtpBitisTarihi.Enabled == false)
                {
                    baslangicTarihi = DateTime.Parse(dtpBaslangicTarihi.MinDate.ToShortDateString());
                    bitisTarihi = DateTime.Parse(dtpBaslangicTarihi.MaxDate.ToShortDateString());
                }
                else
                {
                    baslangicTarihi = DateTime.Parse(dtpBaslangicTarihi.Value.ToShortDateString());
                    bitisTarihi = DateTime.Parse(dtpBitisTarihi.Value.ToShortDateString()).AddDays(1);
                }
                if (cmbIslemTuru.SelectedIndex == 0)
                {
                    if (rdbTumu.Checked)
                    {
                        var urunler = db.Urun.Where(x => x.Miktar > 0 && x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).OrderByDescending(x => x.Tarih).Select(x=> new
                        {
                            x.Id,
                            x.Barkod,
                            x.UrunAd,
                            x.UrunGrup,
                            x.Birim,
                            x.Miktar,
                            x.KdvOrani,
                            x.KdvTutari,
                            x.AlisFiyat,
                            x.SatisFiyat,
                            x.Tarih,
                            x.Kullanici
                        }).ToList();

                        if (urunler.Count > 0)
                        {
                            gridSonucListesi.DataSource = urunler;
                            bulunanSayisiniDegistir(urunler.Count);
                            urunTabloDuzenle();
                        }
                        else{ MessageBox.Show("Seçilen Tarihler Arasında Bir Stok Durumu Bulunamamıştır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                    }
                    else
                    {
                        if (cmbUrunGrubu.SelectedIndex != -1)
                        {
                            var urunler = db.Urun.Where(a => a.UrunGrup == cmbUrunGrubu.Text && a.Tarih >= baslangicTarihi && a.Tarih <= bitisTarihi).OrderByDescending(x => x.Tarih).Select(x => new
                            {
                                x.Id,
                                x.Barkod,
                                x.UrunAd,
                                x.UrunGrup,
                                x.Birim,
                                x.Miktar,
                                x.KdvOrani,
                                x.KdvTutari,
                                x.AlisFiyat,
                                x.SatisFiyat,
                                x.Tarih,
                                x.Kullanici
                            }).ToList();
                            if (urunler.Count > 0)
                            {
                                gridSonucListesi.DataSource = urunler;
                                bulunanSayisiniDegistir(urunler.Count);
                                urunTabloDuzenle();
                            }
                            else{MessageBox.Show("Seçilen Seçenekler Arasında Bir Stok Durumu Bulunamamıştır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                        }else{MessageBox.Show("Lütfen Bir Ürün Grubu Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    }
                }
                else if (cmbIslemTuru.SelectedIndex == 1)
                {
                    if (rdbTumu.Checked)
                    {
                        var stokHareketler = db.StokHareket.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).OrderByDescending(x => x.Tarih).Select(x => new
                        {
                            x.Id,
                            x.Barkod,
                            x.UrunAd,
                            x.UrunGrup,
                            x.Birim,
                            x.Miktar,
                            x.Tarih,
                            x.Kullanici
                        }).ToList();
                        if (stokHareketler.Count > 0)
                        {
                            gridSonucListesi.DataSource = stokHareketler;
                            bulunanSayisiniDegistir(stokHareketler.Count);
                            stokTabloDuzenle();
                        }
                        else{MessageBox.Show("Seçilen Tarihler Arasında Bir Stok Girişi Bulunamamıştır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                    }
                    else
                    {
                        if (cmbUrunGrubu.SelectedIndex != -1)
                        {
                            var stokHareketler = db.StokHareket.Where(x => x.UrunGrup == cmbUrunGrubu.Text && x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).OrderByDescending(x => x.Tarih).Select(x => new
                            {
                                x.Id,
                                x.Barkod,
                                x.UrunAd,
                                x.UrunGrup,
                                x.Birim,
                                x.Miktar,
                                x.Tarih,
                                x.Kullanici
                            }).ToList();
                            if (stokHareketler.Count > 0)
                            {
                                gridSonucListesi.DataSource = stokHareketler;
                                bulunanSayisiniDegistir(stokHareketler.Count);
                                stokTabloDuzenle();
                            }
                            else{ MessageBox.Show("Seçilen Seçenekler Arasında Bir Stok Girişi Bulunamamıştır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                        }else{MessageBox.Show("Lütfen Bir Ürün Grubu Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    }
                }
            }
            else{MessageBox.Show("Lütfen Bir Işlem Türü Seçiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);}
        }
        private void urunTabloDuzenle()
        {
            gridSonucListesi.Columns[0].Visible = false; // ID gizliyoruz
            gridSonucListesi.Columns[1].HeaderText = "Barkod";
            gridSonucListesi.Columns[2].HeaderText = "Ürün Adı";
            gridSonucListesi.Columns[3].HeaderText = "Ürün Grubu";
            gridSonucListesi.Columns[4].HeaderText = "Birim";
            gridSonucListesi.Columns[5].HeaderText = "Stok";
            gridSonucListesi.Columns[6].HeaderText = "KDV Oranı";
            gridSonucListesi.Columns[7].HeaderText = "KDV Tutarı";
            gridSonucListesi.Columns[7].DefaultCellStyle.Format = "C2";
            gridSonucListesi.Columns[8].HeaderText = "Alış Fiyatı";
            gridSonucListesi.Columns[8].DefaultCellStyle.Format = "C2";
            gridSonucListesi.Columns[9].HeaderText = "Satış Fiyatı";
            gridSonucListesi.Columns[9].DefaultCellStyle.Format = "C2";
            gridSonucListesi.Columns[11].HeaderText = "Kullanıcı";
        }
        private void stokTabloDuzenle()
        {
            gridSonucListesi.Columns[0].Visible = false; // ID gizliyoruz
            gridSonucListesi.Columns[1].HeaderText = "Barkod";
            gridSonucListesi.Columns[2].HeaderText = "Ürün Adı";
            gridSonucListesi.Columns[3].HeaderText = "Ürün Grubu";
            gridSonucListesi.Columns[4].HeaderText = "Birim";
            gridSonucListesi.Columns[5].HeaderText = "Miktar";
            gridSonucListesi.Columns[7].HeaderText = "Kullanıcı";
        }

        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex != -1)
            {
                if (txtUrunAdi.Text.Length > 2)
                {
                    var urunler = db.Urun.Where(x => x.UrunAd.Contains(txtUrunAdi.Text)).ToList();
                    gridSonucListesi.DataSource = urunler;
                    gridSonucListesi.Columns["UrunAd"].HeaderText = "Ürün Adı";
                    gridSonucListesi.Columns["Id"].Visible = false;
                    bulunanSayisiniDegistir(urunler.Count);
                }
                else
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        gridSonucListesi.DataSource = null;
                        bulunanSayisiniDegistir(0);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrunAdi.Text = string.Empty;
            }
        }
        private void bulunanSayisiniDegistir(int sayi)
        {
            nudBulunanUrunSayisi.Value = sayi;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            cmbIslemTuru.SelectedIndex = -1;
            rdbTumu.Checked = false;
            rdbUrunGrubunaGore.Checked = false;
            cmbUrunGrubu.SelectedIndex = -1;
            dtpBaslangicTarihi.Value = DateTime.Now;
            dtpBitisTarihi.Value = DateTime.Now;
            txtUrunAdi.Text = string.Empty;
            gridSonucListesi.DataSource = null;
            nudBulunanUrunSayisi.Value = 0;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(cmbIslemTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen işlem türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cmbIslemTuru.SelectedIndex == 0)
            {
                Excel excel = new Excel(gridSonucListesi, "Stok Durumu");
            }
            else if(cmbIslemTuru.SelectedIndex == 1)
            {
                Excel excel = new Excel(gridSonucListesi, "Stok Girişi");
            }
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen işlem türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbIslemTuru.SelectedIndex == 0)
            {
                Pdf pdf = new Pdf(gridSonucListesi, "Stok Durumu");
            }
            else if (cmbIslemTuru.SelectedIndex == 1)
            {
                Pdf pdf = new Pdf(gridSonucListesi, "Stok Girişi");
            }
        }
        private void cbxTumZamanlar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTumZamanlar.Checked)
            {
                dtpBaslangicTarihi.Enabled = false;
                dtpBitisTarihi.Enabled = false;
            }
            else
            {
                dtpBaslangicTarihi.Enabled = true;
                dtpBitisTarihi.Enabled = true;
            }
        }
    }
}
