using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using barbushop.DataCod;

namespace barbushop
{
    public partial class orderCut : System.Web.UI.Page
    { static int num;
        private bool booked;
        private int i;
        private bool orederEx;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Calendar1.cl)

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
                string si =Session["barbarId"].ToString();
                i=int.Parse(si);
                FillDatabarName();
                hh.Visible = false;
                confermOreder.Visible = false;
            }

          

        }

        protected void chckOreder()
        {
            var datapick = DateTime.Parse(Session["datapick"].ToString()).ToString("yyyy-MM-dd");
            var timechack = timepick.SelectedValue;
            var userBarID = Session["UserorderId"].ToString();
            DataTable data = new MyDB().Where("UserID", userBarID).Where("BarbushopID", Session["barbarId"].ToString()).Where("MeetingTime", timechack.ToString()).Where("MeetingDate", datapick).Get("Meetings", "MeetingTime");
            if(data.Rows.Count>0)
            {

                  orederEx = true;
            }
        }
        protected void chckTime()
        {
            num = 0;
            string barberId = Session["barberUserID"].ToString();
            int BarberId = int.Parse(barberId);
            var datapick = DateTime.Parse(Session["datapick"].ToString()).ToString("yyyy-MM-dd");
            var barberid = Session["barbarId"].ToString();
            DataTable data = new MyDB().Where("MeetingDate", datapick).Where("BarbushopID",barberid ).Where("MUserID", barberId).Get("Meetings", "MeetingTime");

            foreach (DataRow row in data.Rows) 
            {
                num++;
            }

                foreach (DataRow row in data.Rows)
            {


                ListItem lsd = timepick.Items.FindByValue(row["meetingTime"] + "");








                if (lsd != null || num < 21)
                {
                    timepick.Items.Remove(lsd);
                }
                else
                {
                    booked = true;
                }


            }

        }


            protected void chckdate()
        {
            booked = false;

            string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            string Sql = "select CONVERT(VARCHAR,MeetingDate,103)  from Meetings where CONVERT(varchar, MeetingDate,103) = '";
            Sql += Session["datapick"] + "'";
            // הגדרת צינור לחיבור לבסיס הנתונים
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnStr;
            Conn.Open();

            // ניצור אובייקט מסוג פקודה שמזרים שאילתות באמצעות הצינור לבסיס הנתונים
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql;
            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {

                //Response.Write("akuusuuduifwhiufhishcfisdhfisudbhisdchuisd");
                chckTime();




                //ListItem timr = new ListItem("יומן מלא בחר יום אחר", "0");
                //timepick.Items.Insert(0, timr);
                //booked = true;
           

            }
            else
            {
                booked = false;

            }
        }
        protected void FillDatabarName()
        {
            int Mid = 0;
            int barid = 0;
               barid =i;
            Clint cli = new Clint();
            Mid = cli.GetMuseerId(barid);
            Session["UserorderId"] = Session["userid"];
            Session["userbarbarshoID"] = Session["barbarId"];
            // שליפת מחרוזת ההתחברות מקובץ ההגדרות בשרת
            string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            string Sql = "select * from Users u join Rolle r on u.UserID= r.UserID where r.BarbushopID='";
            Sql +=barid+ "'";
            //string ConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            //string Sql = "select* from Barbushops b  join Users u on u.UserID = b.UserID where b.BarbushopID = '";
            //Sql += Session["barbarId"] + "'";
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
                barbarName.DataTextField = "FName";
                barbarName.DataValueField = "UserID";

                barbarName.DataSource = Dt;
                barbarName.DataBind();
                ListItem li = new ListItem("בחר ספר", "-1");
                barbarName.Items.Insert(0, li);
            }
            else
            {
                ListItem li = new ListItem("שגיאה אנא רענן את הדף", "-1");
                //dropcity.Items.Insert(0, li);
                barbarName.Items.Insert(0, li);
            }

        }

        protected void fillMetting()
        {
            string barbername = "";
            string phonNumber = "";
            int retval = 0;
            string time = timepick.SelectedValue;
            string MeetingsDate = Session["datapick"].ToString();
            string userID = Session["userid"].ToString();
            int userid = int.Parse(userID);
            string barid = Session["barbarId"].ToString();
            int BarID = int.Parse(barid);
            string hiarStyle = Session["hairStyle"].ToString();
            string MuserID = Session["barberUserID"].ToString();
            int Muserid = int.Parse(MuserID);
            int Status = 1;
            string BaraberName="";
            Clint getuesr = new Clint();
            List<Clint> newClintInfo = new List<Clint>();
            newClintInfo = getuesr.GETMuser(Muserid);
            Meetings newMeet = new Meetings();
            
            for(int i=0;i<newClintInfo.Count;i++)
            {
                BaraberName = newClintInfo[i].FirstName;

            }
            retval = newMeet.InsertMeetings(MeetingsDate, time, userid, hiarStyle, Muserid, Status, BarID, BaraberName);
            for (int i = 0; i < newClintInfo.Count; i++)
            {
                barbername = newClintInfo[i].FirstName;
                barbername += " ";
                barbername += newClintInfo[i].LastName;
                phonNumber = newClintInfo[i].PhoneNumber;

            }
            if (retval == 1)
            {

                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);

                General.GlobalFunc.SendSMSAsync(phonNumber, barbarName + " קבע תור חדש!","הלקוח ");

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }

         
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

        }
        protected void next1(object sender, EventArgs e)
        {
            Session["datapick"] = txtDate.Text;
            Session["timeSelectd"] = timepick.SelectedValue;
         
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
            
                txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
                Session["datapick"] = txtDate.Text;
                DateTime dateNow = DateTime.Parse(txtDate.Text);
                Session["dateMetting"] = dateNow;
                chckdate();
                if (timepick.Items.Count>1&& booked==false)
                {
                    timepick.Visible = true;
                ListItem timr = new ListItem("בחר שעה", "-1");
                timepick.Items.Insert(0, timr);

            }
                else
                {
                    timepick.Visible = false;
                    txtDate.Text = "יומן מלא בחר תאריך אחר";

                }
            
           


        }


        protected void timepick_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["timei"] = timepick.SelectedIndex;
            Session["timeSelectd"] = timepick.SelectedValue;
            txtDate.Text =timepick.SelectedItem.Text;
            Session["time"] = txtDate.Text;
            

        }

        protected void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["datapick"] = txtDate.Text;
                chckdate();
                if (booked == false)
                {
                    timepick.Visible = true;

                }
                else
                {
                    timepick.Visible = false;
                    txtDate.Text = "יומן מלא בחר תאריך אחר";

                }
            }

        }

        protected void Finish_order(object sender, EventArgs e)

        {
            Session["barberUserID"] = barbarName.SelectedValue;
 
            hh.Visible = true;
            confermOreder.Visible = true;
            if (longHair.Checked == true)
            {
                Session["hairStyle"] = "שיער ארוך";
            }
            else if (long1.Checked == true)
            {
                Session["hairStyle"] = "שיער ארוך + זקן";
            }
            else if (shortHair.Checked == true)
            {
                Session["hairStyle"] = "שיער קצר";
            }
            else if (short1.Checked == true)
            {
                Session["hairStyle"] = "שיער קצר + זקן";
            }
            else if (color.Checked == true)
            {
                Session["hairStyle"] = "צבע לשיער";
            }
            else if (stayling.Checked == true)
            {
                Session["hairStyle"] = "עיצוב שיער";
            }
            Session["timeSelectd"] = timepick.SelectedItem.Text;

            if (IsPostBack)
            {
                date.Text=(string)Session["datapick"] ;
                time.Text = (string)Session["timeSelectd"];
                bname.Text = (string)Session["barbaTextname"];
                styleHair.Text = (string)Session["hairStyle"];
            }





        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(longHair.Checked==true)
            {
                Session["hairStyle"] = longHair.Text;
            }
            else if(long1.Checked==true)
            {
                Session["hairStyle"] = long1.Text;
            }
            else if (shortHair.Checked == true)
            {
                Session["hairStyle"] = shortHair.Text;
            }
            else if (short1.Checked == true)
            {
                Session["hairStyle"] = short1.Text;
            }
        }

        protected void barbarName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["barbaTextname"] = barbarName.SelectedItem.Text;
            Session["barberUserID"] = barbarName.SelectedValue;
        }


        protected void barbarName_TextChanged(object sender, EventArgs e)
        {
            Session["barbaTextname"] = barbarName.SelectedItem.Text;
            Session["barberUserID"] = barbarName.SelectedValue;
        }

        protected void confermOreder_Click(object sender, EventArgs e)
        {
            orederEx = false;
            chckOreder(); 
            if (orederEx==false)
            { fillMetting();

                Response.Write("<script> alert('ההזמנה בוצעה בהצלחה')</script>");
                confermOreder.CssClass = "color:green;";
                confermOreder.BackColor = Color.Green;
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }
            else
            {
                Response.Write("<script> alert('תאריך זה כבר מוזמן')</script>");
                confermOreder.CssClass = "color:red;";
            }

        }

        protected void finshed_Click(object sender, EventArgs e)
        {
            Response.Redirect("userMain.aspx");
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            int dayoff = 0;
            string date =e.Day.Date.ToString("dd / MM / yyyy");
            List<DayOff> dayOffList = new List<DayOff>();
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            DayOff GetDays = new DayOff();
            dayOffList = GetDays.GetDays(BarID);
            for (int i = 0; i < dayOffList.Count; i++)
            {
                if(dayOffList[i].DateDayOff==date)
                {
                    e.Cell.BackColor = System.Drawing.Color.Red;
                    e.Cell.ForeColor = System.Drawing.Color.White;
                    e.Cell.Font.Bold = true;
                    e.Cell.Text = "x";
                    e.Cell.ToolTip = "הספר בחופש";
                }
            }   //if (e.Day.IsSelected.Co)
                //{
                //    Session["todayDate"] = e.Day.Date;

                //}
                if (e.Day.Date < System.DateTime.Today)
            {
                // Disable date
                e.Day.IsSelectable = false;
                // Change color of disabled date
                e.Cell.ForeColor = Color.Gray;
            }



            if (e.Day.Date.Date==Calendar1.SelectedDate && booked==true)
            {
                e.Cell.BackColor= System.Drawing.Color.Red;
                e.Cell.ForeColor = System.Drawing.Color.White;
                e.Cell.Font.Bold = true;
                e.Cell.Text = "x";
                e.Cell.ToolTip = "תאריך מלא";
                   
            }
            if (e.Day.Date.DayOfWeek == DayOfWeek.Saturday)

            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                e.Cell.ForeColor = System.Drawing.Color.Green;
                e.Day.IsSelectable = false;
            }

            if (e.Day.IsOtherMonth /*&& e.Day.Date.DayOfWeek==DayOfWeek.Friday && e.Day.Date.DayOfWeek==DayOfWeek.Saturday*/)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = Color.AliceBlue;
            }
        }
    }

}