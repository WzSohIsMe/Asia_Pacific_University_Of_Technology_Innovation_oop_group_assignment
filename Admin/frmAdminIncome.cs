using System;
using System.Collections;
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
    public partial class frmAdminIncome : Form
    {
        public static string name;
        public static string pass;

        public frmAdminIncome(string n,string p)
        {
            InitializeComponent();
            name = n;
            pass = p;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminIncome_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int currentMonth = dt.Month;
            cboMonth.SelectedIndex = currentMonth - 1;
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblServ1Count.Text = Admin_Report.dispCount1(cboMonth.SelectedIndex + 1).ToString();
            lblServ2Count.Text = Admin_Report.dispCount2(cboMonth.SelectedIndex + 1).ToString();
            lblServ3Count.Text = Admin_Report.dispCount3(cboMonth.SelectedIndex + 1).ToString();
            lblServ4Count.Text = Admin_Report.dispCount4(cboMonth.SelectedIndex + 1).ToString();
            lblServ5Count.Text = Admin_Report.dispCount5(cboMonth.SelectedIndex + 1).ToString();
            lblServ6Count.Text = Admin_Report.dispCount6(cboMonth.SelectedIndex + 1).ToString();
            lblServ7Count.Text = Admin_Report.dispCount7(cboMonth.SelectedIndex + 1).ToString();
            lblServ8Count.Text = Admin_Report.dispCount8(cboMonth.SelectedIndex + 1).ToString();

            lblServ1Sum.Text = Admin_Report.dispSum1(cboMonth.SelectedIndex + 1).ToString();
            lblServ2Sum.Text = Admin_Report.dispSum2(cboMonth.SelectedIndex + 1).ToString();
            lblServ3Sum.Text = Admin_Report.dispSum3(cboMonth.SelectedIndex + 1).ToString();
            lblServ4Sum.Text = Admin_Report.dispSum4(cboMonth.SelectedIndex + 1).ToString();
            lblServ5Sum.Text = Admin_Report.dispSum5(cboMonth.SelectedIndex + 1).ToString();
            lblServ6Sum.Text = Admin_Report.dispSum6(cboMonth.SelectedIndex + 1).ToString();
            lblServ7Sum.Text = Admin_Report.dispSum7(cboMonth.SelectedIndex + 1).ToString();
            lblServ8Sum.Text = Admin_Report.dispSum8(cboMonth.SelectedIndex + 1).ToString();

            lblIncome.Text = "RM "+Admin_Report.addIncome(cboMonth.SelectedIndex + 1).ToString();
        }
    }
}
