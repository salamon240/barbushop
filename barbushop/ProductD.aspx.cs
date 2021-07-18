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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
           Session["prodId"]=Request["prodid"];
            var id = Session["prodId"];
            FillData();
            if (TextBox1.Text == "")
            {
                TextBox1.Text = "1";
            }
        }
        protected void FillData()
        {
            List<product> productss = new List<product>();
            string products = Session["prodId"].ToString();
            int proid = int.Parse(products);
            product getpro = new product();
           productss= getpro.GetPicByID(proid);

            ProdFinsh.DataSource = productss;
            ProdFinsh.DataBind();
            //// שליפת מחרוזת ההתחברות מקובץ ההגדרות בשרת
            //string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            //string Sql = "select * from Productss where ProductsID ='";
            //Sql += "" + Session["prodId"] + "'";
            //// הגדרת צינור לחיבור לבסיס הנתונים
            //SqlConnection Conn = new SqlConnection();
            //Conn.ConnectionString = ConnStr;
            //Conn.Open();

            //// ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
            //SqlCommand Cmd = new SqlCommand();
            //Cmd.Connection = Conn;
            //Cmd.CommandText = Sql;
            //// יצירת מתאם לשליפת הנתונים ושמירתם בתוך אובייקט מסוג טבלה
            //SqlDataAdapter Da = new SqlDataAdapter();
            ////הגדרת אובייקט מסוג טבלה
            //DataTable Dt = new DataTable();
            ////הגדרת אוביקא הפקודה באמצעותו יופעל המתאם
            //Da.SelectCommand = Cmd;
            ////שליפת הנתונים ושמירת בתוך אובייקט מסוג טבלה
            //Da.Fill(Dt);
            ////Da.Fill(Dt);

            //ProdFinsh.DataSource = Dt;
            //ProdFinsh.DataBind();

            //SqlDataReader Dr = Cmd.ExecuteReader();
            //string txt = "";
            //while (Dr.Read())
            //{

            //    txt += "<div class='row'>";
            //    txt += "<div class='col - md - 3 col - sm - 6'>";
            //    txt += "  <div class='product - grid9'>";
            //    txt += "<div class='product - image9'>";
            //    txt += "<a href = '#' >";
            //    txt += " <img class='pic-1' src='image/mainPage/products/" + Dr["Picname"] + "'>";
            //    txt += "</a>";
            //    txt += "<a href = '#' class='fa fa-search product-full-view'></a>";
            //    txt += "</div>";
            //    txt += "<div class='product - content'>";
            //    txt += "<ul class='rating'>";
            //    txt += " </ul>";
            //    txt += "<h4 class='title'><a href = '#' >" + Dr["Name"] + "</a></h4>";
            //    txt += "<div class='price'>" + Dr["PriceType"] + "שח" + "</div>";
            //    txt += "<div class='note'>" + Dr["note"] + "</div>";
            //    txt += "<a class='add - to - cart' href='#' onclick='getPicId' id='" + Dr["ProductsID"] + "'runnet='server' >הוסף לסל</a>";
            //    txt += "  </div>";
            //    txt += "</div>";
            //    txt += "</div>";

            //}
            //pic.Text = txt;
            //Conn.Close();
        }
        protected void chckPic()
        {
            carts car = new carts();
            carts MyCart;
            if (Session["cart"] == null)
            {
                MyCart = new carts();


            }
            else
            {
                MyCart = (carts)Session["cart"];
            }
            var id = Session["prodId"];
            DataTable data = new MyDB().Where("ProductsID", Session["prodId"].ToString()).Get("Productss", "*");
            Application["prod"] = new MyDB().Where("ProductsID", Session["prodId"].ToString()).Get("Productss", "*");
            
                //List<product>prod = (List<product>) Application["prod"];

            foreach (DataRow row in data.Rows)
            {





                Session["productID"] = row["ProductsID"];
                double Pric = (double)row["ProdPriceType"];
                int cpts = (int)row["Prodcapacity"];
                int productid = (int)row["ProductsID"];
                string picName = (string)row["ProdPicname"];
                string prodname = (string)row["ProdName"];
                string prodNote = (string)row["Prodnote"];
                int amunt = int.Parse(TextBox1.Text);
                double pr = Pric;
                Session["amunt"] = TextBox1.Text;
                //List<product> pro = new List<product>();
                if(amunt>=1)
                {
                    Item produ = new Item(productid, prodname, pr, picName, cpts, amunt);
                    car.Item.Add(produ);
                    MyCart.AddItem(produ);
                }
          

                
            
            
               
             
            }
            Session["cart"] = MyCart;

        }


        protected void addCart_Click(object sender, EventArgs e)
            {
                chckPic();
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (TextBox1.Text == num.ToString() || TextBox1.Text=="")
            {
                num = +1;
                TextBox1.Text = num.ToString();
            }
            else
            {
                num = int.Parse(TextBox1.Text);
                num += 1;
                TextBox1.Text = num.ToString();
                   
            }
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            int numb = 1;
            numb = int.Parse(TextBox1.Text);
            if(numb > num)
            {
                numb -= 1;
                TextBox1.Text = numb.ToString();
            }
            else
            {
                TextBox1.Text = numb.ToString();
            }
            
            //{ int num=
        //    TextBox1.Text += -1;
        }
    }

}