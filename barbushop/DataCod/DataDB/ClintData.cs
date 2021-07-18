using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using barbushop.DataCod;

namespace barbushop

{
    namespace DataDB
    {
        public class ClintData
        {
            public static List<Clint> GETMuser(int UserID)
            {
                List<Clint> userinfo = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Users where UserID ='";
                Sql += UserID + "'";


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
                    Clint getInfo = new Clint();
                   getInfo.FirstName = rd["Fname"].ToString();
                    getInfo.LastName= rd["Lname"].ToString();
                    getInfo.PhoneNumber = rd["PhoneNumber"].ToString();
                    getInfo.Email = rd["Email"].ToString();
                    userinfo.Add(getInfo);
                    //barberName += " ";
                    //barberName += rd["Lname"].ToString();








                }
                Conn.Close();
                return userinfo;

            }
            public static int Getuseer(string email, string password)
            {
                int userid = 0;
                //List<Clint> listMeetings = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Users where Email ='";
                Sql += email + "' and Password ='" + password + "'";


                SqlConnection Conn = new SqlConnection();
                SqlCommand Cmd = new SqlCommand();
                SqlDataReader Dr;
                //excptions מעקב אחר חריגות
                try
                {
                    //יצרית אובייקט מסוג קונקשיין שישמש כצינור גישה לבסיס הנתונים
                    Conn.ConnectionString = ConnStr;
                    Conn.Open();//פתיחת חיבור לבסיס הנתונים
                    Cmd.Connection = Conn;//הצינור בשימוש
                    Cmd.CommandText = Sql;//שאילתה להרצה
                                          //isert/updat/delete
                    Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        userid = Convert.ToInt32(Dr["UserID"]);

                    }

                }



                catch (ThreadAbortException ex) { }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                  
                }
                Conn.Close();
                return userid;
            }
            public static int GetMuseerId(int BarbrshopId)
            {
                int userid = 0;
                //List<Clint> listMeetings = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Barbushops where BarbushopID ='";
                Sql += BarbrshopId + "'";


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


                    userid = Convert.ToInt32(rd["UserID"]);




                }
                Conn.Close();
                return userid;
            }

            public static int insertUser_data(DataCod.Clint temp)
            {
                int rtval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "FName,LName,Citye,PhoneNumber,Email,Password,gander";
                string data = "N'" + temp.FirstName + "',N'" + temp.LastName + "',N'" + temp.City + "','" + temp.PhoneNumber + "','" + temp.Email + "','" + temp.Password + "','" + temp.Gender + "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                string Sql = "insert into Users(" + fields + ")values(" + data + ")";
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
            //public static int chackingEUser(int userid)
            //{
            //    int roll = 0;

            //    string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            //    string Sql = "select * from Rolle where UserID ='";
            //    Sql += userid + "'";



            //    SqlConnection Conn = new SqlConnection();
            //    SqlCommand Cmd = new SqlCommand();
            //    SqlDataReader Dr;
            //    //excptions מעקב אחר חריגות
            //    try
            //    {
            //        //יצרית אובייקט מסוג קונקשיין שישמש כצינור גישה לבסיס הנתונים
            //        Conn.ConnectionString = ConnStr;
            //        Conn.Open();//פתיחת חיבור לבסיס הנתונים
            //        Cmd.Connection = Conn;//הצינור בשימוש
            //        Cmd.CommandText = Sql;//שאילתה להרצה
            //                              //isert/updat/delete
            //        Dr = Cmd.ExecuteReader();
            //        if (Dr.Read())
            //        {
            //            roll =Convert.ToInt32(Dr["Rolle"]);
            //        }

            //    }



            //    catch (ThreadAbortException ex) { }
            //    catch (Exception ex)
            //    {
            //        string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
            //        Cmd.CommandText = Err;
            //        Cmd.ExecuteNonQuery();

            //    }
            //    Conn.Close();
            //    return roll;
            //}
            public static int chackingMUser(int userid)
            {
                int roll = 0;
                //List<Clint> listMeetings = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Rolle where UserID ='";
                Sql += userid + "'";


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


                    roll = Convert.ToInt32(rd["Roll"]);




                }
                Conn.Close();
                return roll;
            }
            public static void updateUser(int userID,DataCod.Clint temp)
            {

                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Users set FName=" + temp.FirstName + " LName=" + temp.LastName + " Citye=" + temp.City + " PhoneNumber=" + temp.PhoneNumber + " Email=" + temp.Email  + "where UserID = @UserID", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@UserID";
                    param.Value = userID;
                    cmd.Parameters.Add(param);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
            }

            //public static int chackingMUser(int userid)
            //{
            //    int roll = 0;

            //    string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            //    string Sql = "select * from Rolle where MUserID ='";
            //    Sql += userid + "'";



            //    SqlConnection Conn = new SqlConnection();
            //    SqlCommand Cmd = new SqlCommand();
            //    SqlDataReader Dr;
            //    //excptions מעקב אחר חריגות
            //    try
            //    {
            //        //יצרית אובייקט מסוג קונקשיין שישמש כצינור גישה לבסיס הנתונים
            //        Conn.ConnectionString = ConnStr;
            //        Conn.Open();//פתיחת חיבור לבסיס הנתונים
            //        Cmd.Connection = Conn;//הצינור בשימוש
            //        Cmd.CommandText = Sql;//שאילתה להרצה
            //                              //isert/updat/delete
            //        Dr = Cmd.ExecuteReader();
            //        if (Dr.Read())
            //        {
            //            roll = Convert.ToInt32(Dr["Rolle"]);
            //        }

            //    }



            //    catch (ThreadAbortException ex) { }
            //    catch (Exception ex)
            //    {
            //        string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
            //        Cmd.CommandText = Err;
            //        Cmd.ExecuteNonQuery();
            //    }
            //    Conn.Close();

            //    return roll;
            //}



            public static List<Clint> GETuserInfo(int UserID)
            {
                List<Clint> userInfo = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Users where UserID ='";
                Sql += UserID + "'";


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

                    Clint user = new Clint();
                    user.FirstName = rd["Fname"].ToString();
                    user.LastName= rd["Lname"].ToString();
                    user.PhoneNumber= rd["PhoneNumber"].ToString();
                    user.Email= rd["Email"].ToString();

                    userInfo.Add(user);
                    //barberName += " ";
                    //barberName += rd["Lname"].ToString();








                }
                Conn.Close();
                return userInfo;

            }


        }
    }
}
        
    
   
