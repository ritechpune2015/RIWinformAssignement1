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
    public partial class LoginFrm : Form
    {
        RIAssignmentDBEntities entity = new RIAssignmentDBEntities();
        public Int64 UserID { get; set; }
        public LoginFrm()
        {
            InitializeComponent();
            this.UserID = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.UserID = 0;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name!");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password!");
                return;
            }

           var rec=entity.BillingCompanyUserTbls.SingleOrDefault(p => p.UserName == txtUserName.Text && p.Password == txtPassword.Text && p.IsActive ==true);
            if (rec != null)
            {
                this.UserID = rec.CompanyUserID;
                this.Close();
            }
            else {

                this.UserID = 0;
                MessageBox.Show("Invalid User Name or Password!");
            }
        }
    }
}
