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
    public partial class frmCustOnServ : Form
    {
        public static string name;

        public frmCustOnServ(string n)
        {
            InitializeComponent();
            name = n;
        }

        public frmCustOnServ()
        {
            InitializeComponent();
        }

        private void frmCustOnServ_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
        }
        private void cboProfileMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProfileMenu.SelectedIndex == 0)
            {
                frmCustEditProfile a = new frmCustEditProfile(name);
                a.ShowDialog();
            }
            else
            {
                this.Hide();
                frmUserLogin b = new frmUserLogin();
                b.ShowDialog();
                this.Close();
            }
        }

        private void btnServiceDesc_Click(object sender, EventArgs e)
        {
            CustOnServ COS = new CustOnServ(name);
            CustOnServ.viewServiceDesc(COS);
            MessageBox.Show("Service Description: " + COS.ServiceDesc);
        }
        private void btnCusCollectionDate_Click(object sender, EventArgs e)
        {
            CustOnServ COS = new CustOnServ(name);
            CustOnServ.viewLaptopCollectionDate(COS);
            MessageBox.Show("Laptop Collection Date: " + COS.LaptopCollectDate);
        }

        private void btnCusTotalAmount_Click(object sender, EventArgs e)
        {
            CustOnServ COS = new CustOnServ(name);
            CustOnServ.viewServiceFee(COS);
            MessageBox.Show("Total Amount To Be Paid: " + COS.ServiceFee);
        }

        private void btnServiceChg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustServChange c = new frmCustServChange(name);
            c.ShowDialog();
        }
    }
}
