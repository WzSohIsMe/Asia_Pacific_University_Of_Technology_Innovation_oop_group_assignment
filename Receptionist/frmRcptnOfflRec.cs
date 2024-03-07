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
    public partial class frmRcptnOfflRec : Form
    {
        public static ArrayList rec_info;

        public frmRcptnOfflRec()
        {
            InitializeComponent();
        }

        public frmRcptnOfflRec(ArrayList ri)
        {
            InitializeComponent();
            rec_info = ri;
        }

        private void frmRcptnOfflRec_Load(object sender, EventArgs e)
        {
            lblRcptnRecCustUsnm.Text = rec_info[0].ToString();
            lblRcptnRecAmtRcvd.Text = "RM " + rec_info[1].ToString();
            lblRcptnRecSerType.Text = rec_info[2].ToString();
            lblRcptnRecSerFee.Text = "RM " + rec_info[3].ToString();
            lblRcptnRecBalDue.Text = "RM " + rec_info[4].ToString();
            lblRcptnRecNo.Text = rec_info[5].ToString();
            lblRcptnRecDate.Text = rec_info[6].ToString();
            lblRcptnRecRcptnUsnm.Text = rec_info[7].ToString();
        }

        private void lblRcptnRecBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
