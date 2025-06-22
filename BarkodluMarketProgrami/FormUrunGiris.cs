using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BarkodluMarketProgrami
{
    public partial class FormUrunGiris : Form
    {
        public FormUrunGiris()
        {
            InitializeComponent();
        }

        private void btnEkranKlavyesi_Click(object sender, EventArgs e)
        {
            Process.Start("osk.exe");
        }
    }
}
