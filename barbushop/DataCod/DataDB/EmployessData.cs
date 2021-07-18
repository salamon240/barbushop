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
        public class EmployessData
        {

            public static List<Employess> GetEmpUser(int BarbrshopId)
            {
                List<Employess> listEmp = new List<Employess>();
                //List<Clint> listMeetings = new List<Clint>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), StartDay, 103)as date from Users u join Rolle r on u.UserID=r.UserID join Citys c on c.cityID=u.Citye where BarbushopID ='";
                Sql += BarbrshopId + "'";
                Sql += "and Status =";
                Sql += 1;

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
                    Employess getEmp = new Employess();
                    getEmp.RolleId = Convert.ToInt32(rd["RolleId"]);
                    getEmp.FirstName = rd["FName"].ToString();
                    getEmp.LastName = rd["LName"].ToString();
                    getEmp.PhoneNumber = rd["PhoneNumber"].ToString();
                    getEmp.Rolle = Convert.ToInt32(rd["Roll"]);
                    getEmp.Status= Convert.ToInt32(rd["Status"]);
                    getEmp.Email= rd["Email"].ToString();
                    getEmp.Address = rd["Name"].ToString();
                    getEmp.starDay = rd["date"].ToString();
                    listEmp.Add(getEmp);



                }
                Conn.Close();
                return listEmp;
            }
            public static int DeleteEmp(int EmpID)
            {
                int reval = 0;

                int status = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Rolle set Status=" + status + "  where RolleId = @RolleId", con);
                    SqlParameter param = new SqlParameter("@RolleId", EmpID);
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


        }


    }
}