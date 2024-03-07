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
    internal class Receptionist_Cust
    {
        private string custName;
        private string custPwd;
        private int serTypeIndex;
        private string service_selected;
        private string urgency;
        private int serFee;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Receptionist_Cust(string cn)
        {
            custName = cn;
        }

        public Receptionist_Cust(string cn, string cp)
        {
            custName = cn;
            custPwd = cp;
        }

        public Receptionist_Cust(int sti, string urg)
        {
            serTypeIndex = sti;
            urgency = urg;
        }

        public Receptionist_Cust(string cn, string ss, string urg, int sf)
        {
            custName = cn;
            service_selected = ss;
            urgency = urg;
            serFee = sf;
        }

        public Receptionist_Cust()
        {

        }

        public string addCust()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Account where username = '" + custName + "'", con);
            
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                status = "This Customer already exist!\nPlease create a different Customer username!!!";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("insert into Account (username, password, role) values(@name, @password, 'Customer')", con);
                cmd2.Parameters.AddWithValue("@name", custName);
                cmd2.Parameters.AddWithValue("@password", custPwd);

                int i = cmd2.ExecuteNonQuery();
                if (i != 0)
                    status = "Registration Successful.";
                else
                    status = "Unable to register.";
            }
            con.Close();
            return status;
        }

        public static ArrayList addCustCbo()
        {
            ArrayList cust_usnm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from Account where role = 'Customer'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cust_usnm.Add(rd.GetString(0));
            }
            con.Close();
            return cust_usnm;
        }

        public int showPrice()
        {
            int price = 0;

            if (urgency == "Normal")
            {
                if (serTypeIndex == 0)
                {
                    price = 50;
                }
                else if (serTypeIndex == 1)
                {
                    price = 60;
                }
                else if (serTypeIndex == 2)
                {
                    price = 380;
                }
                else if (serTypeIndex == 3)
                {
                    price = 160;
                }
                else if (serTypeIndex == 4)
                {
                    price = 180;
                }
                else if (serTypeIndex == 5)
                {
                    price = 100;
                }
                else if (serTypeIndex == 6)
                {
                    price = 80;
                }
                else if (serTypeIndex == 7)
                {
                    price = 70;
                }
            }
            else if (urgency == "Urgent")
            {
                if (serTypeIndex == 0)
                {
                    price = 80;
                }
                else if (serTypeIndex == 1)
                {
                    price = 90;
                }
                else if (serTypeIndex == 2)
                {
                    price = 430;
                }
                else if (serTypeIndex == 3)
                {
                    price = 200;
                }
                else if (serTypeIndex == 4)
                {
                    price = 210;
                }
                else if (serTypeIndex == 5)
                {
                    price = 150;
                }
                else if (serTypeIndex == 6)
                {
                    price = 130;
                }
                else if (serTypeIndex == 7)
                {
                    price = 100;
                }
            }

            return price;
        }

        public string addService()
        {
            string status;
            DateTime reqDate = DateTime.Now;
            con.Open();

            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + custName +"'", con);
            int user_id = int.Parse(cmd.ExecuteScalar().ToString());

            SqlCommand check = new SqlCommand("select count(*) from Service where user_id = '" + user_id + "' and paid_amount is null", con);

            int count = Convert.ToInt32(check.ExecuteScalar().ToString());

            if (count > 0)
            {
                status = "Please wait until your current service is ended";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("insert into Service (user_id, service_type, service_urgency, request_date, service_fee) values (@id, @st, @urg, @reqDate, @sf)", con);
                cmd2.Parameters.AddWithValue("@id", user_id);
                cmd2.Parameters.AddWithValue("@st", service_selected);
                cmd2.Parameters.AddWithValue("@urg", urgency);
                cmd2.Parameters.AddWithValue("@reqDate", reqDate);
                cmd2.Parameters.AddWithValue("sf", serFee);

                cmd.ExecuteNonQuery();
                int i = cmd2.ExecuteNonQuery();
                if (i != 0)
                    status = "Service is successfully created!";
                else
                    status = "Unable to create service.";
            }
            con.Close();
            return status;
        }

        public ArrayList showPayment()
        {
            ArrayList service_info = new ArrayList();

            con.Open();
            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + custName + "'", con);
            int user_id = int.Parse(cmd.ExecuteScalar().ToString());

            SqlCommand cmd2 = new SqlCommand("select service_type, service_urgency, service_fee, receipt_no, convert(varchar, laptop_collection_date, 23) as laptop_collection_date from Service where user_id = '" + user_id + "' and paid_amount is null", con);
            SqlDataReader rd = cmd2.ExecuteReader();
            while (rd.Read())
            {
                service_info.Add(rd["service_type"].ToString());
                service_info.Add(rd["service_urgency"].ToString());
                service_info.Add(rd["service_fee"].ToString());
                service_info.Add(rd["receipt_no"].ToString());
                service_info.Add(rd["laptop_collection_date"].ToString());
            }

            con.Close();
            return service_info;
        }

        public string addPaidAmount(string payFee)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("select user_id from Account where username = '" + custName + "'", con);
            int user_id = int.Parse(cmd.ExecuteScalar().ToString());

            SqlCommand cmd2 = new SqlCommand("update Service set paid_amount = '" + payFee + "' where user_id = '" + user_id + "' and paid_amount is null", con);

            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
                status = "Payment Successfully.";
            else
                status = "Unable to make payment.";
            con.Close();

            return status;
        }

        public double calBal(int sf, double pa)
        {
            int ser_fee = sf;
            double paid_amount = pa;

            double balance = paid_amount - ser_fee;

            return balance;
        }
        
    }
}
