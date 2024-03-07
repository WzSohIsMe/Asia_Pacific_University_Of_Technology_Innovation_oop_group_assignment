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
    public partial class frmCustEditProfile : Form
    {
        public static string name;
        public frmCustEditProfile()
        {
            InitializeComponent();
        }
        public frmCustEditProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void frmCustEditProfile_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            CustEditProfile CEP = new CustEditProfile(name, txtCurrentPw.Text, txtNewPw.Text, txtRePw.Text);
            MessageBox.Show(CEP.editProfile());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
