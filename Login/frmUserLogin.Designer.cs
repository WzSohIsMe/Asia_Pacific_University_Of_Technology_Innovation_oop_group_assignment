namespace Group_35_Assignment
{
    partial class frmUserLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogin));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogLogo = new System.Windows.Forms.PictureBox();
            this.lblLogPwdTag = new System.Windows.Forms.Label();
            this.lblLogUsnmTag = new System.Windows.Forms.Label();
            this.pnlLogTitle = new System.Windows.Forms.Panel();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.pnlLogInput = new System.Windows.Forms.Panel();
            this.btnLogExit = new System.Windows.Forms.Button();
            this.btnLogLogin = new System.Windows.Forms.Button();
            this.txtLogPwd = new System.Windows.Forms.TextBox();
            this.txtLogUsnm = new System.Windows.Forms.TextBox();
            this.pnlLogDes = new System.Windows.Forms.Panel();
            this.lblLogAdmin = new System.Windows.Forms.Label();
            this.lblLogCust = new System.Windows.Forms.Label();
            this.lblLogTechn = new System.Windows.Forms.Label();
            this.lblLogRcptn = new System.Windows.Forms.Label();
            this.lblLogRoleTitle = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).BeginInit();
            this.pnlLogTitle.SuspendLayout();
            this.pnlLogInput.SuspendLayout();
            this.pnlLogDes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.LightCyan;
            this.pnlLogo.Controls.Add(this.picLogLogo);
            this.pnlLogo.Controls.Add(this.lblLogPwdTag);
            this.pnlLogo.Controls.Add(this.lblLogUsnmTag);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(237, 561);
            this.pnlLogo.TabIndex = 0;
            // 
            // picLogLogo
            // 
            this.picLogLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogLogo.Image")));
            this.picLogLogo.Location = new System.Drawing.Point(30, 24);
            this.picLogLogo.Name = "picLogLogo";
            this.picLogLogo.Size = new System.Drawing.Size(174, 175);
            this.picLogLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogLogo.TabIndex = 3;
            this.picLogLogo.TabStop = false;
            // 
            // lblLogPwdTag
            // 
            this.lblLogPwdTag.AutoSize = true;
            this.lblLogPwdTag.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogPwdTag.Location = new System.Drawing.Point(60, 327);
            this.lblLogPwdTag.Name = "lblLogPwdTag";
            this.lblLogPwdTag.Size = new System.Drawing.Size(111, 29);
            this.lblLogPwdTag.TabIndex = 2;
            this.lblLogPwdTag.Text = "Password";
            // 
            // lblLogUsnmTag
            // 
            this.lblLogUsnmTag.AutoSize = true;
            this.lblLogUsnmTag.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogUsnmTag.Location = new System.Drawing.Point(60, 221);
            this.lblLogUsnmTag.Name = "lblLogUsnmTag";
            this.lblLogUsnmTag.Size = new System.Drawing.Size(117, 29);
            this.lblLogUsnmTag.TabIndex = 1;
            this.lblLogUsnmTag.Text = "Username";
            // 
            // pnlLogTitle
            // 
            this.pnlLogTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnlLogTitle.Controls.Add(this.lblLogTitle);
            this.pnlLogTitle.Location = new System.Drawing.Point(237, 0);
            this.pnlLogTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlLogTitle.Name = "pnlLogTitle";
            this.pnlLogTitle.Size = new System.Drawing.Size(547, 169);
            this.pnlLogTitle.TabIndex = 1;
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Calibri", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogTitle.ForeColor = System.Drawing.Color.White;
            this.lblLogTitle.Location = new System.Drawing.Point(22, 39);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(505, 94);
            this.lblLogTitle.TabIndex = 0;
            this.lblLogTitle.Text = "Laptop Repair \r\nServices Management System";
            // 
            // pnlLogInput
            // 
            this.pnlLogInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnlLogInput.Controls.Add(this.btnLogExit);
            this.pnlLogInput.Controls.Add(this.btnLogLogin);
            this.pnlLogInput.Controls.Add(this.txtLogPwd);
            this.pnlLogInput.Controls.Add(this.txtLogUsnm);
            this.pnlLogInput.Location = new System.Drawing.Point(237, 169);
            this.pnlLogInput.Name = "pnlLogInput";
            this.pnlLogInput.Size = new System.Drawing.Size(355, 392);
            this.pnlLogInput.TabIndex = 2;
            // 
            // btnLogExit
            // 
            this.btnLogExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnLogExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogExit.ForeColor = System.Drawing.Color.White;
            this.btnLogExit.Location = new System.Drawing.Point(117, 313);
            this.btnLogExit.Name = "btnLogExit";
            this.btnLogExit.Size = new System.Drawing.Size(105, 35);
            this.btnLogExit.TabIndex = 3;
            this.btnLogExit.Text = "Exit";
            this.btnLogExit.UseVisualStyleBackColor = false;
            this.btnLogExit.Click += new System.EventHandler(this.btnLogExit_Click);
            // 
            // btnLogLogin
            // 
            this.btnLogLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.btnLogLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogLogin.Location = new System.Drawing.Point(117, 242);
            this.btnLogLogin.Name = "btnLogLogin";
            this.btnLogLogin.Size = new System.Drawing.Size(105, 35);
            this.btnLogLogin.TabIndex = 2;
            this.btnLogLogin.Text = "Login";
            this.btnLogLogin.UseVisualStyleBackColor = false;
            this.btnLogLogin.Click += new System.EventHandler(this.btnLogLogin_Click);
            // 
            // txtLogPwd
            // 
            this.txtLogPwd.BackColor = System.Drawing.Color.Silver;
            this.txtLogPwd.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtLogPwd.Location = new System.Drawing.Point(67, 158);
            this.txtLogPwd.Name = "txtLogPwd";
            this.txtLogPwd.Size = new System.Drawing.Size(225, 33);
            this.txtLogPwd.TabIndex = 1;
            this.txtLogPwd.Text = "Enter Password";
            this.txtLogPwd.Enter += new System.EventHandler(this.txtLogPwd_Enter);
            this.txtLogPwd.Leave += new System.EventHandler(this.txtLogPwd_Leave);
            // 
            // txtLogUsnm
            // 
            this.txtLogUsnm.BackColor = System.Drawing.Color.Silver;
            this.txtLogUsnm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogUsnm.ForeColor = System.Drawing.Color.Gray;
            this.txtLogUsnm.Location = new System.Drawing.Point(67, 52);
            this.txtLogUsnm.Name = "txtLogUsnm";
            this.txtLogUsnm.Size = new System.Drawing.Size(225, 33);
            this.txtLogUsnm.TabIndex = 0;
            this.txtLogUsnm.Text = "Enter Username";
            this.txtLogUsnm.Enter += new System.EventHandler(this.txtLogUsnm_Enter);
            this.txtLogUsnm.Leave += new System.EventHandler(this.txtLogUsnm_Leave);
            // 
            // pnlLogDes
            // 
            this.pnlLogDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.pnlLogDes.Controls.Add(this.lblLogAdmin);
            this.pnlLogDes.Controls.Add(this.lblLogCust);
            this.pnlLogDes.Controls.Add(this.lblLogTechn);
            this.pnlLogDes.Controls.Add(this.lblLogRcptn);
            this.pnlLogDes.Controls.Add(this.lblLogRoleTitle);
            this.pnlLogDes.ForeColor = System.Drawing.Color.Black;
            this.pnlLogDes.Location = new System.Drawing.Point(591, 169);
            this.pnlLogDes.Name = "pnlLogDes";
            this.pnlLogDes.Size = new System.Drawing.Size(193, 392);
            this.pnlLogDes.TabIndex = 3;
            // 
            // lblLogAdmin
            // 
            this.lblLogAdmin.AutoSize = true;
            this.lblLogAdmin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogAdmin.ForeColor = System.Drawing.Color.White;
            this.lblLogAdmin.Location = new System.Drawing.Point(35, 251);
            this.lblLogAdmin.Name = "lblLogAdmin";
            this.lblLogAdmin.Size = new System.Drawing.Size(80, 26);
            this.lblLogAdmin.TabIndex = 1;
            this.lblLogAdmin.Text = "· Admin";
            // 
            // lblLogCust
            // 
            this.lblLogCust.AutoSize = true;
            this.lblLogCust.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogCust.ForeColor = System.Drawing.Color.White;
            this.lblLogCust.Location = new System.Drawing.Point(35, 206);
            this.lblLogCust.Name = "lblLogCust";
            this.lblLogCust.Size = new System.Drawing.Size(106, 26);
            this.lblLogCust.TabIndex = 1;
            this.lblLogCust.Text = "· Customer";
            // 
            // lblLogTechn
            // 
            this.lblLogTechn.AutoSize = true;
            this.lblLogTechn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogTechn.ForeColor = System.Drawing.Color.White;
            this.lblLogTechn.Location = new System.Drawing.Point(35, 161);
            this.lblLogTechn.Name = "lblLogTechn";
            this.lblLogTechn.Size = new System.Drawing.Size(113, 26);
            this.lblLogTechn.TabIndex = 1;
            this.lblLogTechn.Text = "· Technician";
            // 
            // lblLogRcptn
            // 
            this.lblLogRcptn.AutoSize = true;
            this.lblLogRcptn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogRcptn.ForeColor = System.Drawing.Color.White;
            this.lblLogRcptn.Location = new System.Drawing.Point(35, 113);
            this.lblLogRcptn.Name = "lblLogRcptn";
            this.lblLogRcptn.Size = new System.Drawing.Size(131, 26);
            this.lblLogRcptn.TabIndex = 1;
            this.lblLogRcptn.Text = "· Receptionist";
            // 
            // lblLogRoleTitle
            // 
            this.lblLogRoleTitle.AutoSize = true;
            this.lblLogRoleTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogRoleTitle.ForeColor = System.Drawing.Color.White;
            this.lblLogRoleTitle.Location = new System.Drawing.Point(35, 52);
            this.lblLogRoleTitle.Name = "lblLogRoleTitle";
            this.lblLogRoleTitle.Size = new System.Drawing.Size(127, 29);
            this.lblLogRoleTitle.TabIndex = 0;
            this.lblLogRoleTitle.Text = "User Roles:";
            // 
            // frmUserLogin
            // 
            this.AcceptButton = this.btnLogLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlLogInput);
            this.Controls.Add(this.pnlLogDes);
            this.Controls.Add(this.pnlLogTitle);
            this.Controls.Add(this.pnlLogo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmUserLogin";
            this.Text = "Laptop Repair Services Management System";
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).EndInit();
            this.pnlLogTitle.ResumeLayout(false);
            this.pnlLogTitle.PerformLayout();
            this.pnlLogInput.ResumeLayout(false);
            this.pnlLogInput.PerformLayout();
            this.pnlLogDes.ResumeLayout(false);
            this.pnlLogDes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLogo;
        private Panel pnlLogTitle;
        private Label lblLogPwdTag;
        private Label lblLogUsnmTag;
        private Label lblLogTitle;
        private Panel pnlLogInput;
        private Button btnLogLogin;
        private TextBox txtLogPwd;
        private TextBox txtLogUsnm;
        private Panel pnlLogDes;
        private Label lblLogAdmin;
        private Label lblLogCust;
        private Label lblLogTechn;
        private Label lblLogRcptn;
        private Label lblLogRoleTitle;
        private Button btnLogExit;
        private PictureBox picLogLogo;
    }
}