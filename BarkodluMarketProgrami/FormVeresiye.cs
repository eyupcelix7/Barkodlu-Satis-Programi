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
    public partial class FormVeresiye : Form
    {
        double _toplamTutar = 0.0;
        string odemeSekli;
        private FormSatis _formSatis;
        public FormVeresiye(double toplamTutar, FormSatis form)
        {
            InitializeComponent();
            _toplamTutar = toplamTutar;
            _formSatis = form;
        }
        private void FormVeresiye_Load(object sender, EventArgs e)
        {
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
        private void btnEnter_Click(object sender, EventArgs e)
        {
            double veresiyeMiktar = Convert.ToDouble(txtNumarator.Text);
            double kalan = _toplamTutar - veresiyeMiktar;
            DialogResult result;
            if (rdbVeresiye.Checked)
            {
                result = MessageBox.Show("Veresiye Tutarı: " + veresiyeMiktar.ToString("C2") + "\nOnaylıyor Musunuz?", "Veresiye Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                odemeSekli = "Veresiye";
                _formSatis.veresiyeTutar = veresiyeMiktar;

            }
            else if (rdbNakit.Checked)
            {
                result = MessageBox.Show("Veresiye Tutarı: " + veresiyeMiktar.ToString("C2") +"\nNakit Tutarı: "+ kalan.ToString("C2")+ "\nOnaylıyor Musunuz?", "Veresiye Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                odemeSekli = "Nakit-Veresiye";
                _formSatis.veresiyeNakitTutar = veresiyeMiktar;
            }
            else
            {
                result = MessageBox.Show("Veresiye Tutarı: " + veresiyeMiktar.ToString("C2") + "\nNakit Tutarı: " + kalan.ToString("C2") + "\nOnaylıyor Musunuz?", "Veresiye Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                odemeSekli = "Kart-Veresiye";
                _formSatis.veresiyeKartTutar = veresiyeMiktar;
            }
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rdbVeresiye_Click(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if(rdb != null)
            {
                switch(rdb.Name)
                {
                    case "rdbVeresiye":
                        lblTutar.Text = "Veresiye Tutarı";
                    break;
                    case "rdbKart":
                        lblTutar.Text = "Kart Tutarı";
                    break;
                    case "rdbNakit":
                        lblTutar.Text = "Nakit Tutarı";
                    break;
                }
            }
        }
    }
}
