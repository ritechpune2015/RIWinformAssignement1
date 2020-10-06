using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIWinformAssignement1
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryListFrm frm = new CountryListFrm();
            frm.MdiParent = this;
            frm.Show();
          //  frm.ShowDialog();
        }
    }
}
