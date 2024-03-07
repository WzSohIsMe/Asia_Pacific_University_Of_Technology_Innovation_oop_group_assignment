namespace Group_35_Assignment
{
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            string stat;
            User_Login obj1 = new User_Login(txtLogUsnm.Text, txtLogPwd.Text);
            stat = obj1.login(txtLogUsnm.Text, txtLogPwd.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }

            txtLogUsnm.ForeColor = Color.Gray;
            txtLogPwd.ForeColor = Color.Gray;
            txtLogUsnm.Text = "Enter Username";
            txtLogPwd.PasswordChar = '\0';
            txtLogPwd.Text = "Enter Password";
            this.Show();
        }

        private void btnLogExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLogUsnm_Enter(object sender, EventArgs e)
        {
            if(txtLogUsnm.Text == "Enter Username")
            {
                txtLogUsnm.Text = "";

                txtLogUsnm.ForeColor = Color.Black;
            }
        }

        private void txtLogUsnm_Leave(object sender, EventArgs e)
        {
            if (txtLogUsnm.Text == "")
            {
                txtLogUsnm.Text = "Enter Username";

                txtLogUsnm.ForeColor = Color.Gray;
            }
        }

        private void txtLogPwd_Enter(object sender, EventArgs e)
        {
            if (txtLogPwd.Text == "Enter Password")
            {
                txtLogPwd.PasswordChar = '•';

                txtLogPwd.Text = "";

                txtLogPwd.ForeColor = Color.Black;
            }
        }

        private void txtLogPwd_Leave(object sender, EventArgs e)
        {
            if (txtLogPwd.Text == "")
            {
                txtLogPwd.PasswordChar = '\0';

                txtLogPwd.Text = "Enter Password";

                txtLogPwd.ForeColor = Color.Gray;
            }
        }
    }
}