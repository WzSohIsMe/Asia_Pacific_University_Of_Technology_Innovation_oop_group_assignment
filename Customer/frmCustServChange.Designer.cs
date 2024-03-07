
namespace Group_35_Assignment
{
    partial class frmCustServChange
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
            this.pnlChgReqServ = new System.Windows.Forms.Panel();
            this.cboProfileMenu = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentReqServ = new System.Windows.Forms.Label();
            this.lblReqServ = new System.Windows.Forms.Label();
            this.cboServChg = new System.Windows.Forms.ComboBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbUrgent = new System.Windows.Forms.RadioButton();
            this.grpBoxServUrg = new System.Windows.Forms.GroupBox();
            this.pnlChgReqServ.SuspendLayout();
            this.grpBoxServUrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChgReqServ
            // 
            this.pnlChgReqServ.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlChgReqServ.Controls.Add(this.cboProfileMenu);
            this.pnlChgReqServ.Controls.Add(this.lblUsername);
            this.pnlChgReqServ.Controls.Add(this.lblTitle);
            this.pnlChgReqServ.Location = new System.Drawing.Point(-2, 1);
            this.pnlChgReqServ.Name = "pnlChgReqServ";
            this.pnlChgReqServ.Size = new System.Drawing.Size(804, 116);
            this.pnlChgReqServ.TabIndex = 0;
            // 
            // cboProfileMenu
            // 
            this.cboProfileMenu.BackColor = System.Drawing.Color.White;
            this.cboProfileMenu.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.cboProfileMenu.FormattingEnabled = true;
            this.cboProfileMenu.Items.AddRange(new object[] {
            "Edit Profile",
            "Logout"});
            this.cboProfileMenu.Location = new System.Drawing.Point(673, 50);
            this.cboProfileMenu.Name = "cboProfileMenu";
            this.cboProfileMenu.Size = new System.Drawing.Size(89, 29);
            this.cboProfileMenu.TabIndex = 7;
            this.cboProfileMenu.Text = "Profile";
            this.cboProfileMenu.SelectedIndexChanged += new System.EventHandler(this.cboProfileMenu_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(669, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 24);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(38, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Change Requested Service";
            // 
            // lblCurrentReqServ
            // 
            this.lblCurrentReqServ.AutoSize = true;
            this.lblCurrentReqServ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentReqServ.Location = new System.Drawing.Point(39, 151);
            this.lblCurrentReqServ.Name = "lblCurrentReqServ";
            this.lblCurrentReqServ.Size = new System.Drawing.Size(236, 24);
            this.lblCurrentReqServ.TabIndex = 1;
            this.lblCurrentReqServ.Text = "Current Requested Service:";
            // 
            // lblReqServ
            // 
            this.lblReqServ.AutoSize = true;
            this.lblReqServ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReqServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReqServ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqServ.Location = new System.Drawing.Point(281, 151);
            this.lblReqServ.Name = "lblReqServ";
            this.lblReqServ.Size = new System.Drawing.Size(107, 26);
            this.lblReqServ.TabIndex = 2;
            this.lblReqServ.Text = "                   ";
            // 
            // cboServChg
            // 
            this.cboServChg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServChg.FormattingEnabled = true;
            this.cboServChg.Items.AddRange(new object[] {
            "Remove virus, malware or spyware ",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.cboServChg.Location = new System.Drawing.Point(225, 208);
            this.cboServChg.Name = "cboServChg";
            this.cboServChg.Size = new System.Drawing.Size(393, 32);
            this.cboServChg.TabIndex = 3;
            this.cboServChg.Text = "Please select a service here";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(671, 380);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(94, 49);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(43, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 49);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(6, 30);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(93, 28);
            this.rdbNormal.TabIndex = 6;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // rdbUrgent
            // 
            this.rdbUrgent.AutoSize = true;
            this.rdbUrgent.Location = new System.Drawing.Point(6, 69);
            this.rdbUrgent.Name = "rdbUrgent";
            this.rdbUrgent.Size = new System.Drawing.Size(88, 28);
            this.rdbUrgent.TabIndex = 7;
            this.rdbUrgent.TabStop = true;
            this.rdbUrgent.Text = "Urgent";
            this.rdbUrgent.UseVisualStyleBackColor = true;
            // 
            // grpBoxServUrg
            // 
            this.grpBoxServUrg.Controls.Add(this.rdbUrgent);
            this.grpBoxServUrg.Controls.Add(this.rdbNormal);
            this.grpBoxServUrg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxServUrg.Location = new System.Drawing.Point(35, 208);
            this.grpBoxServUrg.Name = "grpBoxServUrg";
            this.grpBoxServUrg.Size = new System.Drawing.Size(174, 129);
            this.grpBoxServUrg.TabIndex = 8;
            this.grpBoxServUrg.TabStop = false;
            this.grpBoxServUrg.Text = "Service Urgency";
            // 
            // frmCustServChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxServUrg);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cboServChg);
            this.Controls.Add(this.lblReqServ);
            this.Controls.Add(this.lblCurrentReqServ);
            this.Controls.Add(this.pnlChgReqServ);
            this.Name = "frmCustServChange";
            this.Text = "frmCustServChange";
            this.Load += new System.EventHandler(this.frmCustServChange_Load);
            this.pnlChgReqServ.ResumeLayout(false);
            this.pnlChgReqServ.PerformLayout();
            this.grpBoxServUrg.ResumeLayout(false);
            this.grpBoxServUrg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChgReqServ;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentReqServ;
        private System.Windows.Forms.Label lblReqServ;
        private System.Windows.Forms.ComboBox cboServChg;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cboProfileMenu;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbUrgent;
        private System.Windows.Forms.GroupBox grpBoxServUrg;
    }
}