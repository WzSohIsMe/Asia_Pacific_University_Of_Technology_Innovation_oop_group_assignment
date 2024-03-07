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
    public partial class frmRcptnPymtPage : Form
    {
        public bool new_load = true;
        public static double balance;
        public static string rec_no;
        public static string collect_date;
        public static string name;

        public frmRcptnPymtPage()
        {
            InitializeComponent();
        }

        public frmRcptnPymtPage(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void frmRcptnPymtPage_Load(object sender, EventArgs e)
        {
            cboRcptnPymtCustUsnm.DataSource = Receptionist_Cust.addCustCbo();
            btnRcptnPymtGenRcpt.Enabled = false;
        }

        private void cboRcptnPymtCustUsnm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (new_load == true)
            {
                cboRcptnPymtCustUsnm.Text = "Customer Username";
                new_load = false;
            }
            else
            {
                ArrayList pymt_info = new ArrayList();

                Receptionist_Cust pymt = new Receptionist_Cust(cboRcptnPymtCustUsnm.SelectedItem.ToString());

                pymt_info = pymt.showPayment();

                if (pymt_info.Count == 5)
                {
                    lblRcptnPymtSerSh.Text = pymt_info[0].ToString() + " (" + pymt_info[1].ToString() + ")";
                    lblRcptnPymtSerFeeSh.Text = pymt_info[2].ToString();
                    rec_no = pymt_info[3].ToString();
                    collect_date = pymt_info[4].ToString();

                    if (collect_date == "")
                    {
                        lblRcptnPymtSerSh.Text = String.Empty;
                        lblRcptnPymtSerFeeSh.Text = String.Empty;
                        MessageBox.Show("Please pay on laptop collection date!");
                    }
                }
                else
                {
                    lblRcptnPymtSerSh.Text = String.Empty;
                    lblRcptnPymtSerFeeSh.Text = String.Empty;
                    MessageBox.Show("This customer has not made any service request yet!");
                }
            }
        }

        private void btnRcptnPymtClear_Click(object sender, EventArgs e)
        {
            cboRcptnPymtCustUsnm.Text = "Customer Username";
            lblRcptnPymtSerSh.Text = String.Empty;
            lblRcptnPymtSerFeeSh.Text= String.Empty;
            txtRcptnPymtRcvd.Text = String.Empty;
        }

        private void btnRcptnPymtAcc_Click(object sender, EventArgs e)
        {
            int ser_fee;
            double paid_amount;

            if (cboRcptnPymtCustUsnm.Text == "Customer Username" || cboRcptnPymtCustUsnm.Text == String.Empty || cboRcptnPymtCustUsnm.SelectedIndex < 0 || lblRcptnPymtSerSh.Text == "")
            {
                MessageBox.Show("Please select a customer!");
                cboRcptnPymtCustUsnm.Text = "Customer Username";
                lblRcptnPymtSerSh.Text = String.Empty;
                lblRcptnPymtSerFeeSh.Text = String.Empty;
                txtRcptnPymtRcvd.Text = String.Empty;
            }
            else if (txtRcptnPymtRcvd.Text == "")
            {
                MessageBox.Show("Please enter paid amount!");
            }
            else if (double.TryParse(txtRcptnPymtRcvd.Text, out paid_amount))
            {
                ser_fee = int.Parse(lblRcptnPymtSerFeeSh.Text);
                paid_amount = double.Parse(txtRcptnPymtRcvd.Text);

                Receptionist_Cust bal = new Receptionist_Cust();
                balance = bal.calBal(ser_fee, paid_amount);

                if (balance < 0)
                {
                    MessageBox.Show("Please pay at least the amount of the service fee!");
                }
                else
                {
                    Receptionist_Cust cust_pymt = new Receptionist_Cust(cboRcptnPymtCustUsnm.SelectedItem.ToString());
                    MessageBox.Show(cust_pymt.addPaidAmount(txtRcptnPymtRcvd.Text));

                    btnRcptnPymtClear.Enabled = false;
                    btnRcptnPymtBack.Enabled = false;
                    cboRcptnPymtCustUsnm.Enabled = false;
                    txtRcptnPymtRcvd.Enabled = false;
                    btnRcptnPymtAcc.Enabled = false;
                    btnRcptnPymtGenRcpt.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter correct format for paid amount!");
            }
        }

        private void btnRcptnPymtGenRcpt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArrayList rec_info = new ArrayList();
            rec_info.Add(cboRcptnPymtCustUsnm.SelectedItem.ToString());
            rec_info.Add(txtRcptnPymtRcvd.Text);
            rec_info.Add(lblRcptnPymtSerSh.Text);
            rec_info.Add(lblRcptnPymtSerFeeSh.Text);
            rec_info.Add(balance.ToString());
            rec_info.Add(rec_no);
            rec_info.Add(collect_date);
            rec_info.Add(name);

            frmRcptnOfflRec or = new frmRcptnOfflRec(rec_info);
            or.ShowDialog();
            btnRcptnPymtClear.Enabled = true;
            btnRcptnPymtBack.Enabled = true;
            cboRcptnPymtCustUsnm.Enabled = true;
            txtRcptnPymtRcvd.Enabled = true;
            btnRcptnPymtAcc.Enabled = true;
            btnRcptnPymtGenRcpt.Enabled = false;
            cboRcptnPymtCustUsnm.Text = "Customer Username";
            lblRcptnPymtSerSh.Text = String.Empty;
            lblRcptnPymtSerFeeSh.Text = String.Empty;
            txtRcptnPymtRcvd.Text = String.Empty;
            this.Show();
        }

        private void btnRcptnPymtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
