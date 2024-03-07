
namespace Group_35_Assignment
{
    partial class frmTechHome
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnTechViewReqServ = new System.Windows.Forms.Button();
            this.lblTechAddDescAndCollecDate = new System.Windows.Forms.Button();
            this.btnTechSignOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTechTechnician = new System.Windows.Forms.Label();
            this.lblTechUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEditProfile.Location = new System.Drawing.Point(312, 38);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(96, 35);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnTechViewReqServ
            // 
            this.btnTechViewReqServ.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTechViewReqServ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTechViewReqServ.FlatAppearance.BorderSize = 0;
            this.btnTechViewReqServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechViewReqServ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechViewReqServ.Location = new System.Drawing.Point(56, 231);
            this.btnTechViewReqServ.Name = "btnTechViewReqServ";
            this.btnTechViewReqServ.Size = new System.Drawing.Size(313, 37);
            this.btnTechViewReqServ.TabIndex = 0;
            this.btnTechViewReqServ.Text = "View requested services";
            this.btnTechViewReqServ.UseVisualStyleBackColor = false;
            this.btnTechViewReqServ.Click += new System.EventHandler(this.btnTechViewReqServ_Click);
            // 
            // lblTechAddDescAndCollecDate
            // 
            this.lblTechAddDescAndCollecDate.BackColor = System.Drawing.Color.DarkCyan;
            this.lblTechAddDescAndCollecDate.FlatAppearance.BorderSize = 0;
            this.lblTechAddDescAndCollecDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTechAddDescAndCollecDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechAddDescAndCollecDate.Location = new System.Drawing.Point(56, 309);
            this.lblTechAddDescAndCollecDate.Name = "lblTechAddDescAndCollecDate";
            this.lblTechAddDescAndCollecDate.Size = new System.Drawing.Size(313, 38);
            this.lblTechAddDescAndCollecDate.TabIndex = 1;
            this.lblTechAddDescAndCollecDate.Text = "Add description and laptop collection date";
            this.lblTechAddDescAndCollecDate.UseVisualStyleBackColor = false;
            this.lblTechAddDescAndCollecDate.Click += new System.EventHandler(this.lblTechAddDescAndCollecDate_Click);
            // 
            // btnTechSignOut
            // 
            this.btnTechSignOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTechSignOut.FlatAppearance.BorderSize = 0;
            this.btnTechSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechSignOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechSignOut.Location = new System.Drawing.Point(312, 79);
            this.btnTechSignOut.Name = "btnTechSignOut";
            this.btnTechSignOut.Size = new System.Drawing.Size(96, 33);
            this.btnTechSignOut.TabIndex = 3;
            this.btnTechSignOut.Text = "Logout";
            this.btnTechSignOut.UseVisualStyleBackColor = false;
            this.btnTechSignOut.Click += new System.EventHandler(this.btnTechSignOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblTechTechnician);
            this.panel1.Controls.Add(this.lblTechUsername);
            this.panel1.Controls.Add(this.btnTechSignOut);
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Location = new System.Drawing.Point(-7, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 127);
            this.panel1.TabIndex = 5;
     
            // 
            // lblTechTechnician
            // 
            this.lblTechTechnician.AutoSize = true;
            this.lblTechTechnician.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechTechnician.Location = new System.Drawing.Point(19, 23);
            this.lblTechTechnician.Name = "lblTechTechnician";
            this.lblTechTechnician.Size = new System.Drawing.Size(235, 59);
            this.lblTechTechnician.TabIndex = 5;
            this.lblTechTechnician.Text = "Technician";
            // 
            // lblTechUsername
            // 
            this.lblTechUsername.AutoSize = true;
            this.lblTechUsername.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechUsername.Location = new System.Drawing.Point(34, 77);
            this.lblTechUsername.Name = "lblTechUsername";
            this.lblTechUsername.Size = new System.Drawing.Size(117, 29);
            this.lblTechUsername.TabIndex = 5;
            this.lblTechUsername.Text = "Username";

   
            // 
            // frmTechHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(424, 621);
            this.Controls.Add(this.lblTechAddDescAndCollecDate);
            this.Controls.Add(this.btnTechViewReqServ);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTechHome";
            this.Text = "Technician - Home";
            this.Load += new System.EventHandler(this.frmTechHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnTechViewReqServ;
        private System.Windows.Forms.Button lblTechAddDescAndCollecDate;
        private System.Windows.Forms.Button btnTechSignOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTechTechnician;
        private System.Windows.Forms.Label lblTechUsername;
    }
}

