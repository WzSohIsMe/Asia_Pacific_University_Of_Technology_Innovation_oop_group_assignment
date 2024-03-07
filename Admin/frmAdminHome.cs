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
    public partial class frmAdminHome : Form
    {
        public static string name;
        public static string pass;
        public static string role = "null";
        public bool logout = false;

        public frmAdminHome(string n,string p)
        {
            InitializeComponent();
            name = n;
            pass = p;
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";

                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";

                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.PasswordChar = '•';
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";

                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            frmAdminEdit f1 = new frmAdminEdit(name,pass);
            this.Hide();
            f1.ShowDialog();
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            txtUsername.Text = "Enter Username";
            txtPassword.PasswordChar = '\0';
            txtPassword.Text = "Enter Password";
            this.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmAdminIncome f3 = new frmAdminIncome(name,pass);
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (rdbReceptionist.Checked == true)
                role = "Receptionist";
            else if (rdbTechnician.Checked == true)
                role = "Technician";
            if (txtUsername.Text != "" && txtPassword.Text != "" && role != "null")
            {
                Admin obj1 = new Group_35_Assignment.Admin(txtUsername.Text, txtPassword.Text, role);
                MessageBox.Show(obj1.register());
            }
        }
    }
}
