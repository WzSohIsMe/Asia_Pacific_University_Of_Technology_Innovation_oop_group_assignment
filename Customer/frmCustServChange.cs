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
    public partial class frmCustServChange : Form
    {
        public static string name;

        public frmCustServChange(string n)
        {
            InitializeComponent();
            name = n;
        }
        public frmCustServChange()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (rdbNormal.Checked)
            {
                if (cboServChg.SelectedItem.ToString() != lblReqServ.Text)
                {
                    CustServChg obj1 = new CustServChg(name);
                    MessageBox.Show(obj1.updateServChg(rdbNormal.Text, cboServChg.SelectedItem.ToString()));
                }
                else
                {
                    MessageBox.Show("Please choose a different service from the current one to change");
                }
            }
            else if(rdbUrgent.Checked)
            {
                if (cboServChg.SelectedItem.ToString() != lblReqServ.Text)
                {
                    CustServChg obj1 = new CustServChg(name);
                    MessageBox.Show(obj1.updateServChg(rdbUrgent.Text, cboServChg.SelectedItem.ToString()));
                }
                else
                {
                    MessageBox.Show("Please choose a different service from the current one to change");
                }
            }
            else
            {
                MessageBox.Show("Please choose the service urgency");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustOnServ s = new frmCustOnServ();
            s.ShowDialog();
            this.Close();
        }

        private void frmCustServChange_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
            CustServChg CSC = new CustServChg(name);
            CustServChg.currentReqServ(CSC);
            lblReqServ.Text = CSC.ServiceType;
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
    }
}
