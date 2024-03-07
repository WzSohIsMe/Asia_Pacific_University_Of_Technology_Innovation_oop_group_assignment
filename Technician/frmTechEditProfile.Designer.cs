
namespace Group_35_Assignment
{
    partial class frmTechEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechEditProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbTechEditProfile = new System.Windows.Forms.PictureBox();
            this.txtTechUsername = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnTechApply = new System.Windows.Forms.Button();
            this.btnTechBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTechEditProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Profile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 123);
            this.panel1.TabIndex = 1;
            // 
            // pcbTechEditProfile
            // 
            this.pcbTechEditProfile.Image = ((System.Drawing.Image)(resources.GetObject("pcbTechEditProfile.Image")));
            this.pcbTechEditProfile.Location = new System.Drawing.Point(149, 120);
            this.pcbTechEditProfile.Name = "pcbTechEditProfile";
            this.pcbTechEditProfile.Size = new System.Drawing.Size(100, 50);
            this.pcbTechEditProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTechEditProfile.TabIndex = 2;
            this.pcbTechEditProfile.TabStop = false;
            // 
            // txtTechUsername
            // 
            this.txtTechUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTechUsername.Location = new System.Drawing.Point(84, 197);
            this.txtTechUsername.Name = "txtTechUsername";
            this.txtTechUsername.ReadOnly = true;
            this.txtTechUsername.Size = new System.Drawing.Size(248, 33);
            this.txtTechUsername.TabIndex = 0;
            this.txtTechUsername.Text = "Username (unmodifiable)";

            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNewUsername.Location = new System.Drawing.Point(84, 258);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(248, 33);
            this.txtNewUsername.TabIndex = 1;
            this.txtNewUsername.Text = "Enter New Username";
      
            this.txtNewUsername.Enter += new System.EventHandler(this.txtCurrentName_Enter);
            this.txtNewUsername.Leave += new System.EventHandler(this.txtCurrentName_Leave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNewPassword.Location = new System.Drawing.Point(84, 328);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(248, 33);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.Text = "Enter New Password";
            
            this.txtNewPassword.Enter += new System.EventHandler(this.txtNewPassword_Enter);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // btnTechApply
            // 
            this.btnTechApply.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTechApply.FlatAppearance.BorderSize = 0;
            this.btnTechApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechApply.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechApply.ForeColor = System.Drawing.Color.Azure;
            this.btnTechApply.Location = new System.Drawing.Point(-1, 582);
            this.btnTechApply.Name = "btnTechApply";
            this.btnTechApply.Size = new System.Drawing.Size(78, 40);
            this.btnTechApply.TabIndex = 3;
            this.btnTechApply.Text = "Apply";
            this.btnTechApply.UseVisualStyleBackColor = false;
            this.btnTechApply.Click += new System.EventHandler(this.btnTechApply_Click);
            // 
            // btnTechBack
            // 
            this.btnTechBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTechBack.FlatAppearance.BorderSize = 0;
            this.btnTechBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechBack.ForeColor = System.Drawing.Color.Azure;
            this.btnTechBack.Location = new System.Drawing.Point(348, 582);
            this.btnTechBack.Name = "btnTechBack";
            this.btnTechBack.Size = new System.Drawing.Size(78, 40);
            this.btnTechBack.TabIndex = 4;
            this.btnTechBack.Text = "Back";
            this.btnTechBack.UseVisualStyleBackColor = false;
            this.btnTechBack.Click += new System.EventHandler(this.btnTechBack_Click);
            // 
            // frmTechEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(424, 621);
            this.Controls.Add(this.btnTechBack);
            this.Controls.Add(this.btnTechApply);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.txtTechUsername);
            this.Controls.Add(this.pcbTechEditProfile);
            this.Controls.Add(this.panel1);
            this.Name = "frmTechEditProfile";
            this.Text = "Technician - EditProfile";
            this.Load += new System.EventHandler(this.frmTechEditProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTechEditProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbTechEditProfile;
        private System.Windows.Forms.TextBox txtTechUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnTechApply;
        private System.Windows.Forms.Button btnTechBack;
    }
}