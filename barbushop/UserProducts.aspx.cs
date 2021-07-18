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
    public partial class UserProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["userid"] == null)
                {
                    Response.Redirect("default.aspx");
                }

                if (Session["barbarName"] == null && Session["cityID"] == null && Session["barbarId"] == null)
                {
                    Response.Redirect("userMain.aspx");
                }
                FillData();
                filldatacat();
            }

        }
        protected void test()
        {
            int a = 0;
            a = 1;
        }

        protected void filldatacat()
        {
            string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            string Sql = "select * from t_cats ";


            // הגדרת צינור לחיבור לבסיס הנתונים
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnStr;
            Conn.Open();

            // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql;

            // יצירת מתאם לשליפת הנתונים ושמירתם בתוך אובייקט מסוג טבלה
            SqlDataAdapter Da = new SqlDataAdapter();
            // הגדרת אובייקט מסוג טבלה
            DataTable Dt = new DataTable();
            //הגדרת אוביקא הפקודה באמצעותו יופעל המתאם
            Da.SelectCommand = Cmd;
            //שליפת הנתונים ושמירת בתוך אובייקט מסוג טבלה
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                //dropcity.DataTextField = "Name";
                //dropcity.DataValueField = "cityID";

                //dropcity.DataSource = Dt;
                //dropcity.DataBind();
                //ListItem li = new ListItem("בחר עיר", "-1");
                //dropcity.Items.Insert(0, li);



                DropDownCat.DataTextField = "CatName";
                DropDownCat.DataValueField = "Catid";
                DropDownCat.DataSource = Dt;
                DropDownCat.DataBind();
                ListItem li = new ListItem("קטגוריות ", "-1");
                DropDownCat.Items.Insert(0, li);
            }
            else
            {


                ListItem li = new ListItem("שגיאה אנא רענן את הדף", "-1");

                DropDownCat.Items.Insert(0, li);
            }

     
            Conn.Close();
        }

        protected void FillData()
        {

            if (Session["catid"] != null && Session["catid"].ToString() != "-1")
            {
                string barid = Session["barbarId"].ToString();
            int BarbID = int.Parse(barid);
                string Catid = Session["catid"].ToString();
                int CatiD = int.Parse(Catid);
                List<product> prodCat = new List<product>();

                product producte = new product();
                prodCat = producte.GetPicNameByCat(BarbID, CatiD);
                RptprodPic.DataSource = prodCat;
                RptprodPic.DataBind();
                string prodCatName = Session["catName"].ToString();
                lblprodCat.Text = prodCatName;
            }
            else if (Session["catid"] == null || Session["catid"].ToString() == "-1")
            {
                string barid = Session["barbarId"].ToString();
                int Barid = int.Parse(barid);
                List<product> prodM = new List<product>();

                product prodm = new product();
                prodM = prodm.GetPicName(Barid);
                RptprodPic.DataSource = prodM;
                RptprodPic.DataBind();
                lblprodCat.Text = "מוצרים במספרה";
            }



        }

        protected void DropDownCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["catid"] = DropDownCat.SelectedValue;
            Session["catName"] = DropDownCat.SelectedItem;

            FillData();

        }

        protected void DropDownCat_TextChanged(object sender, EventArgs e)
        {
            Session["catid"] = DropDownCat.SelectedValue;
            Session["catName"] = DropDownCat.SelectedItem;

            FillData();
        }
    }

}
        
        
          
                
                    
                        
                    
                    
                
                
     
