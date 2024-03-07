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
    public partial class frmTechHome : Form
    {
        FormCollection forms = Application.OpenForms;

        private string username;
        private string password;
        
        public frmTechHome(string un, string p)
        {
            InitializeComponent();
            username = un;
            password = p;
        }

        public frmTechHome(string un)
        {
            InitializeComponent();
            username = un;
        }
        
        private void frmTechHome_Load(object sender, EventArgs e)
        {
            lblTechUsername.Text = username;
            
        }

        
        private void btnTechViewReqServ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTechViewRequestedService viewService = new frmTechViewRequestedService();
            viewService.ShowDialog();
            this.Show();
        }

        private void lblTechAddDescAndCollecDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTechAddDescriptionAndLaptopCollectionDate editService = new frmTechAddDescriptionAndLaptopCollectionDate();
            editService.ShowDialog();
            this.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTechEditProfile editProfile = new frmTechEditProfile(username);
            editProfile.ShowDialog();
            if (editProfile.Apply_or_back==true)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnTechSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

  
    }
}
