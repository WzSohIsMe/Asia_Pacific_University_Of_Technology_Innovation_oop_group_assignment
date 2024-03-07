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
    public partial class frmTechEditProfile : Form
    {
        private string username;
        private bool apply_or_back;

        public bool Apply_or_back { get => apply_or_back; set => apply_or_back = value; }

        public frmTechEditProfile()
        {
            InitializeComponent();
        }

        public frmTechEditProfile(string un)
        {
            InitializeComponent();
            username = un;

        }


        private void frmTechEditProfile_Load(object sender, EventArgs e)
        {
            txtTechUsername.Text = username;
            
        }

        private void txtCurrentName_Enter(object sender, EventArgs e)
        {
            if(txtNewUsername.Text=="Enter New Username")
            {
                txtNewUsername.Text = "";
                txtNewUsername.ForeColor = Color.Black;
            }
        }

        private void txtCurrentName_Leave(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == "")
            {
                txtNewUsername.Text = "Enter New Username";
                txtNewUsername.ForeColor = Color.LightGray;
            }
        }


        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "Enter New Password")
            {
                txtNewPassword.Text = "";
                txtNewPassword.ForeColor = Color.Black;
                txtNewPassword.PasswordChar = '*';
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.PasswordChar= '\0';
                txtNewPassword.Text = "Enter New Password";
                txtNewPassword.ForeColor = Color.LightGray;
                
            }
        }

        private void btnTechApply_Click(object sender, EventArgs e)
        {
            string new_username = txtNewUsername.Text;
            
            string new_password=txtNewPassword.Text;
            
            
            Technician tech = new Technician(username);
            if ((new_username != "Enter New Username")&&(new_password !="Enter New Password"))
            {
                try
                {
                    tech.edit_profile(username, new_username, new_password);
                    apply_or_back = tech.IsApply("Apply");
                    MessageBox.Show("Detail Has Been Updated Sucessfully.", "Edit Profile");
                    this.Close();
                    MessageBox.Show("Please Login Again.");
                }
                catch
                {
                    MessageBox.Show("Failed To Update.", "Error");
                    MessageBox.Show("Please Make Sure You Insert Properly.", "Tips");
                }
            }
            else
            {
                MessageBox.Show("Username and Password Must Not Be Blank.","Error");
            }   
        }

        private void btnTechBack_Click(object sender, EventArgs e)
        {
            Technician tech = new Technician();
            apply_or_back = tech.IsApply("Back");
            this.Hide();
        }
    }
}
