using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        public static object Instance { get; internal set; }

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
               
                Session["removItem"] = Request["remov"];
                if(Session["removItem"]!=null)
                {
                    carts MyCart = (carts)Session["cart"];
                    string item= (string)Session["removItem"];
                    int proID = int.Parse(item);

                    MyCart.RemoveItem(proID);
                    Session["cart"] = MyCart;
                }

                if (Session["userid"] == null)
                {
                    Response.Redirect("default.aspx");
                }

                if (Session["barbarName"] == null && Session["cityID"] == null && Session["barbarId"] == null && Session["prodId"] == null)
                {
                    Response.Redirect("userMain.aspx");
                }
            }
            Session["prodId"] = Request["prodid"];

            if (Session["cart"] != null)
            {
                carts MyCart = (carts)Session["cart"];

                var it = MyCart.Item;
                foreach (var i in it)
                {
                    if ((int)Session["productID"] == i.productId)
                    {
                        int d = i.Amuont;
                        Session["addAmunt"] = d;
                    }

                }

                shopCart.DataSource = MyCart.Item;
                shopCart.DataBind();
                tottext.Text = MyCart.culclaet().ToString();
                int newNum = 0;
                newNum = int.Parse(tottext.Text);
                TaxC totp = new TaxC();
                TotalPrice.Text = totp.taxTot(newNum).ToString();
                //newTexs.Text = totp.GetTax().ToString();

            }
            else
            {
                Response.Redirect("UserProducts.aspx");
            }



        }
        protected void chckPic()
        {
            int idPduct = 0;
            idPduct = (int)Session["productID"];
            int status = 0;
            int amunt = 0;
            amunt = int.Parse((string)Session["amunt"]);
            string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            string fields = "UserID,BarbushopID,Status,OrderStatus";
            string data = "N'" + Session["Login"] + "',N'" + Session["barbarId"] + "','" + status + "','" + status + "'";

            // הגדרת צינור לחיבור לבסיס הנתונים
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnStr;
            Conn.Open();

            // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            string Sql = "insert into Orderss(" + fields + ")values(" + data + ")";
            Cmd.CommandText = Sql;
            Cmd.ExecuteNonQuery();
        }
        protected void chcprod()
        {
            int OuserId = (int)Session["userid"];
            int oStatus = 0;
            int OrderStatus = 4;
            string bar= (string)Session["barbarId"];
            int ObarbaShopId = int.Parse(bar);
            Orderss ordr = new Orderss();
            List<Orderss> listUOrderss = new List<Orderss>();
            listUOrderss = ordr.chackOrders(OuserId);
            for(int j =0; j<=listUOrderss.Count;)
            {
                if(listUOrderss.Count==0)
                {
                    ordr.insertNewOrders(OuserId, ObarbaShopId,OrderStatus);
                    
                    j++;
                }
                listUOrderss = ordr.chackOrders(OuserId);
                if (listUOrderss.Count != 0)
                { break; }
                    
              
            }
            Orderss getorder = new Orderss();
            List<Orderss> listUOrderss1 = new List<Orderss>();
            listUOrderss1 = getorder.GetUserOrders(OuserId);
            for (int i = 0; i < listUOrderss1.Count; i++)
            {


                Session["orderid"] = listUOrderss1[i].OrderID;
                GoOverProductsId();
                break;
            }





        }
        protected void GoOverProductsId()
        {
            Orderss finshOrder = new Orderss();
            int orderid = (int)Session["orderid"];
            carts MyCart = (carts)Session["cart"];
            if (MyCart != null)
            {
                var it = MyCart.Item;
                foreach (var i in it)
                {
                    int proid = i.productId;
                    int amunt = i.Amuont;
                    finshOrder.finshOrder(orderid, proid, amunt);



                }
                updateData();
            }


        }
        
        protected void updateData()
        {
            int retva = 0;
            int orderid = (int)Session["orderid"];

            string barbername = "";
            string phonNumber = "";
            string userName = "";
            Orderss uporder = new Orderss();
            retva=uporder.updateOrdersData(orderid,1);
            Orderss sendUser = new Orderss();
            List<Orderss> userinfo = new List<Orderss>();
            userinfo = sendUser.GETuserInfoByOrderid(orderid);
            for (int i = 0; i < userinfo.Count; i++)
            {
                userName = userinfo[i].FirstName;
                userName += " ";
                userName += userinfo[i].LastName;
                phonNumber = userinfo[i].PhoneNumber;
                barbername = userinfo[i].BarbName;

            }
            if (retva == 1)
            {

                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);
                General.GlobalFunc.SendSMSAsync(phonNumber, barbername + "  נוצרה הזמנה חדשה על ידיי:!", userName);

                Session["cart"] = null;
                
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }

        }
        protected void orderF_Click(object sender, EventArgs e)
        {

            chcprod();
            //ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

        }
    }
}

