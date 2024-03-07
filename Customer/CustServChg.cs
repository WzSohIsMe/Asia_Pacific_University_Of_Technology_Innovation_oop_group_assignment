using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    class CustServChg
    {
        private string username;
        private int custUserId;
        private string serviceType;
        private string changedServ;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string ServiceType { get => serviceType; set => serviceType = value; }

        public CustServChg(string un)
        {
            username = un;
        }
        public static void currentReqServ(CustServChg o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + o1.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.custUserId = rd.GetInt32(0);
            }
            rd.Close();
            SqlCommand cmd2 = new SqlCommand("select service_type from Service where user_id = '" + o1.custUserId + "'and paid_amount is null", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                o1.serviceType = rd2["service_type"].ToString();
            }
            con.Close();
        }
        public string updateServChg(string su, string cs)
        {
            string status;
            string servUrgency = su;
            con.Open();
            changedServ = cs;
            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                custUserId = rd.GetInt32(0);
            }
            rd.Close();

            SqlCommand cmd2 = new SqlCommand("update service set service_type = '" + changedServ + "' where user_id = '" + custUserId +"' and paid_amount is null", con);
            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Service change update succesfully. ";
            }
            else
            {
                status = "Service change unable to update. ";
            }
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("update service set service_urgency = '" + servUrgency + "' where user_id = '" + custUserId + "' and paid_amount is null", con);
            int j = cmd3.ExecuteNonQuery();
            if (j != 0)
            {
                status = status + "Service urgency update succesfully. ";
            }
            else
            {
                status = status + "Service urgency unable to update. ";
            }
            con.Close();

            int price = 0;

            if (servUrgency == "Normal")
            {
                if (changedServ == "Remove virus, malware or spyware")
                {
                    price = 50;
                }
                else if (changedServ == "Troubleshot and fix computer running slow")
                {
                    price = 60;
                }
                else if (changedServ == "Laptop screen replacement")
                {
                    price = 380;
                }
                else if (changedServ == "Laptop keyboard replacement")
                {
                    price = 160;
                }
                else if (changedServ == "Laptop battery replacement")
                {
                    price = 180;
                }
                else if (changedServ == "Operating System Format and Installation")
                {
                    price = 100;
                }
                else if (changedServ == "Data backup and recovery")
                {
                    price = 80;
                }
                else if (changedServ == "Internet connectivity issues")
                {
                    price = 70;
                }
            }
            else if (servUrgency == "Urgent")
            {
                if (changedServ == "Remove virus, malware or spyware")
                {
                    price = 80;
                }
                else if (changedServ == "Troubleshot and fix computer running slow")
                {
                    price = 90;
                }
                else if (changedServ == "Laptop screen replacement")
                {
                    price = 430;
                }
                else if (changedServ == "Laptop keyboard replacement")
                {
                    price = 200;
                }
                else if (changedServ == "Laptop battery replacement")
                {
                    price = 210;
                }
                else if (changedServ == "Operating System Format and Installation")
                {
                    price = 150;
                }
                else if (changedServ == "Data backup and recovery")
                {
                    price = 130;
                }
                else if (changedServ == "Internet connectivity issues")
                {
                    price = 100;
                }
            }
            con.Open();
            SqlCommand cmd4 = new SqlCommand("update Service set service_fee = '" + price + "' where user_id = '" + custUserId + "' and paid_amount is null", con);
            int n = cmd4.ExecuteNonQuery();
            if (n != 0)
            {
                status = status + "Service fee update succesfully. ";
            }
            else
            {
                status = status + "Service fee unable to update. ";
            }
            con.Close();

            return status;
        }
    }
}
