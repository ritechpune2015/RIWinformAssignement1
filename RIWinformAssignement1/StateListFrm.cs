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
    public partial class StateListFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public StateListFrm()
        {
            InitializeComponent();
        }


        //default event hanlder - load
        private void StateListFrm_Load(object sender, EventArgs e)
        {
            LoadStateDataGrid();
        }
        private void LoadStateDataGrid()
        {
            dataGridView1.DataSource = null;
           
            var v = from t in entity.StateTbls
                    select new
                    {
                        t.StateID,
                        t.StateName,
                        t.CountryTbl.CountryName
                    };
            dataGridView1.DataSource = v.ToList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            StateAddFrm cfrm = new StateAddFrm();
            cfrm.ShowDialog();
            LoadStateDataGrid();
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
                    Int64 StateID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    StateTbl crec = entity.StateTbls.Find(StateID);
                    entity.StateTbls.Remove(crec);
                    entity.SaveChanges();
                    MessageBox.Show("Record Deleted!", "DemoApp");
                    LoadStateDataGrid();
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

        private void StateListFrm_FormClosing(object sender, FormClosingEventArgs e)
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
                Int64 StateID = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                StateEditFrm editfrm = new StateEditFrm();
                editfrm.RecordID = StateID;
                editfrm.ShowDialog();
                LoadStateDataGrid();
            }
            else
            {
                MessageBox.Show("Please Select Row To Edit!", "Demo App");
            }
        }
    }
}
