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
    public partial class CityEditFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public Int64 RecordID { get; set; }
        public bool LoadFlag { get; set; }
        public CityEditFrm()
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

        private bool UpdateCity()
        {


            if (txtCityName.Text == "" || txtCityName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter City Name", "DemoApp");
                txtCityName.Focus();
                return false;
            }

            if (cboState.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select State", "DemoApp");
                cboCountry.Focus();
                return false;
            }

            try
            {
                CityTbl rec = entity.CityTbls.Find(RecordID);
                rec.CityName = txtCityName.Text;
                rec.StateID = Convert.ToInt64(cboState.SelectedValue.ToString());
                entity.SaveChanges();
                MessageBox.Show("City Updated!", "DemoApp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "DemoApp");
            }
            return true;
        }

        public void loadRecord()
        {
            if (RecordID > 0)
            {

                CityTbl rec = entity.CityTbls.Find(RecordID);
                FillStates(Convert.ToInt64(rec.StateTbl.CountryID));
                txtCityName.Text = rec.CityName;
                cboCountry.SelectedValue = rec.StateTbl.CountryID;
                cboState.SelectedValue = rec.StateID;
               
            }
            else
            {
                MessageBox.Show("Can not find record!", "DemoApp");
            }
        }
        private void CityEditFrm_Load(object sender, EventArgs e)
        {
            LoadFlag = false;
            FillCountries();
           
           
          
            loadRecord();
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
            cboState.DataSource = entity.StateTbls.Where(p => p.CountryID == CountryID).ToList();
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

        private void btnupdateandexit_Click(object sender, EventArgs e)
        {
            if (UpdateCity())
                this.Close();
        }
    }
}
