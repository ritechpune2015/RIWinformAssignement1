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
    public partial class CountryAddFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public CountryAddFrm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
           DialogResult dr=MessageBox.Show("Are you Sure?", "DemoApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(dr == DialogResult.Yes)
            this.Close();
        }

        private bool SaveCountry()
        {
            
            if (txtCountryName.Text == "" || txtCountryName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Country Name", "DemoApp");
                txtCountryName.Focus();
                return false;
            }

            if (entity.CountryTbls.Any(p => p.CountryName.ToUpper() == txtCountryName.Text.ToUpper()))
            {
                MessageBox.Show("Country Nane Already Exists!", "DemoApp");
                txtCountryName.Focus();
                return false;
            }

            try
            {
                CountryTbl rec = new CountryTbl();
                rec.CountryName = txtCountryName.Text;
                entity.CountryTbls.Add(rec);
                entity.SaveChanges();
                MessageBox.Show("Country Added!", "DemoApp");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "DemoApp");
            }
            return true;
        }

        private void btnsaveandexit_Click(object sender, EventArgs e)
        {
            if(SaveCountry())
              this.Close();
        }

        private void btnsveandaddnew_Click(object sender, EventArgs e)
        {
            SaveCountry();
            txtCountryName.Text = "";
        }

        private void CountryAddFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
