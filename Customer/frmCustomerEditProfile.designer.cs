
namespace Group_35_Assignment
{
    partial class frmCustEditProfile
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
            this.pnlEditProfile = new System.Windows.Forms.Panel();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.txtCurrentPw = new System.Windows.Forms.TextBox();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtRePw = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlEditProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditProfile
            // 
            this.pnlEditProfile.BackColor = System.Drawing.Color.Teal;
            this.pnlEditProfile.Controls.Add(this.lblEditProfile);
            this.pnlEditProfile.Location = new System.Drawing.Point(1, 1);
            this.pnlEditProfile.Name = "pnlEditProfile";
            this.pnlEditProfile.Size = new System.Drawing.Size(803, 96);
            this.pnlEditProfile.TabIndex = 1;
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditProfile.Location = new System.Drawing.Point(28, 23);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(168, 40);
            this.lblEditProfile.TabIndex = 0;
            this.lblEditProfile.Text = "Edit Profile";
            // 
            // txtCurrentPw
            // 
            this.txtCurrentPw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCurrentPw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPw.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCurrentPw.Location = new System.Drawing.Point(271, 244);
            this.txtCurrentPw.Name = "txtCurrentPw";
            this.txtCurrentPw.Size = new System.Drawing.Size(260, 32);
            this.txtCurrentPw.TabIndex = 4;
            this.txtCurrentPw.Text = "Current Password";
            // 
            // txtNewPw
            // 
            this.txtNewPw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNewPw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPw.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNewPw.Location = new System.Drawing.Point(271, 291);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.Size = new System.Drawing.Size(260, 32);
            this.txtNewPw.TabIndex = 5;
            this.txtNewPw.Text = "New Password";
            // 
            // txtRePw
            // 
            this.txtRePw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRePw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePw.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRePw.Location = new System.Drawing.Point(271, 340);
            this.txtRePw.Name = "txtRePw";
            this.txtRePw.Size = new System.Drawing.Size(260, 32);
            this.txtRePw.TabIndex = 6;
            this.txtRePw.Text = "Re-enter Password";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(701, 392);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(87, 42);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 42);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblname.Location = new System.Drawing.Point(266, 157);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(119, 29);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Username:";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(271, 186);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(125, 37);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "                  ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCustEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtRePw);
            this.Controls.Add(this.txtNewPw);
            this.Controls.Add(this.txtCurrentPw);
            this.Controls.Add(this.pnlEditProfile);
            this.Name = "frmCustEditProfile";
            this.Text = "Customer - Edit Profile";
            this.Load += new System.EventHandler(this.frmCustEditProfile_Load);
            this.pnlEditProfile.ResumeLayout(false);
            this.pnlEditProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditProfile;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.TextBox txtCurrentPw;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtRePw;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblUsername;
    }
}