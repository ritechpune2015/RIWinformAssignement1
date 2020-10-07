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
    public partial class StateEditFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public Int64 RecordID { get; set; }
        public StateEditFrm()
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

        private bool UpdateCountry()
        {
            

            if (txtState.Text == "" || txtState.Text.Length == 0)
            {
                MessageBox.Show("Please Enter State Name", "DemoApp");
                txtState.Focus();
                return false;
            }

            if (cboCountry.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Country", "DemoApp");
                cboCountry.Focus();
                return false;
            }

            try
            {
                StateTbl rec = entity.StateTbls.Find(RecordID);
                rec.StateName = txtState.Text;
                rec.CountryID = Convert.ToInt64(cboCountry.SelectedValue.ToString());
                entity.SaveChanges();
                MessageBox.Show("State Updated!", "DemoApp");
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
                StateTbl rec = entity.StateTbls.Find(RecordID);
                txtState.Text = rec.StateName;
                cboCountry.SelectedValue =rec.CountryID;
            }
            else
            {
                MessageBox.Show("Can not find record!", "DemoApp");
            }
        }
        private void StateEditFrm_Load(object sender, EventArgs e)
        {
            FillCountries();
            loadRecord();
        }

        private void FillCountries()
        {
            cboCountry.DataSource = entity.CountryTbls.ToList();
            cboCountry.DisplayMember = "CountryName";
            cboCountry.ValueMember = "CountryID";

        }

        private void btnupdateandexit_Click(object sender, EventArgs e)
        {
            if (UpdateCountry())
                this.Close();
        }
    }
}
