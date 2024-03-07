using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_35_Assignment
{
    public partial class frmRcptnEditPrf : Form
    {
        public static string name;

        public frmRcptnEditPrf()
        {
            InitializeComponent();
        }

        public frmRcptnEditPrf(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void frmRcptnEditPrf_Load(object sender, EventArgs e)
        {
            lblRcptnEditUsnmSh.Text = name;
            btnRcptnEditPrfSave.Enabled = false;
        }

        private void txtRcptnEditOldPwd_Enter(object sender, EventArgs e)
        {
            if (txtRcptnEditOldPwd.Text == "Old Password")
            {
                txtRcptnEditOldPwd.PasswordChar = '•';
                txtRcptnEditOldPwd.Text = "";

                txtRcptnEditOldPwd.ForeColor = Color.Black;
            }
        }

        private void txtRcptnEditOldPwd_Leave(object sender, EventArgs e)
        {
            if (txtRcptnEditOldPwd.Text == "")
            {
                txtRcptnEditOldPwd.PasswordChar = '\0';
                txtRcptnEditOldPwd.Text = "Old Password";

                txtRcptnEditOldPwd.ForeColor = Color.Gray;
            }
        }

        private void txtRcptnEditNewPwd_Enter(object sender, EventArgs e)
        {
            if (txtRcptnEditNewPwd.Text == "New Password")
            {
                txtRcptnEditNewPwd.PasswordChar = '•';
                txtRcptnEditNewPwd.Text = "";

                txtRcptnEditNewPwd.ForeColor = Color.Black;
            }
        }

        private void txtRcptnEditNewPwd_Leave(object sender, EventArgs e)
        {
            if (txtRcptnEditNewPwd.Text == "")
            {
                txtRcptnEditNewPwd.PasswordChar = '\0';
                txtRcptnEditNewPwd.Text = "New Password";

                txtRcptnEditNewPwd.ForeColor = Color.Gray;
            }
        }

        private void txtRcptnEditReNewPwd_Enter(object sender, EventArgs e)
        {
            if (txtRcptnEditReNewPwd.Text == "Re-type New Password")
            {
                txtRcptnEditReNewPwd.PasswordChar = '•';
                txtRcptnEditReNewPwd.Text = "";

                txtRcptnEditReNewPwd.ForeColor = Color.Black;
            }
        }

        private void txtRcptnEditReNewPwd_Leave(object sender, EventArgs e)
        {
            if (txtRcptnEditReNewPwd.Text == "")
            {
                txtRcptnEditReNewPwd.PasswordChar = '\0';
                txtRcptnEditReNewPwd.Text = "Re-type New Password";

                txtRcptnEditReNewPwd.ForeColor = Color.Gray;
            }
        }

        private void chkRcptnEditConf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRcptnEditConf.Checked == true)
            {
                if (txtRcptnEditOldPwd.Text == "Old Password" || txtRcptnEditOldPwd.Text == "" || txtRcptnEditNewPwd.Text == "New Password" || 
                    txtRcptnEditNewPwd.Text == "" || txtRcptnEditReNewPwd.Text == "Re-type New Password" || txtRcptnEditReNewPwd.Text == "")
                {
                    chkRcptnEditConf.Checked = false;
                    MessageBox.Show("Please fill in all details!");
                }
                else
                {
                    txtRcptnEditOldPwd.Enabled = false;
                    txtRcptnEditNewPwd.Enabled = false;
                    txtRcptnEditReNewPwd.Enabled = false;
                    btnRcptnEditPrfSave.Enabled = true;
                }
            }
            else if (chkRcptnEditConf.Checked == false)
            {
                btnRcptnEditPrfSave.Enabled = false;
                txtRcptnEditOldPwd.Enabled = true;
                txtRcptnEditNewPwd.Enabled = true;
                txtRcptnEditReNewPwd.Enabled = true;
            }
        }

        private void btnRcptnEditPrfSave_Click(object sender, EventArgs e)
        {
            Receptionist_Prof rcptnProf = new Receptionist_Prof(name, txtRcptnEditOldPwd.Text, txtRcptnEditNewPwd.Text, txtRcptnEditReNewPwd.Text);
            MessageBox.Show(rcptnProf.editRcptnProf());

            btnRcptnEditPrfSave.Enabled = false;
            txtRcptnEditOldPwd.Enabled = true;
            txtRcptnEditNewPwd.Enabled = true;
            txtRcptnEditReNewPwd.Enabled = true;
            chkRcptnEditConf.Checked = false;
            txtRcptnEditOldPwd.PasswordChar = '\0';
            txtRcptnEditNewPwd.PasswordChar = '\0';
            txtRcptnEditReNewPwd.PasswordChar = '\0';
            txtRcptnEditOldPwd.ForeColor = Color.Gray;
            txtRcptnEditNewPwd.ForeColor = Color.Gray;
            txtRcptnEditReNewPwd.ForeColor = Color.Gray;
            txtRcptnEditOldPwd.Text = "Old Password";
            txtRcptnEditNewPwd.Text = "New Password";
            txtRcptnEditReNewPwd.Text = "Re-type New Password";
        }

        private void btnRcptnEditPrfBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
