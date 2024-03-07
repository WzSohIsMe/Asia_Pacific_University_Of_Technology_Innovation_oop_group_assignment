
namespace Group_35_Assignment
{
    partial class frmTechAddDescriptionAndLaptopCollectionDate
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
            this.lblTechDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTechSelectedUsername = new System.Windows.Forms.Label();
            this.cboTechCustomerNames = new System.Windows.Forms.ComboBox();
            this.lblTechCurrentService = new System.Windows.Forms.Label();
            this.txtTechCurrentService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTechServiceDescription = new System.Windows.Forms.TextBox();
            this.lblTechLaptopCollectionDate = new System.Windows.Forms.Label();
            this.txtTechLaptopCollectionDate = new System.Windows.Forms.TextBox();
            this.lblTechTotalAmount = new System.Windows.Forms.Label();
            this.txtTechTotalAmount = new System.Windows.Forms.TextBox();
            this.btnTechApply = new System.Windows.Forms.Button();
            this.btnTechBack = new System.Windows.Forms.Button();
            this.btnTechChoose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTechDetails
            // 
            this.lblTechDetails.AutoSize = true;
            this.lblTechDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblTechDetails.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechDetails.ForeColor = System.Drawing.Color.Azure;
            this.lblTechDetails.Location = new System.Drawing.Point(3, 12);
            this.lblTechDetails.Name = "lblTechDetails";
            this.lblTechDetails.Size = new System.Drawing.Size(126, 45);
            this.lblTechDetails.TabIndex = 0;
            this.lblTechDetails.Text = "Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblTechSelectedUsername);
            this.panel1.Controls.Add(this.lblTechDetails);
            this.panel1.Controls.Add(this.cboTechCustomerNames);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTechSelectedUsername
            // 
            this.lblTechSelectedUsername.AutoSize = true;
            this.lblTechSelectedUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblTechSelectedUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTechSelectedUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechSelectedUsername.ForeColor = System.Drawing.Color.Azure;
            this.lblTechSelectedUsername.Location = new System.Drawing.Point(11, 50);
            this.lblTechSelectedUsername.Name = "lblTechSelectedUsername";
            this.lblTechSelectedUsername.Size = new System.Drawing.Size(2, 21);
            this.lblTechSelectedUsername.TabIndex = 0;
            // 
            // cboTechCustomerNames
            // 
            this.cboTechCustomerNames.BackColor = System.Drawing.Color.DarkCyan;
            this.cboTechCustomerNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTechCustomerNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTechCustomerNames.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTechCustomerNames.ForeColor = System.Drawing.Color.White;
            this.cboTechCustomerNames.FormattingEnabled = true;
            this.cboTechCustomerNames.Location = new System.Drawing.Point(4, 74);
            this.cboTechCustomerNames.Name = "cboTechCustomerNames";
            this.cboTechCustomerNames.Size = new System.Drawing.Size(424, 26);
            this.cboTechCustomerNames.TabIndex = 0;
            // 
            // lblTechCurrentService
            // 
            this.lblTechCurrentService.AutoSize = true;
            this.lblTechCurrentService.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechCurrentService.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTechCurrentService.Location = new System.Drawing.Point(8, 116);
            this.lblTechCurrentService.Name = "lblTechCurrentService";
            this.lblTechCurrentService.Size = new System.Drawing.Size(145, 26);
            this.lblTechCurrentService.TabIndex = 2;
            this.lblTechCurrentService.Text = "Current Service";
            // 
            // txtTechCurrentService
            // 
            this.txtTechCurrentService.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechCurrentService.Location = new System.Drawing.Point(13, 146);
            this.txtTechCurrentService.Name = "txtTechCurrentService";
            this.txtTechCurrentService.ReadOnly = true;
            this.txtTechCurrentService.Size = new System.Drawing.Size(245, 31);
            this.txtTechCurrentService.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(13, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Service Description";
            // 
            // txtTechServiceDescription
            // 
            this.txtTechServiceDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechServiceDescription.Location = new System.Drawing.Point(13, 221);
            this.txtTechServiceDescription.Multiline = true;
            this.txtTechServiceDescription.Name = "txtTechServiceDescription";
            this.txtTechServiceDescription.Size = new System.Drawing.Size(241, 206);
            this.txtTechServiceDescription.TabIndex = 3;
            // 
            // lblTechLaptopCollectionDate
            // 
            this.lblTechLaptopCollectionDate.AutoSize = true;
            this.lblTechLaptopCollectionDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechLaptopCollectionDate.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTechLaptopCollectionDate.Location = new System.Drawing.Point(13, 442);
            this.lblTechLaptopCollectionDate.Name = "lblTechLaptopCollectionDate";
            this.lblTechLaptopCollectionDate.Size = new System.Drawing.Size(189, 23);
            this.lblTechLaptopCollectionDate.TabIndex = 6;
            this.lblTechLaptopCollectionDate.Text = "Laptop Collection Date";
            // 
            // txtTechLaptopCollectionDate
            // 
            this.txtTechLaptopCollectionDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechLaptopCollectionDate.Location = new System.Drawing.Point(12, 468);
            this.txtTechLaptopCollectionDate.Name = "txtTechLaptopCollectionDate";
            this.txtTechLaptopCollectionDate.Size = new System.Drawing.Size(241, 31);
            this.txtTechLaptopCollectionDate.TabIndex = 4;
            // 
            // lblTechTotalAmount
            // 
            this.lblTechTotalAmount.AutoSize = true;
            this.lblTechTotalAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechTotalAmount.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTechTotalAmount.Location = new System.Drawing.Point(14, 516);
            this.lblTechTotalAmount.Name = "lblTechTotalAmount";
            this.lblTechTotalAmount.Size = new System.Drawing.Size(116, 23);
            this.lblTechTotalAmount.TabIndex = 8;
            this.lblTechTotalAmount.Text = "Total Amount";
            // 
            // txtTechTotalAmount
            // 
            this.txtTechTotalAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechTotalAmount.Location = new System.Drawing.Point(13, 542);
            this.txtTechTotalAmount.Name = "txtTechTotalAmount";
            this.txtTechTotalAmount.ReadOnly = true;
            this.txtTechTotalAmount.Size = new System.Drawing.Size(241, 31);
            this.txtTechTotalAmount.TabIndex = 5;
            // 
            // btnTechApply
            // 
            this.btnTechApply.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTechApply.FlatAppearance.BorderSize = 0;
            this.btnTechApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechApply.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechApply.ForeColor = System.Drawing.Color.White;
            this.btnTechApply.Location = new System.Drawing.Point(-4, 586);
            this.btnTechApply.Name = "btnTechApply";
            this.btnTechApply.Size = new System.Drawing.Size(76, 36);
            this.btnTechApply.TabIndex = 6;
            this.btnTechApply.Text = "Apply";
            this.btnTechApply.UseVisualStyleBackColor = false;
            this.btnTechApply.Click += new System.EventHandler(this.btnTechApply_Click);
            // 
            // btnTechBack
            // 
            this.btnTechBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTechBack.FlatAppearance.BorderSize = 0;
            this.btnTechBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechBack.ForeColor = System.Drawing.Color.White;
            this.btnTechBack.Location = new System.Drawing.Point(353, 586);
            this.btnTechBack.Name = "btnTechBack";
            this.btnTechBack.Size = new System.Drawing.Size(71, 36);
            this.btnTechBack.TabIndex = 7;
            this.btnTechBack.Text = "Back";
            this.btnTechBack.UseVisualStyleBackColor = false;
            this.btnTechBack.Click += new System.EventHandler(this.btnTechBack_Click);
            // 
            // btnTechChoose
            // 
            this.btnTechChoose.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTechChoose.FlatAppearance.BorderSize = 0;
            this.btnTechChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechChoose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechChoose.ForeColor = System.Drawing.Color.White;
            this.btnTechChoose.Location = new System.Drawing.Point(336, 103);
            this.btnTechChoose.Name = "btnTechChoose";
            this.btnTechChoose.Size = new System.Drawing.Size(76, 36);
            this.btnTechChoose.TabIndex = 1;
            this.btnTechChoose.Text = "Choose";
            this.btnTechChoose.UseVisualStyleBackColor = false;
            this.btnTechChoose.Click += new System.EventHandler(this.btnTechChoose_Click);
            // 
            // frmTechAddDescriptionAndLaptopCollectionDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(424, 621);
            this.Controls.Add(this.btnTechBack);
            this.Controls.Add(this.btnTechChoose);
            this.Controls.Add(this.btnTechApply);
            this.Controls.Add(this.txtTechTotalAmount);
            this.Controls.Add(this.lblTechTotalAmount);
            this.Controls.Add(this.txtTechLaptopCollectionDate);
            this.Controls.Add(this.lblTechLaptopCollectionDate);
            this.Controls.Add(this.txtTechServiceDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTechCurrentService);
            this.Controls.Add(this.lblTechCurrentService);
            this.Controls.Add(this.panel1);
            this.Name = "frmTechAddDescriptionAndLaptopCollectionDate";
            this.Text = "Technician - Add Description And Laptop Collection Date";
            this.Load += new System.EventHandler(this.frmTechAddDescriptionAndLaptopCollectionDate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTechDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTechCurrentService;
        private System.Windows.Forms.TextBox txtTechCurrentService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTechServiceDescription;
        private System.Windows.Forms.Label lblTechLaptopCollectionDate;
        private System.Windows.Forms.TextBox txtTechLaptopCollectionDate;
        private System.Windows.Forms.Label lblTechTotalAmount;
        private System.Windows.Forms.TextBox txtTechTotalAmount;
        private System.Windows.Forms.Button btnTechApply;
        private System.Windows.Forms.Button btnTechBack;
        private System.Windows.Forms.ComboBox cboTechCustomerNames;
        private System.Windows.Forms.Button btnTechChoose;
        private System.Windows.Forms.Label lblTechSelectedUsername;
    }
}