namespace Group_35_Assignment
{
    partial class frmAdminIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblServ1 = new System.Windows.Forms.Label();
            this.lblServ2 = new System.Windows.Forms.Label();
            this.lblServ3 = new System.Windows.Forms.Label();
            this.lblServ4 = new System.Windows.Forms.Label();
            this.lblServ5 = new System.Windows.Forms.Label();
            this.lblServ6 = new System.Windows.Forms.Label();
            this.lblServ7 = new System.Windows.Forms.Label();
            this.lblServ8 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblServ1Count = new System.Windows.Forms.Label();
            this.lblServ2Count = new System.Windows.Forms.Label();
            this.lblServ3Count = new System.Windows.Forms.Label();
            this.lblServ4Count = new System.Windows.Forms.Label();
            this.lblServ5Count = new System.Windows.Forms.Label();
            this.lblServ6Count = new System.Windows.Forms.Label();
            this.lblServ7Count = new System.Windows.Forms.Label();
            this.lblServ8Count = new System.Windows.Forms.Label();
            this.lblServ8Sum = new System.Windows.Forms.Label();
            this.lblServ7Sum = new System.Windows.Forms.Label();
            this.lblServ6Sum = new System.Windows.Forms.Label();
            this.lblServ5Sum = new System.Windows.Forms.Label();
            this.lblServ4Sum = new System.Windows.Forms.Label();
            this.lblServ3Sum = new System.Windows.Forms.Label();
            this.lblServ2Sum = new System.Windows.Forms.Label();
            this.lblServ1Sum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 121);
            this.panel1.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(785, 13);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 23);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(44, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(448, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Total Service Income Report";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(14, 564);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(166, 46);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Back to Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIncome.Location = new System.Drawing.Point(559, 572);
            this.lblTotalIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(127, 26);
            this.lblTotalIncome.TabIndex = 9;
            this.lblTotalIncome.Text = "Total Income:";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncome.Location = new System.Drawing.Point(714, 572);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncome.MinimumSize = new System.Drawing.Size(175, 35);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(175, 35);
            this.lblIncome.TabIndex = 10;
            this.lblIncome.Text = "XXXXXX";
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboMonth.Location = new System.Drawing.Point(241, 572);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(140, 23);
            this.cboMonth.TabIndex = 11;
            this.cboMonth.Text = "Select Month";
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // lblServ1
            // 
            this.lblServ1.AutoSize = true;
            this.lblServ1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ1.Location = new System.Drawing.Point(82, 213);
            this.lblServ1.Name = "lblServ1";
            this.lblServ1.Size = new System.Drawing.Size(235, 19);
            this.lblServ1.TabIndex = 12;
            this.lblServ1.Text = "Remove virus, malware or spyware";
            // 
            // lblServ2
            // 
            this.lblServ2.AutoSize = true;
            this.lblServ2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ2.Location = new System.Drawing.Point(82, 249);
            this.lblServ2.Name = "lblServ2";
            this.lblServ2.Size = new System.Drawing.Size(284, 19);
            this.lblServ2.TabIndex = 13;
            this.lblServ2.Text = "Troubleshot and fix computer running slow";
            // 
            // lblServ3
            // 
            this.lblServ3.AutoSize = true;
            this.lblServ3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ3.Location = new System.Drawing.Point(82, 289);
            this.lblServ3.Name = "lblServ3";
            this.lblServ3.Size = new System.Drawing.Size(185, 19);
            this.lblServ3.TabIndex = 14;
            this.lblServ3.Text = "Laptop screen replacement";
            // 
            // lblServ4
            // 
            this.lblServ4.AutoSize = true;
            this.lblServ4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ4.Location = new System.Drawing.Point(82, 332);
            this.lblServ4.Name = "lblServ4";
            this.lblServ4.Size = new System.Drawing.Size(204, 19);
            this.lblServ4.TabIndex = 15;
            this.lblServ4.Text = "Laptop keyboard replacement ";
            // 
            // lblServ5
            // 
            this.lblServ5.AutoSize = true;
            this.lblServ5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ5.Location = new System.Drawing.Point(82, 373);
            this.lblServ5.Name = "lblServ5";
            this.lblServ5.Size = new System.Drawing.Size(192, 19);
            this.lblServ5.TabIndex = 16;
            this.lblServ5.Text = "Laptop battery replacement ";
            // 
            // lblServ6
            // 
            this.lblServ6.AutoSize = true;
            this.lblServ6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ6.Location = new System.Drawing.Point(82, 414);
            this.lblServ6.Name = "lblServ6";
            this.lblServ6.Size = new System.Drawing.Size(278, 19);
            this.lblServ6.TabIndex = 17;
            this.lblServ6.Text = "Operating System Format and Installation";
            // 
            // lblServ7
            // 
            this.lblServ7.AutoSize = true;
            this.lblServ7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ7.Location = new System.Drawing.Point(82, 458);
            this.lblServ7.Name = "lblServ7";
            this.lblServ7.Size = new System.Drawing.Size(177, 19);
            this.lblServ7.TabIndex = 18;
            this.lblServ7.Text = "Data backup and recovery";
            // 
            // lblServ8
            // 
            this.lblServ8.AutoSize = true;
            this.lblServ8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ8.Location = new System.Drawing.Point(82, 503);
            this.lblServ8.Name = "lblServ8";
            this.lblServ8.Size = new System.Drawing.Size(191, 19);
            this.lblServ8.TabIndex = 19;
            this.lblServ8.Text = "Internet connectivity issues ";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblService.Location = new System.Drawing.Point(82, 158);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(136, 29);
            this.lblService.TabIndex = 20;
            this.lblService.Text = "Service Type";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(570, 158);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(73, 29);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(725, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Amount (RM)";
            // 
            // lblServ1Count
            // 
            this.lblServ1Count.AutoSize = true;
            this.lblServ1Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ1Count.Location = new System.Drawing.Point(595, 213);
            this.lblServ1Count.Name = "lblServ1Count";
            this.lblServ1Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ1Count.TabIndex = 23;
            this.lblServ1Count.Text = "0";
            // 
            // lblServ2Count
            // 
            this.lblServ2Count.AutoSize = true;
            this.lblServ2Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ2Count.Location = new System.Drawing.Point(595, 249);
            this.lblServ2Count.Name = "lblServ2Count";
            this.lblServ2Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ2Count.TabIndex = 24;
            this.lblServ2Count.Text = "0";
            // 
            // lblServ3Count
            // 
            this.lblServ3Count.AutoSize = true;
            this.lblServ3Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ3Count.Location = new System.Drawing.Point(595, 289);
            this.lblServ3Count.Name = "lblServ3Count";
            this.lblServ3Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ3Count.TabIndex = 25;
            this.lblServ3Count.Text = "0";
            // 
            // lblServ4Count
            // 
            this.lblServ4Count.AutoSize = true;
            this.lblServ4Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ4Count.Location = new System.Drawing.Point(595, 332);
            this.lblServ4Count.Name = "lblServ4Count";
            this.lblServ4Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ4Count.TabIndex = 26;
            this.lblServ4Count.Text = "0";
            // 
            // lblServ5Count
            // 
            this.lblServ5Count.AutoSize = true;
            this.lblServ5Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ5Count.Location = new System.Drawing.Point(595, 373);
            this.lblServ5Count.Name = "lblServ5Count";
            this.lblServ5Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ5Count.TabIndex = 27;
            this.lblServ5Count.Text = "0";
            // 
            // lblServ6Count
            // 
            this.lblServ6Count.AutoSize = true;
            this.lblServ6Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ6Count.Location = new System.Drawing.Point(595, 414);
            this.lblServ6Count.Name = "lblServ6Count";
            this.lblServ6Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ6Count.TabIndex = 28;
            this.lblServ6Count.Text = "0";
            // 
            // lblServ7Count
            // 
            this.lblServ7Count.AutoSize = true;
            this.lblServ7Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ7Count.Location = new System.Drawing.Point(595, 458);
            this.lblServ7Count.Name = "lblServ7Count";
            this.lblServ7Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ7Count.TabIndex = 29;
            this.lblServ7Count.Text = "0";
            // 
            // lblServ8Count
            // 
            this.lblServ8Count.AutoSize = true;
            this.lblServ8Count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ8Count.Location = new System.Drawing.Point(595, 503);
            this.lblServ8Count.Name = "lblServ8Count";
            this.lblServ8Count.Size = new System.Drawing.Size(17, 19);
            this.lblServ8Count.TabIndex = 30;
            this.lblServ8Count.Text = "0";
            // 
            // lblServ8Sum
            // 
            this.lblServ8Sum.AutoSize = true;
            this.lblServ8Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ8Sum.Location = new System.Drawing.Point(785, 503);
            this.lblServ8Sum.Name = "lblServ8Sum";
            this.lblServ8Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ8Sum.TabIndex = 38;
            this.lblServ8Sum.Text = "0";
            // 
            // lblServ7Sum
            // 
            this.lblServ7Sum.AutoSize = true;
            this.lblServ7Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ7Sum.Location = new System.Drawing.Point(785, 458);
            this.lblServ7Sum.Name = "lblServ7Sum";
            this.lblServ7Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ7Sum.TabIndex = 37;
            this.lblServ7Sum.Text = "0";
            // 
            // lblServ6Sum
            // 
            this.lblServ6Sum.AutoSize = true;
            this.lblServ6Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ6Sum.Location = new System.Drawing.Point(785, 414);
            this.lblServ6Sum.Name = "lblServ6Sum";
            this.lblServ6Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ6Sum.TabIndex = 36;
            this.lblServ6Sum.Text = "0";
            // 
            // lblServ5Sum
            // 
            this.lblServ5Sum.AutoSize = true;
            this.lblServ5Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ5Sum.Location = new System.Drawing.Point(785, 373);
            this.lblServ5Sum.Name = "lblServ5Sum";
            this.lblServ5Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ5Sum.TabIndex = 35;
            this.lblServ5Sum.Text = "0";
            // 
            // lblServ4Sum
            // 
            this.lblServ4Sum.AutoSize = true;
            this.lblServ4Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ4Sum.Location = new System.Drawing.Point(785, 332);
            this.lblServ4Sum.Name = "lblServ4Sum";
            this.lblServ4Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ4Sum.TabIndex = 34;
            this.lblServ4Sum.Text = "0";
            // 
            // lblServ3Sum
            // 
            this.lblServ3Sum.AutoSize = true;
            this.lblServ3Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ3Sum.Location = new System.Drawing.Point(785, 289);
            this.lblServ3Sum.Name = "lblServ3Sum";
            this.lblServ3Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ3Sum.TabIndex = 33;
            this.lblServ3Sum.Text = "0";
            // 
            // lblServ2Sum
            // 
            this.lblServ2Sum.AutoSize = true;
            this.lblServ2Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ2Sum.Location = new System.Drawing.Point(785, 249);
            this.lblServ2Sum.Name = "lblServ2Sum";
            this.lblServ2Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ2Sum.TabIndex = 32;
            this.lblServ2Sum.Text = "0";
            // 
            // lblServ1Sum
            // 
            this.lblServ1Sum.AutoSize = true;
            this.lblServ1Sum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServ1Sum.Location = new System.Drawing.Point(785, 213);
            this.lblServ1Sum.Name = "lblServ1Sum";
            this.lblServ1Sum.Size = new System.Drawing.Size(17, 19);
            this.lblServ1Sum.TabIndex = 31;
            this.lblServ1Sum.Text = "0";
            // 
            // frmAdminIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 623);
            this.Controls.Add(this.lblServ8Sum);
            this.Controls.Add(this.lblServ7Sum);
            this.Controls.Add(this.lblServ6Sum);
            this.Controls.Add(this.lblServ5Sum);
            this.Controls.Add(this.lblServ4Sum);
            this.Controls.Add(this.lblServ3Sum);
            this.Controls.Add(this.lblServ2Sum);
            this.Controls.Add(this.lblServ1Sum);
            this.Controls.Add(this.lblServ8Count);
            this.Controls.Add(this.lblServ7Count);
            this.Controls.Add(this.lblServ6Count);
            this.Controls.Add(this.lblServ5Count);
            this.Controls.Add(this.lblServ4Count);
            this.Controls.Add(this.lblServ3Count);
            this.Controls.Add(this.lblServ2Count);
            this.Controls.Add(this.lblServ1Count);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblServ8);
            this.Controls.Add(this.lblServ7);
            this.Controls.Add(this.lblServ6);
            this.Controls.Add(this.lblServ5);
            this.Controls.Add(this.lblServ4);
            this.Controls.Add(this.lblServ3);
            this.Controls.Add(this.lblServ2);
            this.Controls.Add(this.lblServ1);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAdminIncome";
            this.Text = "Admin Income Report";
            this.Load += new System.EventHandler(this.frmAdminIncome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.ComboBox cboMonth;
        private Label lblServ1;
        private Label lblServ2;
        private Label lblServ3;
        private Label lblServ4;
        private Label lblServ5;
        private Label lblServ6;
        private Label lblServ7;
        private Label lblServ8;
        private Label lblService;
        private Label lblCount;
        private Label label11;
        private Label lblServ1Count;
        private Label lblServ2Count;
        private Label lblServ3Count;
        private Label lblServ4Count;
        private Label lblServ5Count;
        private Label lblServ6Count;
        private Label lblServ7Count;
        private Label lblServ8Count;
        private Label lblServ8Sum;
        private Label lblServ7Sum;
        private Label lblServ6Sum;
        private Label lblServ5Sum;
        private Label lblServ4Sum;
        private Label lblServ3Sum;
        private Label lblServ2Sum;
        private Label lblServ1Sum;
    }
}