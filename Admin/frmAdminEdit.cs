using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_35_Assignment
{
    public partial class frmAdminEdit : Form
    {
        public static string name;
        public static string pass;

        public frmAdminEdit(string n,string p)
        {
            InitializeComponent();
            name = n;
            pass = p;
        }

        private void frmAdminEdit_Load(object sender, EventArgs e)
        {
            lblDispUsername.Text = name;
        }

        private void txtOldPass_Enter(object sender, EventArgs e)
        {
            {
                if (txtOldPass.Text == "Old Password")
                {
                    txtOldPass.PasswordChar = '•';
                    txtOldPass.Text = "";

                    txtOldPass.ForeColor = Color.Black;
                }
            }
        }

        private void txtOldPass_Leave(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "")
            {
                txtOldPass.PasswordChar = '\0';
                txtOldPass.Text = "Old Password";

                txtOldPass.ForeColor = Color.Gray;
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            {
                if (txtNewPass.Text == "New Password")
                {
                    txtNewPass.PasswordChar = '•';
                    txtNewPass.Text = "";

                    txtNewPass.ForeColor = Color.Black;
                }
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.PasswordChar = '\0';
                txtNewPass.Text = "New Password";

                txtNewPass.ForeColor = Color.Gray;
            }
        }

        private void txtCfmPass_Enter(object sender, EventArgs e)
        {
            {
                if (txtCfmPass.Text == "Confirm New Password")
                {
                    txtCfmPass.PasswordChar = '•';
                    txtCfmPass.Text = "";

                    txtCfmPass.ForeColor = Color.Black;
                }
            }
        }

        private void txtCfmPass_Leave(object sender, EventArgs e)
        {
            if (txtCfmPass.Text == "")
            {
                txtCfmPass.PasswordChar = '\0';
                txtCfmPass.Text = "Confirm New Password";

                txtCfmPass.ForeColor = Color.Gray;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboxConfirm.Checked == true)
                if (txtOldPass.Text == pass)
                    if (txtNewPass.Text == txtCfmPass.Text)
                    {
                        Admin adminProf = new Admin(name, txtOldPass.Text, txtNewPass.Text, txtCfmPass.Text);
                        MessageBox.Show(adminProf.edit());
                    }
                    else
                        MessageBox.Show("Confirm Password does not match.");
                else
                    MessageBox.Show("Old Password Incorrect.");
            else
                MessageBox.Show("Please confirm your changes");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
