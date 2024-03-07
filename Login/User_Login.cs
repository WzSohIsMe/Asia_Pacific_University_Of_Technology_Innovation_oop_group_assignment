using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    internal class User_Login
    {
        private string username;
        private string password;

        public User_Login(string usnm, string pwd)
        {
            username = usnm;
            password = pwd;
        }

        public string login(string un, string pw)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            SqlCommand cmd = new SqlCommand("select count (*) from Account where username = '" + username + "' and password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from Account where username = '" + username + "' and password = '" + password + "'", con);
                string role = cmd2.ExecuteScalar().ToString();

                if (role == "Admin")
                {
                    frmAdminHome a = new frmAdminHome(un, pw);
                    a.ShowDialog();
                }
                else if (role == "Receptionist")
                {
                    frmRcptnPage r = new frmRcptnPage(un);
                    r.ShowDialog();
                }
                else if (role == "Technician")
                {
                    frmTechHome t = new frmTechHome(un);
                    t.ShowDialog();
                }
                else if (role == "Customer")
                {
                    frmCustOnServ r = new frmCustOnServ(un);
                    r.ShowDialog();
                }
            }
            else
                status = "Incorrect username/password";
            con.Close();

            return status;
        }
    }
}
