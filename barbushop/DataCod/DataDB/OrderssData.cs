using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace barbushop
{
    namespace DataDB
    {
        public class OrderssData
        {

            public static int insertNewOrders(int userId,int barbaShopId,int Status)
            {
                int reval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "UserID,BarbushopID,StatusID";
                string data = "N'" +userId + "',N'" +barbaShopId + "','" + Status+ "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                string Sql = "insert into Orderss(" + fields + ")values(" + data + ")";
                try
                {
                    Cmd.CommandText = Sql;
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                    Cmd.CommandText = Err;
                    Cmd.ExecuteNonQuery();
                    return reval;
                }
                return reval = 1;
            }
            public static List<Orderss> chackOrders(int UserId)
            {
                List<Orderss> listOrderss = new List<Orderss>();
                
                int status = 4;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Orderss where UserID = '";
                Sql += UserId + "' and StatusID ='" + status+ "'";
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
                    Orderss order = new Orderss();
                    order.OrderID = Convert.ToInt32( rd["OrderID"]);
                    order.OrderDate = rd["OrderDate"].ToString();
                    order.DeliveryDate = rd["DeliveryDate"].ToString();
                    order.Status = Convert.ToInt32(rd["StatusID"]);
                    order.UserID = Convert.ToInt32(rd["UserID"]);
                    
                    listOrderss.Add(order);
                }

                return listOrderss;
                //if (data.Rows.Count == 0)
                //{
                //    insertNewOrders(int);
                //    chcprod();
                //}
                //else
                //{
                //    foreach (DataRow row in data.Rows)
                //    {
                //        //Session["updatAMUNT"] = row["Amut"];
                //        //Session["newprice"] = row["TotalPrice"];
                //        Session["orderid"] = row["OrderID"];
                //        GoOverProductsId();
                //    }
                //}



            }
            public static List<Orderss> GetUserOrders(int UserId)
            {
                List<Orderss> listOrderss = new List<Orderss>();

                int status = 4;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Orderss where UserID = '";
                Sql += UserId + "' and StatusID ='" + status + "'";
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
                    Orderss order = new Orderss();
                    order.OrderID = Convert.ToInt32(rd["OrderID"]);
                    order.OrderDate = rd["OrderDate"].ToString();
                    order.DeliveryDate = rd["DeliveryDate"].ToString();
                    order.Status = Convert.ToInt32(rd["StatusID"]);
                    order.UserID = Convert.ToInt32(rd["UserID"]);

                    listOrderss.Add(order);
                }

                return listOrderss;
                //if (data.Rows.Count == 0)
                //{
                //    insertNewOrders(int);
                //    chcprod();
                //}
                //else
                //{
                //    foreach (DataRow row in data.Rows)
                //    {
                //        //Session["updatAMUNT"] = row["Amut"];
                //        //Session["newprice"] = row["TotalPrice"];
                //        Session["orderid"] = row["OrderID"];
                //        GoOverProductsId();
                //    }
                //}



            }
            public static List<Orderss> GetManagerOrders(int UserId)
            {
                List<Orderss> listOrderss = new List<Orderss>();

                int status = 1;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Orderss where UserID = '";
                Sql += UserId + "' and StatusID ='" + status + "'";
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
                    Orderss order = new Orderss();
                    order.OrderID = Convert.ToInt32(rd["OrderID"]);
                    order.OrderDate = rd["OrderDate"].ToString();
                    order.DeliveryDate = rd["DeliveryDate"].ToString();
                    order.Status = Convert.ToInt32(rd["Status"]);
                    order.UserID = Convert.ToInt32(rd["UserID"]);

                    listOrderss.Add(order);
                }

                return listOrderss;
                //if (data.Rows.Count == 0)
                //{
                //    insertNewOrders(int);
                //    chcprod();
                //}
                //else
                //{
                //    foreach (DataRow row in data.Rows)
                //    {
                //        //Session["updatAMUNT"] = row["Amut"];
                //        //Session["newprice"] = row["TotalPrice"];
                //        Session["orderid"] = row["OrderID"];
                //        GoOverProductsId();
                //    }
                //}



            }


            public static void finshOrder(int orderid, int productid, int amunt)
            {

                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "OrderID,ProductsID,Amunt";
                string data = "N'" + orderid + "',N'" + productid + "',N'" + amunt + "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();

                // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                string Sql = "insert into ProductsOrders(" + fields + ")values(" + data + ")";
                Cmd.CommandText = Sql;
                Cmd.ExecuteNonQuery();
            }
            public static int updateOrdersData(int orderID,int status)
            {

                int reval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    
                    SqlCommand cmd = new SqlCommand
                             ("update Orderss set StatusID=" + status+  "  where OrderID = @OrderID", con);
                    SqlParameter param = new SqlParameter("@OrderID", orderID);
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
            public static void updateOrdersFinsh(int orderID)
            {
                int status = 1;

                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Orderss set Status=" + status + "  where OrderID = @OrderID", con);
                    SqlParameter param = new SqlParameter("@OrderID", orderID);
                    cmd.Parameters.Add(param);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
            }

            public static int OrderCencel(int orderId)
            {
                int reval = 0;

                int p = orderId;
                int status = 6;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Orderss set StatusID=" + status + "  where OrderID = @OrderID", con);
                    SqlParameter param = new SqlParameter("@OrderID", p);

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
                    //string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                    //string fields = "Status";
                    //string data = "'" + status + "'";

                    //// הגדרת צינור לחיבור לבסיס הנתונים
                    //SqlConnection Conn = new SqlConnection();
                    //Conn.ConnectionString = ConnStr;
                    //Conn.Open();

                    //// ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                    //SqlCommand Cmd = new SqlCommand();
                    //Cmd.Connection = Conn;
                    //string Sql = "update  Meetings set(" + fields + ")values(" + data + ") where MeetingID ="+p+" ' ";
                    //Cmd.CommandText = Sql;
                    //Cmd.ExecuteNonQuery();

                }
            }
            public static List<Orderss> GETOrderprodcts(int barbarshopID)
            {
                List<Orderss> prod = new List<Orderss>();
                int prodid = barbarshopID;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), OrderDate, 120)as date from Productss p join ProductsOrders po on p.ProductsID=po.ProductsID join Orderss o on o.OrderID=po.OrderID join Users u on o.UserID=u.UserID join Citys c on c.cityID=u.Citye join OrderStatuss os on o.StatusId=os.StatusID where o.BarbushopID = '";
                Sql += prodid + "'";
                
                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                    orderPro.FirstName = rd["FName"].ToString();
                    orderPro.LastName = rd["LName"].ToString();
                    orderPro.Email = rd["Email"].ToString();
                    orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Name"].ToString();
                    orderPro.OrderID= Convert.ToInt32( rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);

                    prod.Add(orderPro);
                }
                return prod;
            }
            public static List<Orderss> GETOrderprodctsConfirm(int barbarshopID)
            {
                List<Orderss> prod = new List<Orderss>();
                int prodid = barbarshopID;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), OrderDate, 103)as date from Orderss o join Users u on o.UserID = u.UserID join Citys c on c.cityID = u.Citye join OrderStatuss os on o.StatusId = os.StatusID where o.BarbushopID = '";
                Sql += prodid + "'";
                Sql += "and o.StatusID != 0";
                Sql += "and o.StatusID != 1";
                Sql += "and o.StatusID != 3";
                Sql += "and o.StatusID != 5";
                Sql += "and o.StatusID != 6";
                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                    orderPro.FirstName = rd["FName"].ToString();
                    orderPro.LastName = rd["LName"].ToString();
                    orderPro.Email = rd["Email"].ToString();
                    orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Name"].ToString();
                    orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);

                    prod.Add(orderPro);
                }
                return prod;
            }
            public static List<Orderss> GETOrderprodctsPaid(int barbarshopID)
            {
                List<Orderss> prod = new List<Orderss>();
                int prodid = barbarshopID;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), OrderDate, 103)as date from Orderss o join Users u on o.UserID=u.UserID join Citys c on c.cityID=u.Citye join OrderStatuss os on o.StatusId=os.StatusID where o.BarbushopID='";
                Sql += prodid + "'";
                Sql += "and o.StatusID != 0";
                Sql += "and o.StatusID != 1";
                Sql += "and o.StatusID != 5";
                Sql += "and o.StatusID != 2";
                Sql += "and o.StatusID != 6";
                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                    orderPro.FirstName = rd["FName"].ToString();
                    orderPro.LastName = rd["LName"].ToString();
                    orderPro.Email = rd["Email"].ToString();
                    orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Name"].ToString();
                    orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);

                    prod.Add(orderPro);
                }
                return prod;
            }
            public static List<Orderss> GETOrderprodctsCanceled(int barbarshopID)
            {
                List<Orderss> prod = new List<Orderss>();
                int prodid = barbarshopID;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), OrderDate, 103)as date from Orderss o join Users u on o.UserID=u.UserID join Citys c on c.cityID=u.Citye join OrderStatuss os on o.StatusId=os.StatusID where o.BarbushopID='";
                Sql += prodid + "'";
                Sql += "and o.StatusID != 1";
                Sql += "and o.StatusID != 3";
                Sql += "and o.StatusID != 2";
                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                    orderPro.FirstName = rd["FName"].ToString();
                    orderPro.LastName = rd["LName"].ToString();
                    orderPro.Email = rd["Email"].ToString();
                    orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Name"].ToString();
                    orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);

                    prod.Add(orderPro);
                }
                return prod;
            }
            public static List<Orderss> GETOrderprodctsByOrder(int OrderID)
            {
                List<Orderss> prod = new List<Orderss>();
                int prodid = OrderID;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), OrderDate, 103)as date from Productss p join ProductsOrders po on p.ProductsID=po.ProductsID join Orderss o on o.OrderID=po.OrderID join Users u on o.UserID=u.UserID join Citys c on c.cityID=u.Citye join OrderStatuss os on o.StatusId=os.StatusID where o.OrderID = '";
                Sql += prodid + "'";
              
                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                    orderPro.FirstName = rd["FName"].ToString();
                    orderPro.LastName = rd["LName"].ToString();
                    orderPro.Email = rd["Email"].ToString();
                    orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
                    orderPro.ProdName = rd["ProdName"].ToString();
                    orderPro.ProdCapacity = Convert.ToInt32(rd["ProdCapacity"]);
                    orderPro.amunt = Convert.ToInt32(rd["Amunt"]);
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Name"].ToString();
                    orderPro.ProdPicname = rd["ProdPicname"].ToString();
                    orderPro.ProdPriceType = Convert.ToDouble(rd["ProdPriceType"]);
                    orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);
                    orderPro.productId = Convert.ToInt32(rd["ProductsID"]);

                    prod.Add(orderPro);
                }
                return prod;
            }
            public static List<Orderss> GETOrderprodctsTest(int barbarshopID)
            {
                List<Orderss> prod = new List<Orderss>();
                int prodid = barbarshopID;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * ,convert(varchar(10), OrderDate, 103)as date from Orderss o join Users u on o.UserID=u.UserID join Citys c on c.cityID=u.Citye join OrderStatuss os on o.StatusId=os.StatusID where o.BarbushopID='";
                Sql += prodid + "'";
                Sql += "and o.StatusID != 0";
                Sql += "and o.StatusID != 2";
                Sql += "and o.StatusID != 5";
                Sql += "and o.StatusID != 3";
                Sql += "and o.StatusID != 6";
                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                    orderPro.FirstName = rd["FName"].ToString();
                    orderPro.LastName = rd["LName"].ToString();
                    orderPro.Email = rd["Email"].ToString();
                    orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Name"].ToString();
                    orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);

                    prod.Add(orderPro);
                }
                return prod;
            }
            public static List<Orderss> GETOrderprodctsbyEMai(int barbarshopID,string Email)
            {
                List<Orderss> prod = new List<Orderss>();
                int prodid = barbarshopID;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), OrderDate, 103)as date from Orderss o join Users u on o.UserID = u.UserID join Citys c on c.cityID = u.Citye join OrderStatuss os on o.StatusId = os.StatusID where o.BarbushopID = '";
                Sql += prodid + "'";
                Sql += "and u.Email='";
                Sql += Email + "'";
                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                    orderPro.FirstName = rd["FName"].ToString();
                    orderPro.LastName = rd["LName"].ToString();
                    orderPro.Email = rd["Email"].ToString();
                    orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Name"].ToString();
                    orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);

                    prod.Add(orderPro);
                }
                return prod;
            }

            public static List<Orderss> GETuserInfoByOrderid(int Orederid)
            {
                List<Orderss> userInfo = new List<Orderss>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Users u join Orderss o on u.UserID=o.UserID join Barbushops b on b.BarbushopID=o.BarbushopID where OrderID ='";
                Sql += Orederid + "'";


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

                    Orderss user = new Orderss();
                    user.FirstName = rd["Fname"].ToString();
                    user.LastName = rd["Lname"].ToString();
                    user.PhoneNumber = rd["PhoneNumber"].ToString();
                    user.Email = rd["Email"].ToString();
                    user.BarbName = rd["BarbName"].ToString();
                    user.pHonNumber = rd["phonNumber"].ToString();
                    userInfo.Add(user);
                    //barberName += " ";
                    //barberName += rd["Lname"].ToString();








                }
                Conn.Close();
                return userInfo;

            }

            public static List<Orderss> GETOrderprodctsUser(int userid)
            {
                List<Orderss> prod = new List<Orderss>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select *,convert(varchar(10), OrderDate, 103)as date from Orderss o join Users u on o.UserID=u.UserID join Barbushops b on b.BarbushopID=o.BarbushopID join Citys c on c.cityID=u.Citye join OrderStatuss os on o.StatusId=os.StatusID where o.UserID = '";
                Sql += userid + "'";
                Sql += "and o.StatusID != 0";
                Sql += "and o.StatusID != 5";

                Sql += "order by o.DeliveryDate ";
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
                    Orderss orderPro = new Orderss();
                  
                  
                    orderPro.pHonNumber = rd["phonNumber"].ToString();
                    orderPro.OrderDate = rd["date"].ToString();
                    orderPro.Address = rd["Address"].ToString();
                    orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);
                    orderPro.orderStatus = rd["Status"].ToString();
                    orderPro.BarbName = rd["BarbName"].ToString();
                    orderPro.StatusID = Convert.ToInt32(rd["StatusID"]);
                    prod.Add(orderPro);
                }
                return prod;
            }

            //public static List<Orderss> GETOrderprodctsConfirm(int barbarshopID)
            //{
            //    List<Orderss> prod = new List<Orderss>();
            //    int prodid = barbarshopID;
            //    string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            //    string Sql = "select * from Productss p join ProductsOrders po on p.ProductsID=po.ProductsID join Orderss o on o.OrderID=po.OrderID join Users u on o.UserID=u.UserID join Citys c on c.cityID=u.Address where o.BarbushopID = '";
            //    Sql += prodid + "'";
            //    Sql += "and o.Status = 1";
            //    Sql += "order by o.DeliveryDate ";
            //    // הגדרת צינור לחיבור לבסיס הנתונים
            //    SqlConnection Conn = new SqlConnection();
            //    Conn.ConnectionString = ConnStr;
            //    Conn.Open();

            //    // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
            //    SqlCommand Cmd = new SqlCommand();
            //    Cmd.Connection = Conn;
            //    Cmd.CommandText = Sql;
            //    SqlDataReader rd = Cmd.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        Orderss orderPro = new Orderss();
            //        orderPro.FirstName = rd["FName"].ToString();
            //        orderPro.LastName = rd["LName"].ToString();
            //        orderPro.Email = rd["Email"].ToString();
            //        orderPro.PhoneNumber = rd["PhoneNumber"].ToString();
            //        orderPro.ProdName = rd["ProdName"].ToString();
            //        orderPro.ProdCapacity = Convert.ToInt32(rd["ProdCapacity"]);
            //        orderPro.amunt = Convert.ToInt32(rd["Amunt"]);
            //        orderPro.OrderDate = rd["OrderDate"].ToString();
            //        orderPro.Address = rd["Name"].ToString();
            //        orderPro.ProdPicname = rd["ProdPicname"].ToString();
            //        orderPro.ProdPriceType = Convert.ToDouble(rd["ProdPriceType"]);
            //        orderPro.OrderID = Convert.ToInt32(rd["OrderID"]);


            //        prod.Add(orderPro);
            //    }
            //    return prod;
            //}

            public static void updateOrdersFinshConfirmData(int orderID)
            {
                int status = 2;

                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Orderss set Status=" + status + "  where OrderID = @OrderID ", con);
                    SqlParameter param = new SqlParameter("@OrderID", orderID);
                    cmd.Parameters.Add(param);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            //public static void insertOrdert(int amunt, int status,int ProductID)
            //{

            //    int idPduct = 0;
            //    idPduct = (int)Session["productID"];
            //    int status = 0;
            //    int amunt = 0;
            //    amunt = int.Parse((string)Session["amunt"]);
            //    string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            //    string fields = "UserID,BarbushopID,Status,OrderStatus";
            //    string data = "N'" + Session["Login"] + "',N'" + Session["barbarId"] + "','" + status + "','" + status + "'";

            //    // הגדרת צינור לחיבור לבסיס הנתונים
            //    SqlConnection Conn = new SqlConnection();
            //    Conn.ConnectionString = ConnStr;
            //    Conn.Open();

            //    // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
            //    SqlCommand Cmd = new SqlCommand();
            //    Cmd.Connection = Conn;
            //    string Sql = "insert into Orderss(" + fields + ")values(" + data + ")";
            //    Cmd.CommandText = Sql;
            //    Cmd.ExecuteNonQuery();
            //}
            public static List<Orderss> GetProductId(int OrderID)
            {

                List<Orderss> ordersses = new List<Orderss>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Productss s join ProductsOrders ps on s.ProductSID=ps.ProductSID where OrderID= '";
                Sql += OrderID + "'";


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

                    Orderss productId = new Orderss();

                    productId.productId = Convert.ToInt32(rd["ProductsID"]);
                    productId.amunt= Convert.ToInt32(rd["Amunt"]);
                    productId.ProdCapacity = Convert.ToInt32(rd["ProdCapacity"]);
                    ordersses.Add(productId);

                }
                Conn.Close();
                return ordersses;
            }

        }

    }
}