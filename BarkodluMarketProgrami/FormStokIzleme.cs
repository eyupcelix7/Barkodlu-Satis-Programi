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
            if(cmbIslemTuru.Text != "")
            {
                DateTime baslangicTarihi = DateTime.Parse(dtpBaslangicTarihi.Value.ToShortDateString());
                DateTime bitisTarihi = DateTime.Parse(dtpBitisTarihi.Value.ToShortDateString()).AddDays(1);

                if (cmbIslemTuru.SelectedIndex == 0)
                {
                    var urunler = new List<Urun>();
                    if (rdbTumu.Checked)
                    {
                        urunler = db.Urun.Where(x => x.Miktar > 0 && x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).ToList();
                    }
                    else
                    {
                        if(cmbUrunGrubu.Text != "")
                        {
                            urunler = db.Urun.Where(a => a.UrunGrup == cmbUrunGrubu.Text && a.Tarih >= baslangicTarihi && a.Tarih <= bitisTarihi).ToList();
                        }
                    }
                    gridSonucListesi.DataSource = urunler;
                    gridSonucListesi.Columns["UrunAd"].HeaderText = "Ürün Adı";
                    gridSonucListesi.Columns["Id"].Visible = false;
                    bulunanSayisiniDegistir(urunler.Count);
                }
                else if(cmbIslemTuru.SelectedIndex == 1)
                {
                    var stokHareketler = new List<StokHareket>();
                    if (rdbTumu.Checked)
                    {
                        stokHareketler = db.StokHareket.Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).OrderByDescending(x => x.Tarih).ToList();
                    }
                    else
                    {
                        stokHareketler = db.StokHareket
                        .Where(x => x.UrunGrup == cmbUrunGrubu.Text && x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).OrderByDescending(x => x.Tarih).ToList();
                    }
                    gridSonucListesi.DataSource = stokHareketler;
                    gridSonucListesi.Columns["UrunAd"].HeaderText = "Ürün Adı";
                    gridSonucListesi.Columns["Barkod"].HeaderText = "Barkod";
                    gridSonucListesi.Columns["Id"].Visible = false;
                }
            }
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
    }
}
