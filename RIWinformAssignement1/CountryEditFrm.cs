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
    public partial class CountryEditFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public Int64 RecordID { get; set; }
        public CountryEditFrm()
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

            if (txtCountryName.Text == "" || txtCountryName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Country Name", "DemoApp");
                txtCountryName.Focus();
                return false;
            }

            //if (entity.CountryTbls.Any(p => p.CountryName.ToUpper() == txtCountryName.Text.ToUpper()))
            //{
            //    MessageBox.Show("Country Nane Already Exists!", "DemoApp");
            //    txtCountryName.Focus();
            //    return false;
            //}

            try
            {
                CountryTbl rec = entity.CountryTbls.Find(RecordID);
                rec.CountryName = txtCountryName.Text;
                entity.SaveChanges();
                MessageBox.Show("Country Updated!", "DemoApp");

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
                CountryTbl rec = entity.CountryTbls.Find(RecordID);
                txtCountryName.Text = rec.CountryName;
            }
            else {
                MessageBox.Show("Can not find record!", "DemoApp");
            }
        }
        private void CountryEditFrm_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void btnupdateandexit_Click(object sender, EventArgs e)
        {
            if (UpdateCountry())
                this.Close();
        }
    }
}
