using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using barbushop.DataCod;
namespace barbushop
{
    namespace DataDB
    {

        public class MeetingsData
           
        {

            public static List<Meetings> GetMangerMeetingss(int Muserid) 
            {
                List<Meetings> listMeetings = new List<Meetings>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select*,convert(varchar(10), m.MeetingDate, 103)as date from Meetings m join Users u on m.UserID=u.UserID join Times t on m.MeetingTime=t.MeetingTime join MeetingsStatus ms on m.Status=ms.MstatusID where m.MUserID = '";
                Sql += Muserid + "'";
               
                Sql += "and m.Status!=3";
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
                    Meetings meetings = new Meetings();
                    meetings.MeetingID = Convert.ToInt32(rd["MeetingID"]);
                    meetings.FirstName = rd["FName"].ToString();
                    meetings.LastName = rd["LName"].ToString();
                    meetings.Time = rd["Time"].ToString();
                    meetings.MeetingDate = rd["date"].ToString();
                    meetings.PhoneNumber = rd["PhoneNumber"].ToString();
                    meetings.Email = rd["Email"].ToString();
                    meetings.HairCut = rd["HairCut"].ToString();
                    meetings.BarberName = rd["BarberName"].ToString();
                    meetings.StatusName = rd["StatusName"].ToString();
                    listMeetings.Add(meetings);
                }
                return listMeetings;
            }
            public static List<Meetings> GetBMangerMeetingss(int barID)
            {
                List<Meetings> listMeetings = new List<Meetings>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select*,convert(varchar(10),m.MeetingDate, 103)as date from Meetings m join Users u on m.UserID=u.UserID join Times t on m.MeetingTime=t.MeetingTime join MeetingsStatus ms on m.Status=ms.MstatusID where m.BarbushopID = '";
                Sql += barID + "'";
                Sql += "and m.Status!=3";
                Sql += "order by m.MeetingDate";
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
                    Meetings meetings = new Meetings();
                    meetings.MeetingID = Convert.ToInt32(rd["MeetingID"]);
                    meetings.FirstName = rd["FName"].ToString();
                    meetings.LastName = rd["LName"].ToString();
                    meetings.Time = rd["Time"].ToString();
                    meetings.MeetingDate = rd["date"].ToString();
                    meetings.PhoneNumber = rd["PhoneNumber"].ToString();
                    meetings.Email = rd["Email"].ToString();
                    meetings.HairCut = rd["HairCut"].ToString();
                    meetings.BarberName = rd["BarberName"].ToString();
                    meetings.StatusName = rd["StatusName"].ToString();
                    listMeetings.Add(meetings);
                }
                return listMeetings;
            }


            public static List<Meetings> GetMeetingss( int userid)
            {
                List<Meetings> listMeetings = new List<Meetings>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select ms.StatusName,m.BarberName, b.phonNumber,b.Address,b.BarbName,m.MeetingID,MeetingDate,m.HairCut,t.Time,DATEDIFF(day,GETDATE(),m.MeetingDate)as dateNow ,convert(varchar(10), m.MeetingDate, 103)as date from Users u join Meetings m on u.UserID=m.UserID join Barbushops b on m.BarbushopID=b.BarbushopID join Times t on t.MeetingTime=m.MeetingTime  join Rolle r on b.UserID=r.UserID join MeetingsStatus ms on m.Status=ms.MstatusID where u.UserID = '";
                Sql += userid + "'";
                Sql += "and m.Status!=4";
                Sql += "order by m.MeetingDate";
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
                    Meetings meetings = new Meetings();
                    meetings.MeetingID = Convert.ToInt32(rd["MeetingID"]);
                    meetings.HairCut = rd["HairCut"].ToString();
                    meetings.Time = rd["Time"].ToString();
                    meetings.MeetingDate = rd["date"].ToString();
                    meetings.pHonNumber = rd["phonNumber"].ToString();
                    meetings.Address = rd["Address"].ToString();
                    meetings.BarbName = rd["BarbName"].ToString();
                    meetings.dayLeft = Convert.ToInt32(rd["dateNow"]);
                    meetings.BarberName = rd["BarberName"].ToString();
                    meetings.StatusName = rd["StatusName"].ToString();
                    listMeetings.Add(meetings);
                }
                return listMeetings;
            }
            public static int DeleteMeetings(int MeetingID ,int status)
            {
                int reval = 0;
              
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Meetings set Status=" + status + "  where MeetingID = @MeetingsID", con);
                    SqlParameter param = new SqlParameter("@MeetingsID", MeetingID);
                    try
                    {
                        cmd.Parameters.Add(param);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                        cmd.CommandText = Err;
                        cmd.ExecuteNonQuery();
                        return reval = 0;
                    }
                    return reval = 1;
                }
            }
            public static List<Meetings> GetDayMettings(int userId)
            {
                List<Meetings> listMeetings = new List<Meetings>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select u.UserID, u.FName,u.LName,u.Email,u.PhoneNumber,m.HairCut,t.Time,m.MeetingDate,DATEDIFF(day,m.MeetingDate,GETDATE())as dateNow from Users u join Meetings m on u.UserID = m.UserID join Times t on m.MeetingTime = t.MeetingTime join MeetingsStatus ms on m.Status=ms.MstatusID where m.MUserID = '";
                Sql += userId + "'";
                Sql += "and DATEDIFF(day,m.MeetingDate,GETDATE())=0";
                Sql += "and m.Status!=3";
                Sql += "and m.Status!=4";
                Sql += "order by t.Time ";
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
                    Meetings meetings = new Meetings();
                    meetings.FirstName = rd["FName"].ToString();
                    meetings.LastName = rd["LName"].ToString();
                    meetings.Email = rd["Email"].ToString();
                    meetings.PhoneNumber = rd["PhoneNumber"].ToString();
                    meetings.HairCut = rd["HairCut"].ToString();
                    meetings.Time = rd["Time"].ToString();
                    meetings.UserID = Convert.ToInt32(rd["UserID"]);

                    listMeetings.Add(meetings);
                }
                return listMeetings;

            }
            public static List<Meetings> GetDayMettingsUser(int Barid)
            {
                List<Meetings> listMeetings = new List<Meetings>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select m.UserID ,m.MUserID ,u.FName,u.LName,u.Email,u.PhoneNumber,m.HairCut,t.Time,m.MeetingDate,DATEDIFF(day,m.MeetingDate,GETDATE())as dateNow from Users u join Meetings m on u.UserID = m.UserID join Times t on m.MeetingTime = t.MeetingTime join MeetingsStatus ms on m.Status=ms.MstatusID where m.BarbushopID = '";
                Sql += Barid + "'";
                Sql += "and m.Status!=3";
                Sql += "and DATEDIFF(day,m.MeetingDate,GETDATE())=0";
                Sql += "order by t.Time ";
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
                    Meetings meetings = new Meetings();
                    meetings.FirstName = rd["FName"].ToString();
                    meetings.LastName = rd["LName"].ToString();
                    meetings.Email = rd["Email"].ToString();
                    meetings.pHonNumber = rd["PhoneNumber"].ToString();
                    meetings.HairCut = rd["HairCut"].ToString();
                    meetings.Time = rd["Time"].ToString();
                    meetings.MUserID = Convert.ToInt32(rd["MUserID"]);
                    meetings.UserID= Convert.ToInt32(rd["UserID"]);

                    listMeetings.Add(meetings);
                }
                return listMeetings;

            }
            public static int InsertMeetings(string Meetingdate, string MeetingTime, int userID, string HairCut, int MUserID, int Status,int barid,string barberName)
            {
                int retval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "MeetingDate,MeetingTime,BarbushopID,UserID,HairCut,MUserID,Status,BarberName";
                string data = "convert(datetime ,'" + Meetingdate + " ',103),'" + MeetingTime + "','" + barid + "','" + userID + "',N'" + HairCut + "',N'" + MUserID + "','" + Status + "',N'" + barberName + "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                string Sql = "insert into Meetings(" + fields + ")values(" + data + ")";
                Cmd.CommandText = Sql;
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                    return retval;
                }
                retval = 1;
                return retval;
            }

            public static List<Meetings> GetUserByMeeting(int meetingID)
            {
                List<Meetings> listMeetings = new List<Meetings>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *  from Meetings m join Users u on m.UserID=u.UserID join Barbushops b on m.BarbushopID=b.BarbushopID  where m.MeetingID='";
                Sql += meetingID + "'";
              
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
                    Meetings user = new Meetings();
                    user.FirstName = rd["Fname"].ToString();
                    user.LastName = rd["Lname"].ToString();
                    user.PhoneNumber = rd["PhoneNumber"].ToString();
                    user.Email = rd["Email"].ToString();
                    user.BarbName = rd["BarberName"].ToString();
                    user.pHonNumber = rd["phonNumber"].ToString();
                    listMeetings.Add(user);

                    listMeetings.Add(user);
                }
                return listMeetings;
            }



        }



    }
   
}