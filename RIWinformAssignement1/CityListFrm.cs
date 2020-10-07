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
    public partial class CityListFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public CityListFrm()
        {
            InitializeComponent();
        }


        //default event hanlder - load
        private void CityListFrm_Load(object sender, EventArgs e)
        {
            LoadCityDataGrid();
        }
        private void LoadCityDataGrid()
        {
            dataGridView1.DataSource = null;

            var v = from t in entity.CityTbls
                    select new
                    {
                        t.CityID,
                        t.CityName,
                        t.StateTbl.StateName,
                        t.StateTbl.CountryTbl.CountryName
                    };
            dataGridView1.DataSource = v.ToList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CityAddFrm cfrm = new CityAddFrm();
            cfrm.ShowDialog();
            LoadCityDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {

                DialogResult dr = MessageBox.Show("Are you want to Delete record?", "DemoApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {
                    Int64 CityID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    CityTbl crec = entity.CityTbls.Find(CityID);
                    entity.CityTbls.Remove(crec);
                    entity.SaveChanges();
                    MessageBox.Show("Record Deleted!", "DemoApp");
                    LoadCityDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
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

        private void CityListFrm_FormClosing(object sender, FormClosingEventArgs e)
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
                Int64 CityID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CityEditFrm editfrm = new CityEditFrm();
                editfrm.RecordID = CityID;
                editfrm.ShowDialog();
                LoadCityDataGrid();
            }
            else
            {
                MessageBox.Show("Please Select Row To Edit!", "Demo App");
            }
        }
    }
}

