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
    public partial class ManagerPIc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["BarabshopID"] != null) 
                {
                    if(Session["Muserid"] != null || Session["Euserid"] != null)
                    {
                        filldatacat();
                        FillData();
                        
                    }
                    
                }
                else
                {
                    Response.Redirect("managerMain.aspx");
                }
                
            }


        }

        protected void FillData()
        {
            if(Session["catid"]!=null&& Session["catid"].ToString()!="-1")
            {
                string BARid = Session["BarabshopID"].ToString();
                int BariD = int.Parse(BARid);
                string Catid = Session["catid"].ToString();
                int CatiD = int.Parse(Catid);
                List<product> prodCat = new List<product>();

                product producte = new product();
                prodCat = producte.GetPicNameByCat(BariD,CatiD);
                RptprodPic.DataSource = prodCat;
                RptprodPic.DataBind();
                string prodCatName = Session["catName"].ToString();
                lblprodCat.Text = prodCatName;
            }
            else if(Session["catid"] == null || Session["catid"].ToString() =="-1")
            {
                string barid = Session["BarabshopID"].ToString();
                int Barid = int.Parse(barid);
                List<product> prodM = new List<product>();

                product prodm = new product();
                prodM = prodm.GetPicName(Barid);
                RptprodPic.DataSource = prodM;
                RptprodPic.DataBind();
                lblprodCat.Text = "מוצרים במספרה";
            }
           

      
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

            ////RptUsers.DataSource = Dt;
            ////RptUsers.DataBind();
            //String cityNum = "1";
            //SqlDataReader Dr = Cmd.ExecuteReader();
            //string txt = "";
            //while (Dr.Read())
            //{

            //    ListItem city = new ListItem((string)Dr["Name"],cityNum);
            //    dropcity.Items.Add(city);
            //    cityNum += "1";
            //    //txt += "<select >" + Dr["Name"] + "</td>";
            //    //txt += "<option>" + Dr["Name"] + "</option>";
            //    //txt += "<option>" + Dr["Name"] + "</option>";
            //    //txt += "<option>" + Dr["Name"] + "</option>";
            //    //txt += "<select >";
            //}
            //LtlUsers.Text = txt;
            Conn.Close();
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