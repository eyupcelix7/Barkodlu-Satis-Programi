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
    public partial class FormUrunGrubuEkle : Form
    {
        BarkodEntities db = new BarkodEntities();
        FormUrunGiris _form = null;
        public FormUrunGrubuEkle(FormUrunGiris form)
        {
            InitializeComponent();
            _form = form;
        }

        private void FormUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            grupDoldur();
        }
        private void grupDoldur(int max = 20)
        {
            lstGruplar.DisplayMember = "GrupAdi";
            lstGruplar.ValueMember = "Id";
            var gruplar = db.UrunGrubu.OrderBy(x => x.GrupAdi).Take(max).ToList();
            lstGruplar.DataSource = gruplar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGrupAdi.Text))
            {
                var yeniGrup = new UrunGrubu
                {
                    GrupAdi = txtGrupAdi.Text.Trim()
                };
                db.UrunGrubu.Add(yeniGrup);
                db.SaveChanges();
                grupDoldur();
                MessageBox.Show("Grup başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _form.urunGrubuDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string grupAdi = lstGruplar.Text;
            string grupId = lstGruplar.SelectedValue.ToString();
            DialogResult result = MessageBox.Show(grupAdi + " adlı grup silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var silinecekGrup = db.UrunGrubu.Find(Convert.ToInt32(grupId));
                if (silinecekGrup != null)
                {
                    db.UrunGrubu.Remove(silinecekGrup);
                    db.SaveChanges();
                    MessageBox.Show("Grup başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grupDoldur();
                    _form.urunGrubuDoldur();
                }
            }
        }
    }
}
