using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_35_Assignment
{
    internal class Admin_Report
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static int dispCount1(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount1 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Remove virus, malware or spyware'", con);
            int count1 = Convert.ToInt32(cmdCount1.ExecuteScalar().ToString());
            con.Close();
            return count1;
        }

        public static int dispCount2(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Troubleshot and fix computer running slow'", con);
            int count2 = Convert.ToInt32(cmdCount2.ExecuteScalar().ToString());
            con.Close();
            return count2;
        }

        public static int dispCount3(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount3 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop screen replacement'", con);
            int count3 = Convert.ToInt32(cmdCount3.ExecuteScalar().ToString());
            con.Close();
            return count3;
        }

        public static int dispCount4(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount4 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop keyboard replacement'", con);
            int count4 = Convert.ToInt32(cmdCount4.ExecuteScalar().ToString());
            con.Close();
            return count4;
        }

        public static int dispCount5(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount5 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop battery replacement'", con);
            int count5 = Convert.ToInt32(cmdCount5.ExecuteScalar().ToString());
            con.Close();
            return count5;
        }

        public static int dispCount6(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount6 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Operating System Format and Installation'", con);
            int count6 = Convert.ToInt32(cmdCount6.ExecuteScalar().ToString());
            con.Close();
            return count6;
        }

        public static int dispCount7(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount7 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Data backup and recovery'", con);
            int count7 = Convert.ToInt32(cmdCount7.ExecuteScalar().ToString());
            con.Close();
            return count7;
        }

        public static int dispCount8(int m)
        {
            int month = m;
            con.Open();
            SqlCommand cmdCount8 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Internet connectivity issues'", con);
            int count8 = Convert.ToInt32(cmdCount8.ExecuteScalar().ToString());
            con.Close();
            return count8;
        }

        public static int dispSum1(int m)
        {
            int sum1 = 0;
            int month = m;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Remove virus, malware or spyware'", con);
            SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Remove virus, malware or spyware'", con);
            int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            if (count > 0)
            {
                sum1 = int.Parse(cmd.ExecuteScalar().ToString());
            }
            else
                sum1 = 0;

            con.Close();
            return sum1;
        }

        public static int dispSum2(int m)
        {
            int sum2 = 0;
            int month = m;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Troubleshot and fix computer running slow'", con);
            SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Troubleshot and fix computer running slow'", con);
            int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            if (count > 0)
            {
                sum2 = int.Parse(cmd.ExecuteScalar().ToString());
            }
            else
                sum2 = 0;

            con.Close();
            return sum2;
        }

        public static int dispSum3(int m)
        {
            {
                int sum3 = 0;
                int month = m;
                con.Open();
                SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop screen replacement'", con);
                SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop screen replacement'", con);
                int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

                if (count > 0)
                {
                    sum3 = int.Parse(cmd.ExecuteScalar().ToString());
                }
                else
                    sum3 = 0;

                con.Close();
                return sum3;
            }
        }

        public static int dispSum4(int m)
        {
            {
                int sum4 = 0;
                int month = m;
                con.Open();
                SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop keyboard replacement'", con);
                SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop keyboard replacement'", con);
                int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

                if (count > 0)
                {
                    sum4 = int.Parse(cmd.ExecuteScalar().ToString());
                }
                else
                    sum4 = 0;

                con.Close();
                return sum4;
            }
        }

        public static int dispSum5(int m)
        {
            int sum5 = 0;
            int month = m;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop battery replacement'", con);
            SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Laptop battery replacement'", con);
            int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            if (count > 0)
            {
                sum5 = int.Parse(cmd.ExecuteScalar().ToString());
            }
            else
                sum5 = 0;

            con.Close();
            return sum5;
        }

        public static int dispSum6(int m)
        {
            int sum6 = 0;
            int month = m;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Operating System Format and Installation'", con);
            SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Operating System Format and Installation'", con);
            int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            if (count > 0)
            {
                sum6 = int.Parse(cmd.ExecuteScalar().ToString());
            }
            else
                sum6 = 0;

            con.Close();
            return sum6;
        }

        public static int dispSum7(int m)
        {
            int sum7 = 0;
            int month = m;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Data backup and recovery'", con);
            SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Data backup and recovery'", con);
            int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            if (count > 0)
            {
                sum7 = int.Parse(cmd.ExecuteScalar().ToString());
            }
            else
                sum7 = 0;

            con.Close();
            return sum7;
        }

        public static int dispSum8(int m)
        {
            int sum8 = 0;
            int month = m;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Internet connectivity issues'", con);
            SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'AND service_type = 'Internet connectivity issues'", con);
            int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            if (count > 0)
            {
                sum8 = int.Parse(cmd.ExecuteScalar().ToString());
            }
            else
                sum8 = 0;

            con.Close();
            return sum8;
        }

        public static int addIncome(int m)
        {
            int sum = 0;
            int month = m;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(service_fee) from Service where MONTH(request_date) = '" + month + "'", con);
            SqlCommand cmd2 = new SqlCommand("select count (*) from Service where MONTH(request_date) = '" + month + "'", con);
            int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

            if (count > 0)
            {
                sum = int.Parse(cmd.ExecuteScalar().ToString());
            }
            else
                sum = 0;

            con.Close();
            return sum;
        }
    }
}
