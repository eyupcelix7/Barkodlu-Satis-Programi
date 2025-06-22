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
    public partial class FormNakitKart : Form
    {
        double _toplamTutar = 0.0;
        private FormSatis _formSatis;
        public FormNakitKart(double toplamTutar, FormSatis form)
        {
            InitializeComponent();
            _toplamTutar = toplamTutar;
            _formSatis = form;
        }
        private void NakitKartForm_Load(object sender, EventArgs e)
        {}
        private void btnEnter_Click(object sender, EventArgs e)
        {
            double nakitMiktar = Convert.ToDouble(txtNumarator.Text);
            double kartMiktar = _toplamTutar - nakitMiktar;
            DialogResult result = MessageBox.Show("Nakit Tutarı: "+nakitMiktar.ToString("C2")+"\nKredi Kartı Tutarı: "+kartMiktar.ToString("C2")+"\nOnaylıyor Musunuz?","Nakit - Kart Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                _formSatis.nakitKartTutar = nakitMiktar;
                _formSatis.satisYap("Kart-Nakit");
                this.Close();
            }
        }
        private void btnNum_Click(object sender, EventArgs e)
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
    }
}
