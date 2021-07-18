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
        public class ProductData
        {

            public static bool Chackprod(string picName)
            {
                bool prodIn = false;
                var picname = picName;
                DataTable data = new MyDB().Where("Picname", picname).Get("Productss", "Name");
                if (data.Rows.Count > 0)
                {

                    prodIn = true;
                   
                }
                return prodIn;

            }

            public static int  MangerADDpic(DataCod.product prod)
            {
                int status = 1;
                int retval = 0;
                //var price = txtPric.Text;
                //var picname = Session["fileName"].ToString();
                //var capasti = txtCapacity.Text;
                //var cut = Session["cutid"].ToString();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string fields = "ProdName,ProdPriceType,ProdPicname,Prodnote,Prodcapacity,ProdCatId,BarbushopID,ProdStatus";
                string data = "N'" + prod.ProdName + "','" + prod.ProdPriceType + "','" + prod.ProdPicname + " ',N'" + prod.ProdNote + "','" + prod.ProdCapacity + "','" + prod.productId + "','"+prod.BarbushopID + "','" + status + "'";

                // הגדרת צינור לחיבור לבסיס הנתונים
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnStr;
                Conn.Open();



                //excptions מעקב אחר חריגות
                //try
                //{    // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                string Sql = "insert into Productss(" + fields + ")values(" + data + ")";
                Cmd.CommandText = Sql;
                Cmd.ExecuteNonQuery();

                //}
                //catch (ThreadAbortException ex) { }
                //catch (Exception ex)
                //{
                //    string Err = "insert into errlog values('" + ex.Message.Replace("'", "\"") + "')";
                //    //Cmd.CommandText = Err;
                //    //Cmd.ExecuteNonQuery();
                //    Conn.Close();
                //}
                retval = 1;
                return retval;
            }
            public static List<product> GetPicName(int barabshopID)
            {

                List<product> pic = new List<product>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Productss where BarbushopID= '";
                Sql += barabshopID + "'";


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

                    product uplodpic = new product();
                    string name = rd["ProdPicname"].ToString();
                    uplodpic.ProdPicname = name;
                    uplodpic.ProdName = rd["ProdName"].ToString();
                    uplodpic.ProdNote = rd["Prodnote"].ToString();
                    uplodpic.ProdCapacity = Convert.ToInt32(rd["ProdCapacity"]);
                    uplodpic.ProdPriceType = Convert.ToDouble(rd["ProdPriceType"]);
                    uplodpic.productId = Convert.ToInt32(rd["ProductsID"]);

                    pic.Add(uplodpic);

                }
                Conn.Close();
                return pic;
            }
            public static int updateProductNote(int productid,int barbshopid,string prodNote)
            {
                int reval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Productss set  Prodnote=N'" + prodNote + "' where ProductsID=@ProductsID and BarbushopID=@BarbushopID", con);
                    SqlParameter param = new SqlParameter();
                   
                        cmd.Parameters.Add("@ProductsID", SqlDbType.Int).Value = productid;
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
            public static int updateProductPrice(int productid, int barbshopid, double prodPrice)
            {
                int reval = 0;

                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Productss set  ProdPriceType=" + prodPrice + " where ProductsID=@ProductsID and BarbushopID=@BarbushopID", con);
                    SqlParameter param = new SqlParameter();
                    try
                    {
                        cmd.Parameters.Add("@ProductsID", SqlDbType.Int).Value = productid;
                        cmd.Parameters.Add("@BarbushopID", SqlDbType.Int).Value = barbshopid;


                        //param.ParameterName = "@ProductsID";
                        //param.ParameterName = "@BarbushopID";
                        //param.Value = productid;
                        //param.Value = barbshopid;
                        //cmd.Parameters.Add(param);
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

            public static int DeleteProduct(int productid, int barbshopid)
            {
                int reval = 0;
                int Status = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Productss set ProdStatus=" + Status +  "where ProductsID = @ProductsID and BarbushopID = @BarbushopID", con);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@ProductsID";
                    param.ParameterName = "@BarbushopID";
                    param.Value = productid;
                    param.Value = barbshopid;
                    cmd.Parameters.Add(param);
                    try { 
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
             public static List<product> GetPicByID(int ProductID)
            {

                List<product> pic = new List<product>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Productss where ProductsID= '";
                Sql += ProductID + "'";


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

                    product uplodpic = new product();
                    string name = rd["ProdPicname"].ToString();
                    uplodpic.ProdPicname = name;
                    uplodpic.ProdName = rd["ProdName"].ToString();
                    uplodpic.ProdNote = rd["Prodnote"].ToString();
                    uplodpic.ProdCapacity = Convert.ToInt32(rd["ProdCapacity"]);
                    uplodpic.ProdPriceType = Convert.ToDouble(rd["ProdPriceType"]);
                    uplodpic.productId = Convert.ToInt32(rd["ProductsID"]);

                    pic.Add(uplodpic);

                }
                Conn.Close();
                return pic;
            }
            public static int updateProductCpactiy(int productid, int barbshopid, int prodCap)
            {
                int reval = 0;
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnStr))
                {
                    SqlCommand cmd = new SqlCommand
                             ("update Productss set  Prodcapacity=" + prodCap +  "where ProductsID = @ProductsID and BarbushopID = @BarbushopID", con);
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add("@ProductsID", SqlDbType.Int).Value = productid;
                    cmd.Parameters.Add("@BarbushopID", SqlDbType.Int).Value = barbshopid;
                    try { 
                 
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

            public static List<product> GetPicNameByCat(int barabshopID,int Catid)
            {

                List<product> pic = new List<product>();
                string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
                string Sql = "select * from Productss where BarbushopID= '";
                Sql += barabshopID + "'";
                Sql += "and ProdCatId= '";
                Sql += Catid + "'";


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

                    product uplodpic = new product();
                    string name = rd["ProdPicname"].ToString();
                    uplodpic.ProdPicname = name;
                    uplodpic.ProdName = rd["ProdName"].ToString();
                    uplodpic.ProdNote = rd["Prodnote"].ToString();
                    uplodpic.ProdCapacity = Convert.ToInt32(rd["ProdCapacity"]);
                    uplodpic.ProdPriceType = Convert.ToDouble(rd["ProdPriceType"]);
                    uplodpic.productId = Convert.ToInt32(rd["ProductsID"]);

                    pic.Add(uplodpic);

                }
                Conn.Close();
                return pic;
            }
        }


    }
}