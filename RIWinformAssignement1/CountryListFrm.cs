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
    public partial class CountryListFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public CountryListFrm()
        {
            InitializeComponent();
        }


        //default event hanlder - load
        private void CountryListFrm_Load(object sender, EventArgs e)
        {
            LoadCountryDataGrid();
        }
        private void LoadCountryDataGrid()
        {
            dataGridView1.DataSource = null;
            //  dataGridView1.DataSource = entity.CountryTbls.ToList();
            var v = from t in entity.CountryTbls
                    select new
                    {
                        t.CountryID,
                        t.CountryName
                    };
            dataGridView1.DataSource = v.ToList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CountryAddFrm cfrm = new CountryAddFrm();
            cfrm.ShowDialog();
            LoadCountryDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {

               DialogResult dr= MessageBox.Show("Are you want to Delete record?", "DemoApp",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {
                    Int64 CountryID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    CountryTbl crec = entity.CountryTbls.Find(CountryID);
                    entity.CountryTbls.Remove(crec);
                    entity.SaveChanges();
                    MessageBox.Show("Record Deleted!", "DemoApp");
                    LoadCountryDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else {
                MessageBox.Show("Please Select Row To Delete!", "Demo App");
            }
        }

      
        public void FormClose()
        {
            DialogResult dr = MessageBox.Show("Are you want to exit?", "DemoApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormClose();
        }

        private void CountryListFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to exit?", "DemoApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
             {
                Int64 CountryID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CountryEditFrm editfrm = new CountryEditFrm();
                editfrm.RecordID = CountryID;
                editfrm.ShowDialog();
                LoadCountryDataGrid();
            }
            else
            {
                MessageBox.Show("Please Select Row To Edit!", "Demo App");
            }
        }
    }
}
