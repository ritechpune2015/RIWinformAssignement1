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
    public partial class StateAddFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public StateAddFrm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            DialogResult dr = MessageBox.Show("Are you Sure?", "DemoApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private bool SaveState()
        {

            if (txtState.Text == "" || txtState.Text.Length == 0)
            {
                MessageBox.Show("Please Enter State Name", "DemoApp");
                txtState.Focus();
                return false;
            }

            if (cboCountry.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Country Name", "DemoApp");
                cboCountry.Focus();
                return false;
            }
        
            if (entity.CountryTbls.Any(p => p.CountryName.ToUpper() == txtState.Text.ToUpper()))
            {
                MessageBox.Show("State Nane Already Exists!", "DemoApp");
                txtState.Focus();
                return false;
            }

            try
            {
                StateTbl rec = new StateTbl();
                rec.StateName = txtState.Text;
                rec.CountryID =Convert.ToInt64(cboCountry.SelectedValue.ToString());
                entity.StateTbls.Add(rec);
                entity.SaveChanges();
                MessageBox.Show("State Added!", "DemoApp");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "DemoApp");
            }
            return true;
        }

        private void btnsaveandexit_Click(object sender, EventArgs e)
        {
            if (SaveState())
                this.Close();
        }

        private void btnsveandaddnew_Click(object sender, EventArgs e)
        {
            SaveState();
            txtState.Text = "";
        }

        private void StateAddFrm_Load(object sender, EventArgs e)
        {
            FillCountries();
        }
        private void FillCountries()
        {
            cboCountry.DataSource = entity.CountryTbls.ToList();
            cboCountry.DisplayMember = "CountryName";
            cboCountry.ValueMember = "CountryID";
        
        }

       
    }
}
