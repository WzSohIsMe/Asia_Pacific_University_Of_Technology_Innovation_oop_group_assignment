using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    class CustEditProfile
    {
        private string username;
        private string currentPw;
        private string newPw;
        private string rePw;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public CustEditProfile(string un, string cp, string np, string rp)
        {
            username = un;
            currentPw = cp;
            newPw = np;
            rePw = rp;
        }

        public string editProfile()
        {
            string status;
            string password;
            password = null;
            con.Open();

            SqlCommand cmd = new SqlCommand("select password from Account where username = '" + username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                password = rd.GetString(0);
            }
            rd.Close();

            if (password != currentPw)
            {
                status = "You have entered the wrong current password";
            }
            else
            {
                if (newPw != rePw)
                {
                    status = "Your new password and re-enter password does not match";
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("update Account set password = '" + rePw + "' where username = '" + username + "'", con);
                    int i = cmd2.ExecuteNonQuery();
                    if (i != 0)
                        status = "Update Successfully.";
                    else
                        status = "Unable to update";
                }
            }

            con.Close();
            return status;
        }
    }
}
