using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace Group_35_Assignment
{
    public partial class frmTechViewRequestedService : Form
    {
        public static string SetValueFor_RequestedService;
        public static string SetValueFor_SelectedUsername;
        public static string SetValueFor_ServiceDescription;
        public static string SetValueFor_CollectionDate;
        public frmTechViewRequestedService()
        {
            InitializeComponent();

        }
        private void frmTechViewRequestedService_Load(object sender, EventArgs e)
        {
            ArrayList username = new ArrayList();
            Technician tech = new Technician();
            username = tech.Get_matched_customer_username();
            
            foreach(string un in username)
            {
                cboTechCustomerNames.Items.Add(un);
            }

        }

        private void view_requested_service()
        {
            string selected_username;
            selected_username = cboTechCustomerNames.Text;
            Technician tech = new Technician();
            txtTechRequestedService.Text = tech.view_requested_service(selected_username);
            
        }

        private void view_collection_date()
        {
            string selected_username;
            selected_username = cboTechCustomerNames.Text;
            string collection_date;
            Technician tech = new Technician();
            collection_date = tech.view_collection_date(selected_username);
            if (collection_date == "")
            {
                txtCollectionDate.Text = "None.";
            }
            else
            {
                txtCollectionDate.Text = collection_date;
            }
        }

        private void view_service_description()
        {
            string selected_username;
            selected_username = cboTechCustomerNames.Text;
            string service_description;
            Technician tech = new Technician();
            service_description = tech.view_description(selected_username);
            if (service_description == "")
            {
                txtTechDescription.Text = "None.";
            }
            else
            {
                txtTechDescription.Text = service_description;
            }
            SetValueFor_ServiceDescription = txtTechDescription.Text;
        }

        private void btnTechView_Click(object sender, EventArgs e)
        {
            if (cboTechCustomerNames.Text == "")
            {
                MessageBox.Show("Please pick a customer.");
            }
            else
            {
                lblTechCustomerName.Text = cboTechCustomerNames.Text;
                view_requested_service();
                view_collection_date();
                view_service_description();
            }
            
        }

        private void btnTechEdit_Click(object sender, EventArgs e)
        {
            frmTechAddDescriptionAndLaptopCollectionDate editCustomer = new frmTechAddDescriptionAndLaptopCollectionDate();
            SetValueFor_SelectedUsername = cboTechCustomerNames.Text;
            SetValueFor_RequestedService = txtTechRequestedService.Text;
            SetValueFor_CollectionDate = txtCollectionDate.Text;
            SetValueFor_ServiceDescription = txtTechDescription.Text;
            
            if (SetValueFor_SelectedUsername == ""||SetValueFor_SelectedUsername == ""||SetValueFor_RequestedService == ""||SetValueFor_ServiceDescription=="") {
                MessageBox.Show("Please select a customer.");
            }else
            {
                
                editCustomer.Show();
                this.Close();
            }
        }

        private void btnTechBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
}
