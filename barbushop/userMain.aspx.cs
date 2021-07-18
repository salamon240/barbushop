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
    public partial class userMain : System.Web.UI.Page
    {
        string babrberName = "";
        protected void Page_Load(object sender, EventArgs e)
         {

            if (Session["userid"] == null)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {

                    FillData();
                    HttpCookie cookie = Request.Cookies.Get("rememberUser");
                    if(cookie!=null)
                    {
                         Session["barbarId"]= cookie["barid"].ToString();
                         Session["barbarName"]= cookie["barname"].ToString();
                        babrberName = cookie.Value.ToString();
                        BOXremember.Checked = true;
                        //Session["cityID"] = cookie["city"].ToString();
                        //filldataBarbarcok();
                    }
                    else
                    {
                        FillData();
                    }

                }


            }



        }
        protected void FillData()
        {
            // שליפת מחרוזת ההתחברות מקובץ ההגדרות בשרת
            string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            string Sql = "select * from Citys ";
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
                BarberCityS.DataTextField = "Name";
                BarberCityS.DataValueField = "cityID";
                BarberCityS.DataSource = Dt;
                BarberCityS.DataBind();
                    ListItem li = new ListItem("בחר עיר", "-1");
                BarberCityS.Items.Insert(0, li);
            }
            else
            {
                ListItem li = new ListItem("שגיאה אנא רענן את הדף", "-1");
                //dropcity.Items.Insert(0, li);
                BarberCityS.Items.Insert(0, li);
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


        protected void filldataBarbar()
        {
            string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            string Sql = "select BarbushopID,BarbName from Barbushops where cityID ='";
            Sql += Session["cityIDS"] + "'";


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



                barbername.DataTextField = "BarbName";
                barbername.DataValueField = "BarbushopID";
                barbername.DataSource = Dt;
                barbername.DataBind();
                ListItem li = new ListItem("בחר ספר", "-1");
                barbername.Items.Insert(0, li);
            }
            else
            {


                ListItem li = new ListItem("שגיאה אנא רענן את הדף", "-1");

                barbername.Items.Insert(0, li);
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
        //protected void filldataBarbarcok()
        //{
        //    string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
        //    string Sql = "select BarbushopID,BarbName from Barbushops where cityID ='";
        //    Sql += Session["cityID"] + "'";


        //    // הגדרת צינור לחיבור לבסיס הנתונים
        //    SqlConnection Conn = new SqlConnection();
        //    Conn.ConnectionString = ConnStr;
        //    Conn.Open();

        //    // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
        //    SqlCommand Cmd = new SqlCommand();
        //    Cmd.Connection = Conn;
        //    Cmd.CommandText = Sql;

        //    // יצירת מתאם לשליפת הנתונים ושמירתם בתוך אובייקט מסוג טבלה
        //    SqlDataAdapter Da = new SqlDataAdapter();
        //    // הגדרת אובייקט מסוג טבלה
        //    DataTable Dt = new DataTable();
        //    //הגדרת אוביקא הפקודה באמצעותו יופעל המתאם
        //    Da.SelectCommand = Cmd;
        //    //שליפת הנתונים ושמירת בתוך אובייקט מסוג טבלה
        //    Da.Fill(Dt);
        //    if (Dt.Rows.Count > 0)
        //    {
        //        //dropcity.DataTextField = "Name";
        //        //dropcity.DataValueField = "cityID";

        //        //dropcity.DataSource = Dt;
        //        //dropcity.DataBind();
        //        //ListItem li = new ListItem("בחר עיר", "-1");
        //        //dropcity.Items.Insert(0, li);



        //        barbername.DataTextField = "BarbName";
        //        barbername.DataValueField = "BarbushopID";
        //        barbername.DataSource = Dt;
        //        barbername.DataBind();
        //        ListItem li = new ListItem(babrberName, "-1");
        //        barbername.Items.Insert(0, li);
        //    }
        //    else
        //    {


        //        ListItem li = new ListItem("שגיאה אנא רענן את הדף", "-1");

        //        barbername.Items.Insert(0, li);
        //    }

        //    ////RptUsers.DataSource = Dt;
        //    ////RptUsers.DataBind();
        //    //String cityNum = "1";
        //    //SqlDataReader Dr = Cmd.ExecuteReader();
        //    //string txt = "";
        //    //while (Dr.Read())
        //    //{

        //    //    ListItem city = new ListItem((string)Dr["Name"],cityNum);
        //    //    dropcity.Items.Add(city);
        //    //    cityNum += "1";
        //    //    //txt += "<select >" + Dr["Name"] + "</td>";
        //    //    //txt += "<option>" + Dr["Name"] + "</option>";
        //    //    //txt += "<option>" + Dr["Name"] + "</option>";
        //    //    //txt += "<option>" + Dr["Name"] + "</option>";
        //    //    //txt += "<select >";
        //    //}
        //    //LtlUsers.Text = txt;
        //    Conn.Close();
        //}


        //protected void BarberCityS_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Response.Write("jkhkhshkhksakskhskas");
        //    Session["cityIDS"] = BarberCityS.SelectedValue;
        //    filldataBarbar();

        protected void GetMeetingsUser()
        {
            string userID = Session["userid"].ToString();
            int userId = int.Parse(userID);
            Meetings UserMett = new Meetings();
            List<Meetings> getUserMEet = new List<Meetings>();
            getUserMEet = UserMett.GetMeetingss(userId);
            for(int i =0; i<getUserMEet.Count;i++)
            {
                if(getUserMEet[i].dayLeft==2)
                {
                    
                }
            }
            
        }

        protected void BarberCityS_TextChanged(object sender, EventArgs e)
        {
            Session["cityIDS"] = BarberCityS.SelectedValue;
            filldataBarbar();
        }

        protected void BarberCityS_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session["cityIDS"] = BarberCityS.SelectedValue;

            barbername.Items.Clear();
            filldataBarbar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["barbarId"] = barbername.DataSourceID;
            //Session["barbarName"] = barbername.SelectedValue;
            Session["cityID"] = BarberCityS.SelectedValue;

            Session["barbarId"] = barbername.SelectedValue;
            Session["barbarName"] = barbername.SelectedItem;
            if(BOXremember.Checked==true)
            {
                HttpCookie cookie = new HttpCookie("rememberUser");
                cookie["barid"] = Session["barbarId"].ToString();
                cookie["barname"] = Session["barbarName"].ToString();
                cookie["city"] = Session["cityID"].ToString();
                cookie.Expires = DateTime.Now.AddDays(200);
                Response.Cookies.Add(cookie);
            }
        }

        protected void barbername_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["barbarId"] = barbername.SelectedValue;
            Session["barbarName"] = barbername.SelectedItem;
        }
    }
}
    
