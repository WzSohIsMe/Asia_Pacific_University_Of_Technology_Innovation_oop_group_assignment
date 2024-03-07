using System.Collections;

namespace Group_35_Assignment
{
    public partial class frmRcptnPage : Form
    {
        public static string name;

        public frmRcptnPage(string n)
        {
            InitializeComponent();
            name = n;
        }

        public frmRcptnPage()
        {
            InitializeComponent();
        }

        private void frmRcptnPage_Load(object sender, EventArgs e)
        {
            lblRcptnDetsUsnmSh.Text = name;

            cboRcptnCustUsnm.DataSource = Receptionist_Cust.addCustCbo();
            cboRcptnCustUsnm.Text = "Customer Username";
        }

        private void btnRcptnRegCust_Click(object sender, EventArgs e)
        {
            Receptionist_Cust cust1 = new Receptionist_Cust(txtRcptnRegCustUsnm.Text, txtRcptnRegCustPwd.Text);
            MessageBox.Show(cust1.addCust());
            
            txtRcptnRegCustUsnm.ForeColor = Color.Gray;
            txtRcptnRegCustPwd.ForeColor = Color.Gray;
            txtRcptnRegCustUsnm.Text = "Username";
            txtRcptnRegCustPwd.PasswordChar = '\0';
            txtRcptnRegCustPwd.Text = "Password";
            chkRcptnShPwd.Checked = false;

            cboRcptnCustUsnm.DataSource = Receptionist_Cust.addCustCbo();
            cboRcptnCustUsnm.Text = "Customer Username";
        }

        private void txtRcptnRegCustUsnm_Enter(object sender, EventArgs e)
        {
            if (txtRcptnRegCustUsnm.Text == "Username")
            {
                txtRcptnRegCustUsnm.Text = "";

                txtRcptnRegCustUsnm.ForeColor = Color.Black;
            }
        }

        private void txtRcptnRegCustUsnm_Leave(object sender, EventArgs e)
        {
            if (txtRcptnRegCustUsnm.Text == "")
            {
                txtRcptnRegCustUsnm.Text = "Username";

                txtRcptnRegCustUsnm.ForeColor = Color.Gray;
            }
        }

        private void txtRcptnRegCustPwd_Enter(object sender, EventArgs e)
        {
            if (txtRcptnRegCustPwd.Text == "Password")
            {
                txtRcptnRegCustPwd.Text = "";

                txtRcptnRegCustPwd.ForeColor = Color.Black;

                if (chkRcptnShPwd.Checked == true)
                {
                    txtRcptnRegCustPwd.PasswordChar = '\0';
                }
                else
                {
                    txtRcptnRegCustPwd.PasswordChar = '•';
                }
            }
        }

        private void txtRcptnRegCustPwd_Leave(object sender, EventArgs e)
        {
            if (txtRcptnRegCustPwd.Text == "")
            {
                txtRcptnRegCustPwd.PasswordChar = '\0';

                txtRcptnRegCustPwd.Text = "Password";

                txtRcptnRegCustPwd.ForeColor = Color.Gray;
            }
        }

        private void chkRcptnShPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRcptnShPwd.Checked == true)
            {
                txtRcptnRegCustPwd.PasswordChar = '\0';
            }
            else
            {
                if (txtRcptnRegCustPwd.Text == "Password")
                {
                    txtRcptnRegCustPwd.PasswordChar = '\0';
                }
                else
                {
                    txtRcptnRegCustPwd.PasswordChar = '•';
                }
            }
        }

        private void radRcptnNormSer_CheckedChanged(object sender, EventArgs e)
        {
            string urgency = radRcptnNormSer.Text;
            int price;
            int index = cboRcptnSerType.SelectedIndex;

            if (cboRcptnSerType.Text != "Service Type")
            {
                Receptionist_Cust ser_price1 = new Receptionist_Cust(index, urgency);

                price = ser_price1.showPrice();

                lblRcptnSerFeeSh.Text = "RM " + price.ToString();
                }
            }

        private void radRcptnUrgSer_CheckedChanged(object sender, EventArgs e)
        {
            string urgency = radRcptnUrgSer.Text;
            int price;
            int index = cboRcptnSerType.SelectedIndex;

            if (cboRcptnSerType.Text != "Service Type")
            {
                Receptionist_Cust ser_price2 = new Receptionist_Cust(index, urgency);

                price = ser_price2.showPrice();

                lblRcptnSerFeeSh.Text = "RM " + price.ToString();
            }
        }

        private void cboRcptnSerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            radRcptnNormSer.Checked = false;
            radRcptnUrgSer.Checked = false;
            lblRcptnSerFeeSh.Text = String.Empty;
        }

        private void cboRcptnCustUsnm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboRcptnSerType.Text = "Service Type";
            radRcptnNormSer.Checked = false;
            radRcptnUrgSer.Checked = false;
            lblRcptnSerFeeSh.Text = String.Empty;
        }

        private void btnRcptnCreCust_Click(object sender, EventArgs e)
        {
            string urgency = null;
            int serFee;

            if (cboRcptnCustUsnm.Text == "Customer Username" || cboRcptnSerType.Text == "Service Type" || (radRcptnNormSer.Checked == false && radRcptnUrgSer.Checked == false) || cboRcptnCustUsnm.SelectedIndex < 0 || cboRcptnSerType.SelectedIndex < 0)
            {
                cboRcptnCustUsnm.Text = "Customer Username";
                cboRcptnSerType.Text = "Service Type";
                radRcptnNormSer.Checked = false;
                radRcptnUrgSer.Checked = false;
                lblRcptnSerFeeSh.Text = String.Empty;
                MessageBox.Show("Please fill in all required details to request a service");
            }
            else
            {
                string[] price = lblRcptnSerFeeSh.Text.Split(" ");
                serFee = int.Parse(price[1]);

                if (radRcptnNormSer.Checked == true)
                {
                    urgency = radRcptnNormSer.Text;
                }
                else if (radRcptnUrgSer.Checked == true)
                {
                    urgency = radRcptnUrgSer.Text;
                }

                Receptionist_Cust ser = new Receptionist_Cust(cboRcptnCustUsnm.Text, cboRcptnSerType.Text, urgency, serFee);

                MessageBox.Show(ser.addService());

                cboRcptnCustUsnm.Text = "Customer Username";
                cboRcptnSerType.Text = "Service Type";
                radRcptnNormSer.Checked = false;
                radRcptnUrgSer.Checked = false;
                lblRcptnSerFeeSh.Text = String.Empty;
            }
        }

        private void btnRcptnClear_Click(object sender, EventArgs e)
        {
            cboRcptnCustUsnm.Text = "Customer Username";
            cboRcptnSerType.Text = "Service Type";
            radRcptnNormSer.Checked = false;
            radRcptnUrgSer.Checked = false;
            lblRcptnSerFeeSh.Text = String.Empty;
        }

        private void btnRcptnPymtPg_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRcptnPymtPage p = new frmRcptnPymtPage(name);
            p.ShowDialog();

            this.Show();
        }

        private void btnRcptnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRcptnEditPrf_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRcptnEditPrf ep = new frmRcptnEditPrf(name);
            ep.ShowDialog();

            this.Show();
        }
    }
}