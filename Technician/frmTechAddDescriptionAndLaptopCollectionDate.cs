using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_35_Assignment
{
    public partial class frmTechAddDescriptionAndLaptopCollectionDate : Form
    {
        
        public frmTechAddDescriptionAndLaptopCollectionDate()
        {
            InitializeComponent();
        }

        private void current_service()
        {
            string selected_username;
            selected_username = cboTechCustomerNames.Text;
            Technician tech = new Technician();
            txtTechCurrentService.Text = tech.view_requested_service(selected_username);
        }

        private void service_description()
        {
            string selected_username;
            string edit_service_description;
            selected_username = cboTechCustomerNames.Text;
            Technician tech = new Technician();
            edit_service_description = tech.view_description(selected_username);
            if (edit_service_description == "")
            {
                txtTechServiceDescription.Text = "None.";
            }
            else
            {
                txtTechServiceDescription.Text = edit_service_description;
            }
            
        }

        private void collection_date()
        {
            string selected_username;
            selected_username = cboTechCustomerNames.Text;
            string edit_collection_date;
            Technician tech = new Technician();
            edit_collection_date = tech.view_collection_date(selected_username);

            if (edit_collection_date == "")
            {
                txtTechLaptopCollectionDate.Text = "None.";
            }
            else
            {
                txtTechLaptopCollectionDate.Text = edit_collection_date;
            }
                
        }

        private void unselected_total_amount()
        {
            string edit_total_amount;
            string selected_username = cboTechCustomerNames.Text;
            Technician tech = new Technician();
            edit_total_amount = tech.edit_total_amount(selected_username);
            txtTechTotalAmount.Text = edit_total_amount;
        }
        private void selected_total_amount(string un)
        {
            string edit_total_amount;
            Technician tech = new Technician();
            edit_total_amount = tech.edit_total_amount(un);
            txtTechTotalAmount.Text = edit_total_amount;
        }

        private void frmTechAddDescriptionAndLaptopCollectionDate_Load(object sender, EventArgs e)
        {
            ArrayList username = new ArrayList();
            Technician tech = new Technician();
            username = tech.Get_matched_customer_username();

            foreach(string un in username)
            {
                cboTechCustomerNames.Items.Add(un);
            }

            if (frmTechViewRequestedService.SetValueFor_SelectedUsername != null)
            {
                lblTechSelectedUsername.Text = frmTechViewRequestedService.SetValueFor_SelectedUsername;
                txtTechCurrentService.Text = frmTechViewRequestedService.SetValueFor_RequestedService;
                txtTechServiceDescription.Text = frmTechViewRequestedService.SetValueFor_ServiceDescription;
                txtTechLaptopCollectionDate.Text = frmTechViewRequestedService.SetValueFor_CollectionDate;
                selected_total_amount(lblTechSelectedUsername.Text);
            }
            else
            {
                lblTechSelectedUsername.Text = "Please pick a customer.";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTechChoose_Click(object sender, EventArgs e)
        {
            if (cboTechCustomerNames.Text == "")
            {
                MessageBox.Show("Please pick a customer.");
            }
            else
            {
                lblTechSelectedUsername.Text = cboTechCustomerNames.Text;
                current_service();
                service_description();
                collection_date();
                unselected_total_amount();
            }
        }

        private void btnTechApply_Click(object sender, EventArgs e)
        {
            Technician tech = new Technician();

            string collection_date = txtTechLaptopCollectionDate.Text;
            string service_description = txtTechServiceDescription.Text;
            string username;
            if(lblTechSelectedUsername.Text!="Please pick a customer.")
            {
                username = lblTechSelectedUsername.Text;
            }
            else
            {
                username = cboTechCustomerNames.Text;
            }
            try
            {
                tech.update_detalis(username, service_description, collection_date);
                MessageBox.Show("Detail Has Been Updated Sucessfully.","Detail Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please make sure your computer format is yyyy/MM/dd.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnTechBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
