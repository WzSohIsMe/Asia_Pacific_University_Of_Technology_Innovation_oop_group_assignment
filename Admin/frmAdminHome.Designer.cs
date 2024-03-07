namespace Group_35_Assignment
{
    partial class frmAdminHome
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIncome = new System.Windows.Forms.Button();
            this.lblViewReport = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gboxAccType = new System.Windows.Forms.GroupBox();
            this.rdbTechnician = new System.Windows.Forms.RadioButton();
            this.rdbReceptionist = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gboxAccType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 121);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(610, 77);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 30);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(610, 40);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(112, 30);
            this.btnEditProfile.TabIndex = 15;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(609, 10);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 23);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(44, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Page";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(334, 248);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(167, 31);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(334, 318);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblRegUser
            // 
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegUser.Location = new System.Drawing.Point(421, 162);
            this.lblRegUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(174, 26);
            this.lblRegUser.TabIndex = 3;
            this.lblRegUser.Text = "Register New User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(157)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.btnIncome);
            this.panel2.Controls.Add(this.lblViewReport);
            this.panel2.Location = new System.Drawing.Point(-4, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 375);
            this.panel2.TabIndex = 4;
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Location = new System.Drawing.Point(53, 128);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(172, 101);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Total Service Income Report";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // lblViewReport
            // 
            this.lblViewReport.AutoSize = true;
            this.lblViewReport.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblViewReport.ForeColor = System.Drawing.Color.White;
            this.lblViewReport.Location = new System.Drawing.Point(79, 82);
            this.lblViewReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewReport.Name = "lblViewReport";
            this.lblViewReport.Size = new System.Drawing.Size(128, 26);
            this.lblViewReport.TabIndex = 0;
            this.lblViewReport.Text = "View Reports";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(443, 398);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(126, 46);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gboxAccType
            // 
            this.gboxAccType.Controls.Add(this.rdbTechnician);
            this.gboxAccType.Controls.Add(this.rdbReceptionist);
            this.gboxAccType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxAccType.Location = new System.Drawing.Point(538, 222);
            this.gboxAccType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxAccType.Name = "gboxAccType";
            this.gboxAccType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxAccType.Size = new System.Drawing.Size(156, 139);
            this.gboxAccType.TabIndex = 6;
            this.gboxAccType.TabStop = false;
            this.gboxAccType.Text = "Account Type";
            // 
            // rdbTechnician
            // 
            this.rdbTechnician.AutoSize = true;
            this.rdbTechnician.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbTechnician.Location = new System.Drawing.Point(17, 93);
            this.rdbTechnician.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbTechnician.Name = "rdbTechnician";
            this.rdbTechnician.Size = new System.Drawing.Size(96, 23);
            this.rdbTechnician.TabIndex = 2;
            this.rdbTechnician.TabStop = true;
            this.rdbTechnician.Text = "Technician";
            this.rdbTechnician.UseVisualStyleBackColor = true;
            // 
            // rdbReceptionist
            // 
            this.rdbReceptionist.AutoSize = true;
            this.rdbReceptionist.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbReceptionist.Location = new System.Drawing.Point(17, 43);
            this.rdbReceptionist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbReceptionist.Name = "rdbReceptionist";
            this.rdbReceptionist.Size = new System.Drawing.Size(108, 23);
            this.rdbReceptionist.TabIndex = 1;
            this.rdbReceptionist.TabStop = true;
            this.rdbReceptionist.Text = "Receptionist";
            this.rdbReceptionist.UseVisualStyleBackColor = true;
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 492);
            this.Controls.Add(this.gboxAccType);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblRegUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAdminHome";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.frmAdminHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gboxAccType.ResumeLayout(false);
            this.gboxAccType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Label lblViewReport;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gboxAccType;
        private System.Windows.Forms.RadioButton rdbTechnician;
        private System.Windows.Forms.RadioButton rdbReceptionist;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label lblUsername;
    }
}

