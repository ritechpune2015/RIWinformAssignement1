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
    public partial class CityAddFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        private bool LoadFlag = false;
        public CityAddFrm()
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

        private bool SaveCity()
        {

            if (txtCityName.Text == "" || txtCityName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter State Name", "DemoApp");
                txtCityName.Focus();
                return false;
            }

            if (cboState.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select State Name", "DemoApp");
                cboCountry.Focus();
                return false;
            }

            if (entity.CityTbls.Any(p => p.CityName.ToUpper() == txtCityName.Text.ToUpper()))
            {
                MessageBox.Show("City Name Already Exists!", "DemoApp");
                txtCityName.Focus();
                return false;
            }

            try
            {
                CityTbl rec = new CityTbl();
                rec.CityName = txtCityName.Text;
                rec.StateID = Convert.ToInt64(cboState.SelectedValue.ToString());
                entity.CityTbls.Add(rec);
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
            if (SaveCity())
                this.Close();
        }

        private void btnsveandaddnew_Click(object sender, EventArgs e)
        {
            SaveCity();
            txtCityName.Text = "";
        }

        private void CityAddFrm_Load(object sender, EventArgs e)
        {
            LoadFlag = false;
            FillCountries();
            // FillStates();
            LoadFlag = true;
        }
        private void FillCountries()
        {
            cboCountry.DataSource = entity.CountryTbls.ToList();
            cboCountry.DisplayMember = "CountryName";
            cboCountry.ValueMember = "CountryID";

        }

        private void FillStates(Int64 CountryID)
        {
            cboState.DataSource = entity.StateTbls.Where(p=>p.CountryID==CountryID).ToList();
            cboState.DisplayMember = "StateName";
            cboState.ValueMember = "StateID";

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (LoadFlag)
            {
                Int64 CountryID = Convert.ToInt64(cboCountry.SelectedValue);
                FillStates(CountryID);
            }
        }
    }
}
