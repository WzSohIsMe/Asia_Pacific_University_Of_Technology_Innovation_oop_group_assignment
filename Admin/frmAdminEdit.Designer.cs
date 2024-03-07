namespace Group_35_Assignment
{
    partial class frmAdminEdit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUsernameEdit = new System.Windows.Forms.Label();
            this.lblDispUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCfmPass = new System.Windows.Forms.TextBox();
            this.cboxConfirm = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 125);
            this.panel1.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(36, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Admin Profile";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(255, 607);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(166, 46);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Back to Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblUsernameEdit
            // 
            this.lblUsernameEdit.AutoSize = true;
            this.lblUsernameEdit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsernameEdit.Location = new System.Drawing.Point(100, 169);
            this.lblUsernameEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameEdit.Name = "lblUsernameEdit";
            this.lblUsernameEdit.Size = new System.Drawing.Size(107, 26);
            this.lblUsernameEdit.TabIndex = 15;
            this.lblUsernameEdit.Text = "Username:";
            // 
            // lblDispUsername
            // 
            this.lblDispUsername.AutoSize = true;
            this.lblDispUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispUsername.Location = new System.Drawing.Point(100, 199);
            this.lblDispUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDispUsername.Name = "lblDispUsername";
            this.lblDispUsername.Size = new System.Drawing.Size(98, 26);
            this.lblDispUsername.TabIndex = 16;
            this.lblDispUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Old Password:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOldPass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldPass.ForeColor = System.Drawing.Color.Gray;
            this.txtOldPass.Location = new System.Drawing.Point(105, 302);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(248, 31);
            this.txtOldPass.TabIndex = 18;
            this.txtOldPass.Text = "Old Password";
            this.txtOldPass.Enter += new System.EventHandler(this.txtOldPass_Enter);
            this.txtOldPass.Leave += new System.EventHandler(this.txtOldPass_Leave);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNewPass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPass.ForeColor = System.Drawing.Color.Gray;
            this.txtNewPass.Location = new System.Drawing.Point(105, 398);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(248, 31);
            this.txtNewPass.TabIndex = 20;
            this.txtNewPass.Text = "New Password";
            this.txtNewPass.Enter += new System.EventHandler(this.txtNewPass_Enter);
            this.txtNewPass.Leave += new System.EventHandler(this.txtNewPass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "New Password:";
            // 
            // txtCfmPass
            // 
            this.txtCfmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCfmPass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCfmPass.ForeColor = System.Drawing.Color.Gray;
            this.txtCfmPass.Location = new System.Drawing.Point(105, 452);
            this.txtCfmPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCfmPass.Name = "txtCfmPass";
            this.txtCfmPass.Size = new System.Drawing.Size(248, 31);
            this.txtCfmPass.TabIndex = 21;
            this.txtCfmPass.Text = "Confirm New Password";
            this.txtCfmPass.Enter += new System.EventHandler(this.txtCfmPass_Enter);
            this.txtCfmPass.Leave += new System.EventHandler(this.txtCfmPass_Leave);
            // 
            // cboxConfirm
            // 
            this.cboxConfirm.AutoSize = true;
            this.cboxConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxConfirm.Location = new System.Drawing.Point(105, 511);
            this.cboxConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxConfirm.Name = "cboxConfirm";
            this.cboxConfirm.Size = new System.Drawing.Size(176, 23);
            this.cboxConfirm.TabIndex = 22;
            this.cboxConfirm.Text = "Confirm changes made";
            this.cboxConfirm.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(40, 607);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 46);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 715);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboxConfirm);
            this.Controls.Add(this.txtCfmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDispUsername);
            this.Controls.Add(this.lblUsernameEdit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAdminEdit";
            this.Text = "frmAdminEdit";
            this.Load += new System.EventHandler(this.frmAdminEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblUsernameEdit;
        private System.Windows.Forms.Label lblDispUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCfmPass;
        private System.Windows.Forms.CheckBox cboxConfirm;
        private System.Windows.Forms.Button btnSave;
    }
}