using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    class Technician
    {
        
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private static string username;
        private static string password;

        public Technician()
        {

        }
        public Technician(string un)
        {
            username = un;
        }

        public Technician(string un, string p)
        {
            username = un;
            password = p;
        }


        //view requested service
        public ArrayList Get_matched_customer_username()
        {
            con.Open();
            ArrayList matched_username_Account_arraylist = new ArrayList();
            SqlCommand cmd_matched_username_Account = new SqlCommand("select username from Account where role = 'Customer'", con);
            SqlDataReader rd_matched_username_Account = cmd_matched_username_Account.ExecuteReader();
                
            while (rd_matched_username_Account.Read())
            {
                matched_username_Account_arraylist.Add(rd_matched_username_Account.GetString(0));
            }

            rd_matched_username_Account.Close();
            con.Close();

            return matched_username_Account_arraylist;
        }

        public string view_requested_service(string un)
        {
           
            con.Open();
            string user_id;
            string requested_service;
            SqlCommand cmd_user_id = new SqlCommand("select user_id from Account where username ='" + un + "'", con);
            user_id = cmd_user_id.ExecuteScalar().ToString();
            con.Close();

            con.Open();
            SqlCommand cmd_requested_service = new SqlCommand("select service_type from Service where user_id='"+Int16.Parse(user_id)+"'",con);
            requested_service = cmd_requested_service.ExecuteScalar().ToString();
            con.Close();

            return requested_service;

        }
        public string view_collection_date(string un)
        {
            con.Open();
            string user_id;
            string collecion_date;
            SqlCommand cmd_user_id = new SqlCommand("select user_id from Account where username ='" + un + "'", con);
            user_id = cmd_user_id.ExecuteScalar().ToString();
            con.Close();

            con.Open();
            SqlCommand cmd_collection_date = new SqlCommand("select convert(varchar,laptop_collection_date,23) from Service where user_id='"+Int16.Parse(user_id)+"' AND paid_amount IS NULL",con);
            collecion_date = cmd_collection_date.ExecuteScalar().ToString();
            con.Close();
            
            return collecion_date;
        }
        public string view_description(string un)
        {
            con.Open();
            string user_id;
            string service_description;
            SqlCommand cmd_user_id = new SqlCommand("select user_id from Account where username ='" + un + "'", con);
            user_id = cmd_user_id.ExecuteScalar().ToString();
            con.Close();

            con.Open();
            SqlCommand cmd_service_description = new SqlCommand("select service_description from Service where user_id='" + Int16.Parse(user_id) + "'", con);
            service_description = cmd_service_description.ExecuteScalar().ToString();
            con.Close();

            return service_description;
        }

        //Add Description and Collection Date
        public string edit_total_amount(string un)
        {
            con.Open();
            string user_id;
            string total_amount;
            SqlCommand cmd_user_id = new SqlCommand("select user_id from Account where username ='" + un + "'", con);
            user_id = cmd_user_id.ExecuteScalar().ToString();
            con.Close();

            con.Open();
            SqlCommand cmd_total_amount = new SqlCommand("select service_fee from Service where user_id='"+Int16.Parse(user_id)+"'",con);
            total_amount = "RM "+cmd_total_amount.ExecuteScalar().ToString();
            con.Close();

            return total_amount;
        }
       
        public void update_detalis(string un,string s,string c)
        {
            string user_id;

            con.Open();
            SqlCommand cmd_user_id = new SqlCommand("select user_id from Account where username='" + un + "'", con);
            user_id = cmd_user_id.ExecuteScalar().ToString();
            con.Close();
            con.Open();
                   
            SqlCommand cmd_update_details = new SqlCommand("update Service SET laptop_collection_date='"+c+"',"+" service_description='"+s+"' where user_id="+Int16.Parse(user_id)+" AND paid_amount IS NULL",con);
            cmd_update_details.ExecuteScalar();
            con.Close();
            
        }
        


        //Edit Profile
        private string return_user_id(string un)
        {
            con.Open();
            SqlCommand cmd_user_id = new SqlCommand("select user_id from Account where username='" + username + "'",con);
            string user_id = cmd_user_id.ExecuteScalar().ToString();
            con.Close();
            return user_id;
        }

        private void update_new_password_username(string current_username, string new_username, string new_password)
        {
            
            string user_id = return_user_id(current_username);
            con.Open();
            SqlCommand cmd_update_password = new SqlCommand("update Account SET password='"+new_password+"', username ='"+new_username+"' where (user_id='"+user_id+"')",con);
            cmd_update_password.ExecuteNonQuery();
            con.Close();
        }

        public void edit_profile(string current_username,string new_username, string new_password) 
        {
            //username = username;
            update_new_password_username(current_username, new_username, new_password);
            
            
        }

        //Check if technicians click on apply or back button
        public bool IsApply(string apply_or_back)
        {
            if (apply_or_back == "Apply")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
