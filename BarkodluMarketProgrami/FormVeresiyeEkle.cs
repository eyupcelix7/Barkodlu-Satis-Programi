using com.itextpdf.text.pdf;
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
    public partial class FormVeresiyeEkle : Form
    {
        public string veresiyeTur { get; set; } // Al - Ver
        BarkodEntities db = new BarkodEntities();
        List<int> eklenenler = new List<int>();
        public FormVeresiyeEkle(string vTur = null)
        {
            InitializeComponent();
            if (vTur != null)
            {
                veresiyeTur = vTur;
            }
        }
        private void btnNumClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "<")
            {
                txtNumarator.Text = txtNumarator.Text.Substring(0, txtNumarator.Text.Length - 1);
            }
            else if (btn.Text == ",")
            {
                if (txtNumarator.Text.Length > 0)
                {
                    txtNumarator.Text += btn.Text;
                }
            }
            else
            {
                txtNumarator.Text += btn.Text;
            }
        }
        private void txtKisiAra_TextChanged(object sender, EventArgs e)
        {
            if (txtKisiAra.Text.Length > 1)
            {
               var kisiler = db.Kullanici.Where(x => x.AdSoyad.Contains(txtKisiAra.Text)).Select(x => new
                {
                    x.AdSoyad,
                    x.Id
                }).ToList();

                if(kisiler.Count > 0)
                {
                    cbxKisiler.DataSource = kisiler;
                    cbxKisiler.DisplayMember = "AdSoyad";
                    cbxKisiler.ValueMember = "Id";
                }
                else
                {
                    cbxKisiler.DataSource = null;
                    eklenenler.Clear();
                }
            }
            else
            {
                if(txtKisiAra.Text == "")
                {
                    cbxKisiler.DataSource = null;
                    eklenenler.Clear();
                    pnlSecilenKisi.Visible = false;
                }
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbxKisiler.SelectedValue.ToString());
        }
        private void cbxKisiler_TextChanged(object sender, EventArgs e)
        {
            pnlSecilenKisi.Visible = true;
            lblSecilenKisiDeger.Text = cbxKisiler.Text;
        }
        private void lblSecilenKisiDeger_Click(object sender, EventArgs e)
        {
            if(lblSecilenKisiDeger.Text != "")
            {
                MessageBox.Show("Emin misin yarr: "+ cbxKisiler.Text);
            }
        }
    }
}
