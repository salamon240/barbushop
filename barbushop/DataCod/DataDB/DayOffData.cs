using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace barbushop
{
    namespace DataDB
    {
        public class DayOffData
        {
            public static int insertrDayOff(int MuserID, string dayoff, int BarID)
            {

                int rtval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "DateDayOff,UserID,BarbushopID";
                string data = "convert(datetime ,'" + dayoff + " ',103),'" + MuserID + "','" + BarID +  "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                string Sql = "insert into DayOff(" + fields + ")values(" + data + ")";
                Cmd.CommandText = Sql;
             
                Cmd.ExecuteNonQuery();
                Conn.Close();
                //    string connect_str = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                //    SqlConnection connect_obj = new SqlConnection(connect_str);

                //    string sql = "INSERT INTO User values(@Fname,@Lname,@PhonNumber,@Email,@Password);";
                //    SqlCommand cmd = new SqlCommand();
                //    cmd.CommandText = sql;
                //    cmd.Parameters.Add(new SqlParameter("@Fname", firstName));
                //    cmd.Parameters.Add(new SqlParameter("@Lname", lastName));
                //    cmd.Parameters.Add(new SqlParameter("@PhonNumber", phonNumber));
                //    cmd.Parameters.Add(new SqlParameter("@Email", Email));
                //    cmd.Parameters.Add(new SqlParameter("@Email", City));
                //    cmd.Connection = connect_obj;
                rtval = 1;
                return rtval;
            }
            public static List<DayOff> GetDays(int Barid)
            {
                List<DayOff> listDayss = new List<DayOff>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10),DateDayOff, 103)as date,DATEDIFF(day,GETDATE(),DateDayOff)as dateNow  from Users u join DayOff d on u.UserID=d.UserID where BarbushopID= '";
                Sql += Barid + "'";
                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = Sql;
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    DayOff dayss = new DayOff();
                    dayss.DayOffID = Convert.ToInt32(rd["DayOffID"]);
                    dayss.DateDayOff =  rd["date"].ToString();
                    dayss.FirstName = rd["FName"].ToString();
                    dayss.LastName = rd["LName"].ToString();
                    dayss.PhoneNumber = rd["PhoneNumber"].ToString();
                    dayss.Email = rd["Email"].ToString();
                    dayss.UserID = Convert.ToInt32(rd["UserID"]);
                    dayss.daynow = rd["dateNow"].ToString();

                    listDayss.Add(dayss);
                }
                Conn.Close();
                return listDayss;
            }

        }

    }
}