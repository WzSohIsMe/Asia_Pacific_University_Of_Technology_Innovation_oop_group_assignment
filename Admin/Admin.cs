using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    internal class Admin
    {
        private string username;
        private string password;
        private string role;
        private string oldPass;
        private string newPass;
        private string cfmPass;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string OldPass { get => oldPass; set => oldPass = value; }
        public string NewPass { get => newPass; set => newPass = value; }
        public string ReNewPass { get => cfmPass; set => cfmPass = value; }

        public Admin(string usnm, string Pwd, string r)
        {
            username = usnm;
            password = Pwd;
            role = r;
        }

        public Admin(string usnm, string oPwd, string nPwd, string cPwd)
        {
            username = usnm;
            oldPass = oPwd;
            newPass = nPwd;
            cfmPass = cPwd;
        }

        public string edit()
        {
            string status;
            string password = null; 
            con.Open();

            SqlCommand cmd = new SqlCommand("update Account set password = '" + cfmPass + "' where username = '" + username + "'", con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Password updated Successfully.";
            else
                status = "Unable to update password.";

            con.Close();
            return status;
        }

        public string register()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            SqlCommand cmd = new SqlCommand("select count(*) from Account where username='" + username + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());


            if (count == 0)
            {
                SqlCommand cmd2 = new SqlCommand("insert into Account(username, password, role) values (@un, @p, @role)", con);
                cmd2.Parameters.AddWithValue("@un", username);
                cmd2.Parameters.AddWithValue("@p", password);
                cmd2.Parameters.AddWithValue("@role", role);
                cmd2.ExecuteNonQuery();

                status = "Successfully registered";
            }
            else
                status = "Username is already registered";
            con.Close();

            return status;
        }
    }
}
