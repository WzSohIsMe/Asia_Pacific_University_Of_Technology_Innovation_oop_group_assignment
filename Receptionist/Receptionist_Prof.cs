using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    internal class Receptionist_Prof
    {
        private string rcptnName;
        private string oldPass;
        private string newPass;
        private string reNewPass;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public Receptionist_Prof(string n, string op, string np, string rnp)
        {
            rcptnName = n;
            oldPass = op;
            newPass = np;
            reNewPass = rnp;
        }

        public string editRcptnProf()
        {
            string status;
            string password = null;
            con.Open();

            SqlCommand cmd = new SqlCommand("select password from Account where username = '" + rcptnName + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                password = rd.GetString(0);
            }
            rd.Close();
            
            if (password != oldPass)
            {
                status = "You've entered the wrong old password!";
            }
            else
            {
                if (newPass != reNewPass)
                {
                    status = "The new password entered in both textbox does not match.";
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("update Account set password = '" + reNewPass + "' where username = '" + rcptnName + "'", con);

                    int i = cmd2.ExecuteNonQuery();
                    if (i != 0)
                        status = "Password updated Successfully.";
                    else
                        status = "Unable to update password.";
                }
            }

            con.Close();
            return status;
        }
    }
}
