
namespace Group_35_Assignment
{
    partial class frmCustOnServ
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
            this.pnlOnServ = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cboProfileMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnServiceChg = new System.Windows.Forms.Button();
            this.btnCusTotalAmount = new System.Windows.Forms.Button();
            this.btnCusCollectionDate = new System.Windows.Forms.Button();
            this.btnServiceDesc = new System.Windows.Forms.Button();
            this.pnlOnServ.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOnServ
            // 
            this.pnlOnServ.BackColor = System.Drawing.Color.Teal;
            this.pnlOnServ.Controls.Add(this.lblUsername);
            this.pnlOnServ.Controls.Add(this.cboProfileMenu);
            this.pnlOnServ.Controls.Add(this.label1);
            this.pnlOnServ.Location = new System.Drawing.Point(0, 0);
            this.pnlOnServ.Name = "pnlOnServ";
            this.pnlOnServ.Size = new System.Drawing.Size(803, 117);
            this.pnlOnServ.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(662, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 24);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboProfileMenu
            // 
            this.cboProfileMenu.BackColor = System.Drawing.Color.White;
            this.cboProfileMenu.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.cboProfileMenu.FormattingEnabled = true;
            this.cboProfileMenu.Items.AddRange(new object[] {
            "Edit Profile",
            "Logout"});
            this.cboProfileMenu.Location = new System.Drawing.Point(666, 35);
            this.cboProfileMenu.Name = "cboProfileMenu";
            this.cboProfileMenu.Size = new System.Drawing.Size(89, 29);
            this.cboProfileMenu.TabIndex = 2;
            this.cboProfileMenu.Text = "Profile";
            this.cboProfileMenu.SelectedIndexChanged += new System.EventHandler(this.cboProfileMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ongoing Service";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnServiceChg);
            this.panel2.Controls.Add(this.btnCusTotalAmount);
            this.panel2.Controls.Add(this.btnCusCollectionDate);
            this.panel2.Controls.Add(this.btnServiceDesc);
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 345);
            this.panel2.TabIndex = 6;
            // 
            // btnServiceChg
            // 
            this.btnServiceChg.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceChg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnServiceChg.Location = new System.Drawing.Point(228, 213);
            this.btnServiceChg.Name = "btnServiceChg";
            this.btnServiceChg.Size = new System.Drawing.Size(302, 68);
            this.btnServiceChg.TabIndex = 9;
            this.btnServiceChg.Text = "Change Requested Service";
            this.btnServiceChg.UseVisualStyleBackColor = true;
            this.btnServiceChg.Click += new System.EventHandler(this.btnServiceChg_Click);
            // 
            // btnCusTotalAmount
            // 
            this.btnCusTotalAmount.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCusTotalAmount.Location = new System.Drawing.Point(228, 153);
            this.btnCusTotalAmount.Name = "btnCusTotalAmount";
            this.btnCusTotalAmount.Size = new System.Drawing.Size(299, 54);
            this.btnCusTotalAmount.TabIndex = 8;
            this.btnCusTotalAmount.Text = "Total Amount To Be Paid";
            this.btnCusTotalAmount.UseVisualStyleBackColor = true;
            this.btnCusTotalAmount.Click += new System.EventHandler(this.btnCusTotalAmount_Click);
            // 
            // btnCusCollectionDate
            // 
            this.btnCusCollectionDate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusCollectionDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCusCollectionDate.Location = new System.Drawing.Point(228, 104);
            this.btnCusCollectionDate.Name = "btnCusCollectionDate";
            this.btnCusCollectionDate.Size = new System.Drawing.Size(299, 43);
            this.btnCusCollectionDate.TabIndex = 7;
            this.btnCusCollectionDate.Text = "Laptop Collection Date";
            this.btnCusCollectionDate.UseVisualStyleBackColor = true;
            this.btnCusCollectionDate.Click += new System.EventHandler(this.btnCusCollectionDate_Click);
            // 
            // btnServiceDesc
            // 
            this.btnServiceDesc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnServiceDesc.Location = new System.Drawing.Point(228, 55);
            this.btnServiceDesc.Name = "btnServiceDesc";
            this.btnServiceDesc.Size = new System.Drawing.Size(299, 43);
            this.btnServiceDesc.TabIndex = 6;
            this.btnServiceDesc.Text = "Service Description";
            this.btnServiceDesc.UseVisualStyleBackColor = true;
            this.btnServiceDesc.Click += new System.EventHandler(this.btnServiceDesc_Click);
            // 
            // frmCustOnServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOnServ);
            this.Name = "frmCustOnServ";
            this.Text = "Customer - Ongoing Service";
            this.Load += new System.EventHandler(this.frmCustOnServ_Load);
            this.pnlOnServ.ResumeLayout(false);
            this.pnlOnServ.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOnServ;
        private System.Windows.Forms.ComboBox cboProfileMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnServiceDesc;
        private System.Windows.Forms.Button btnCusTotalAmount;
        private System.Windows.Forms.Button btnCusCollectionDate;
        private System.Windows.Forms.Button btnServiceChg;
    }
}

