using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    class CustOnServ
    {
        private string username;
        private int custUserId;
        private string serviceDesc;
        private string laptopCollectDate;
        private int serviceFee;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string ServiceDesc { get => serviceDesc; set => serviceDesc = value; }
        public string LaptopCollectDate { get => laptopCollectDate; set => laptopCollectDate = value; }
        public int ServiceFee { get => serviceFee; set => serviceFee = value; }

        public CustOnServ(string un)
        {
            username = un;
        }
        public static void viewServiceDesc(CustOnServ o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + o1.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.custUserId = rd.GetInt32(0);
            }
            rd.Close();
            SqlCommand cmd2 = new SqlCommand("select service_description from Service where user_id = '" + o1.custUserId + "' and paid_amount is null", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                o1.serviceDesc = rd2["service_description"].ToString();
            }
            con.Close();
        }

        public static void viewLaptopCollectionDate(CustOnServ o2)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + o2.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o2.custUserId = rd.GetInt32(0);
            }
            rd.Close();
            SqlCommand cmd2 = new SqlCommand("select laptop_collection_date from Service where user_id = '" + o2.custUserId + "'and paid_amount is null", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                o2.laptopCollectDate = rd2["laptop_collection_date"].ToString();
            }
            con.Close();
        }

        public static void viewServiceFee(CustOnServ o3)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + o3.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o3.custUserId = rd.GetInt32(0);
            }
            rd.Close();
            SqlCommand cmd2 = new SqlCommand("select service_fee from Service where user_id = '" + o3.custUserId + "'and paid_amount is null", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                o3.serviceFee = int.Parse(rd2["service_fee"].ToString());
            }
            con.Close();
        }
    }
}
