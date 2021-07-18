using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using barbushop.DataCod;


namespace barbushop
{
    namespace DataDB 
    {
        public class BarabshopsData
        {

            public static int GetbarID(int MuserID) 
            {
                int Buserid = 0;
                //List<Clint> listMeetings = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Rolle where UserID ='";
                Sql += MuserID + "'";


                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = Sql;
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        Buserid = Convert.ToInt32(rd["BarbushopID"]);
                    }
                }




                catch (ThreadAbortException ex) { }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                }   
                return Buserid; ;
            }


            public static int GetMbarID(int MuserID)
            {
                int Buserid = 0;
                //List<Clint> listMeetings = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Barbushops where UserID ='";
                Sql += MuserID + "'";


                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = Sql;
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        Buserid = Convert.ToInt32(rd["BarbushopID"]);
                    }
                }




                catch (ThreadAbortException ex) { }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                }
                return Buserid; ;
            }
            public static string GetMname(int barID)
            {
                string BarbName = "";
                //List<Clint> listMeetings = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Barbushops where BarbushopID ='";
                Sql += barID + "'";


                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                 Cmd.Connection = Conn;
                Cmd.CommandText = Sql;
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        BarbName = rd["BarbName"].ToString();
                    }
                }




                catch (ThreadAbortException ex) { }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                }
                return BarbName ;
            }


            public static int insertBarbar_data(DataCod.Barabshops temp)
                {

                    int rtval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "BarbName,Address,phonNumber,UserID,cityID";
                string data = "N'" + temp.BarbName + "',N'" + temp.Address + "',N'" + temp.pHonNumber + "',N'" + temp.MUserID + "',N'" + temp.BCity + "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                    Conn.ConnectionString = ConnStr;
                    Conn.Open();

                    // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Conn;
                    string Sql = "insert into Barbushops(" + fields + ")values(" + data + ")";
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
            public static int insertrOLL(int MuserID, int Euser, int BarID,int status)
            {

                int rtval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "BarbushopID,Roll,UserID,Status";
                string data = "N'" + BarID+ "',N'" + MuserID+ "',N'" + Euser + "',N'" + status + "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                string Sql = "insert into Rolle(" + fields + ")values(" + data + ")";
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

            public static int updateROll(int Muser, int barbshopid, string PICname)
            {
                int reval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Rolle set  BarPicName=N'" + PICname + "' where UserID=@UserID and BarbushopID=@BarbushopID", con);
                    SqlParameter param = new SqlParameter();

                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = Muser;
                    cmd.Parameters.Add("@BarbushopID", SqlDbType.Int).Value = barbshopid;
                    try
                    {
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
                    //param.ParameterName = "@ProductsID";
                    //param.ParameterName = "@BarbushopID";
                    //param.Value = productid;
                    //param.Value = barbshopid;
                    //cmd.Parameters.Add(param);


                }
            }

            public static List<Barabshops> GetPicName(int muser)
            {
                List<Barabshops> BarPicName = new List<Barabshops>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Rolle r join Users u on r.UserID=u.UserID where r.UserID ='";
                Sql += muser + "'";


                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = Sql;
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        Barabshops bar = new Barabshops();
                       bar.BarbName = rd["BarPicName"].ToString();
                        bar.FirstName = rd["FName"].ToString();
                        bar.LastName = rd["LName"].ToString();
                        bar.PhoneNumber = rd["PhoneNumber"].ToString();
                        BarPicName.Add(bar);
                    }
                }




                catch (ThreadAbortException ex) { }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                }
                return BarPicName;
            }
            public static List<Barabshops> allProfil(int barid)
            {
                List<Barabshops> BarPicName = new List<Barabshops>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Rolle r join Users u on r.UserID=u.UserID where r.BarbushopID ='";
                Sql += barid + "'";


                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = Sql;
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        Barabshops bar = new Barabshops();
                        bar.BarbName = rd["BarPicName"].ToString();
                        bar.FirstName = rd["FName"].ToString();
                        bar.LastName = rd["LName"].ToString();
                        bar.PhoneNumber = rd["PhoneNumber"].ToString();
                        BarPicName.Add(bar);
                    }
                }




                catch (ThreadAbortException ex) { }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                }
                return BarPicName;
            }

        }

    }
}