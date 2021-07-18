using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class managerMain : System.Web.UI.Page
    {
        int afterNext = 0;
        int count = 0;
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                btnUpload.Visible = false;
                FileUpload1.Visible = false;
                if (Session["Euserid"] != null)
                {
                    Session["newUSERemp"] = Session["Euserid"];
                    FillDataMeittings();
                    nextDataMeittings();
                    FillBarName();
                    FillProfile();

                }
                else
                {
                    if (Session["Muserid"] != null)
                    {
                        Session["newUSERemp"] = Session["Muserid"];
                        FillDataMeittings();
                        nextDataMeittings();
                        FillBarName();
                        FillProfile();

                    }
                    else
                    {
                        Response.Redirect("default.aspx");
                    }
                }

            }
          
        }

        protected void FillDataMeittings()
        {
            int userID = (int)Session["newUSERemp"];
            List<Meetings> listMeetings = new List<Meetings>();
            Meetings dd = new Meetings();
            listMeetings = dd.GetDayMettings(userID);
            MeetingsDay.DataSource = listMeetings;
            MeetingsDay.DataBind();
        }
        protected void nextDataMeittings()
        {
            List<Meetings> nextme = new List<Meetings>();
           
            int userID = (int)Session["newUSERemp"];
            List<Meetings> listMeetings = new List<Meetings>();
            Meetings dd = new Meetings();
            listMeetings = dd.GetDayMettings(userID);
            if(i==count)
            {
                for (; i < listMeetings.Count; i++)
                {

                    if (i == count)
                    {
                        Session["nextName"] = listMeetings[i];
                        nextme.Add(listMeetings[i]);
                        Repeater1.DataSource = nextme;
                        Repeater1.DataBind();
                        if(listMeetings.Count>5)
                        {
                            afterNext = listMeetings[i + 1].UserID;

                        }
                    }
                    else
                    {
                       Session[" count"] = i;
                        if(i>1)
                        {
                            int meeteid = listMeetings[i].MeetingID;
                            dd.DeleteMeetings(meeteid,2);
                        }
                        break;
                    }
                }
                Session[" count"] = i;


            }

        }
        protected void FillBarName()
        {
            Barabshops barName = new Barabshops();
            string barid = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barid);
            List<Barabshops> listan = new List<Barabshops>();
          string  barNames = barName.GetMname(BarID);
            RepBarName.DataSource = barName.GetMname(BarID);
            RepBarName.DataBind();
        }
        protected void nextUser_Click(object sender, EventArgs e)
        {
            i = (int)Session[" count"];
             count=(int)Session[" count"];
            nextDataMeittings();
            HttpCookie cookie = new HttpCookie("nextUser");
            cookie["cunt"] = afterNext.ToString();
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
         
        }

        protected void btnUPPic_Click(object sender, EventArgs e)
        {
            FileUpload1.Visible = true;
            btnUpload.Visible = true;
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            addpic();
            fillData();
            FillProfile();
        }

        //private void UpLoadImage()
        //{

        //    ImageButton imageButton = new ImageButton();
        //    FileInfo fileInfo = new FileInfo(Session["fileName"].ToString());
        //    Session["picname"] = fileInfo;
        //    imageButton.ImageUrl = "~/image/mainPage/Profile/" + fileInfo;
        //    imageButton.Width = Unit.Pixel(308);
        //    imageButton.Height = Unit.Pixel(308);
        //    imageButton.Style.Add("padding", "5px");
        //    imageButton.Style.Add("border-radius", "50%");
        //    imageButton.Click += new ImageClickEventHandler(btnUPPic_Click);
        //    //Panel1.Controls.Add(imageButton);
        //}
        protected void addpic()
        {

            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                Session["fileName"] = fileName;
                //Chackprod();
                //if (prodIn != true)
                //{
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/mainPage/Profile/" + fileName));
                //UpLoadImage();
                //}
            }


        }
       protected void FillProfile()
        {
            if(Session["Muserid"]!=null)
            {
                string muser = Session["Muserid"].ToString();
                int muserid = int.Parse(muser);
                Barabshops bar = new Barabshops();
                List<Barabshops> BarPicName = new List<Barabshops>();
                BarPicName = bar.GetPicName(muserid);
                //if(BarPicName == "")
                //{
                //    BarPicName = "man.jpg";
                //}
                Repeater2.DataSource = BarPicName;
                Repeater2.DataBind();
            }
            if (Session["Euserid"] != null)
            {
                string muser = Session["Euserid"].ToString();
                int muserid = int.Parse(muser);
                Barabshops bar = new Barabshops();
                List<Barabshops> BarPicName = new List<Barabshops>();
                BarPicName = bar.GetPicName(muserid);
                //if(BarPicName == "")
                //{
                //    BarPicName = "man.jpg";
                //}
                Repeater2.DataSource = BarPicName;
                Repeater2.DataBind();
            }






        }
        protected void fillData()
        {
            if (Session["Muserid"] != null)
            {
                string Muserid = Session["Muserid"].ToString();
                int mUserID = int.Parse(Muserid);
                string bARId = Session["BarabshopID"].ToString();
                int BARId = int.Parse(bARId);
                string picName = Session["fileName"].ToString();
                Barabshops roll = new Barabshops();
                int rtval = roll.updateROll(mUserID, BARId, picName);
                if (rtval == 1)
                {
                    ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);

                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

                }
            }
            if (Session["Euserid"] != null)
            {
                string Muserid = Session["Euserid"].ToString();
                int mUserID = int.Parse(Muserid);
                string bARId = Session["BarabshopID"].ToString();
                int BARId = int.Parse(bARId);
                string picName = Session["fileName"].ToString();
                Barabshops roll = new Barabshops();
                int rtval = roll.updateROll(mUserID, BARId, picName);
                if (rtval == 1)
                {
                    ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);

                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

                }
            }

        }
    }
}