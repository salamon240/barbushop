using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        bool num = false;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userid"] == null&& Session["barbarId"]==null)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                  HttpCookie cookie=  Request.Cookies.Get("nextUser");
                    if(cookie!=null)
                    {
                        int num2 = int.Parse(cookie["cunt"]);


                        int useridmet = (int)Session["userid"];
                        string barid = Session["barbarId"].ToString();
                        int userID = int.Parse(barid);
                        List<Meetings> listMeetings = new List<Meetings>();
                        Meetings dd = new Meetings();
                        listMeetings = dd.GetDayMettingsUser(userID);
                   for (int i=0;i<listMeetings.Count;i++)
                        {
                            if(num==false)
                            {
                                if (listMeetings[i].UserID == num2)
                                {
                                    Response.Write("<script>alert('התור שלך עוד 2 אנשים')</script>");
                                    num = true;
                                }
                                else
                                {


                                }
                            }
                         

                        }

                    }
                    GetMeetingsUser();
                   
                }
            }

                    

        }
        protected void GetMeetingsUser()
        {
            string barbername = "";
            string phonNumber = "";
            string bphonNumber = "";
            string userName = "";
            int MeetinId = 0;
            string userID = Session["userid"].ToString();
            int userId = int.Parse(userID);
            Meetings UserMett = new Meetings();
            List<Meetings> getUserMEet = new List<Meetings>();
            getUserMEet = UserMett.GetMeetingss(userId);
            MetingsList.DataSource = getUserMEet;
            MetingsList.DataBind();
            for (int i = 0; i < getUserMEet.Count; )
            {
                if(getUserMEet[i].dayLeft<0)
                {
                    i++;
                }
                 else if (getUserMEet[i].dayLeft > 0)
                {

                    LabarNAME.Text = getUserMEet[i].BarbName.ToString();
                    LaHiarStyle.Text = getUserMEet[i].HairCut.ToString();
                    lblbarberName.Text = getUserMEet[i].BarberName.ToString();
                    lblHiarCutNow.Text = getUserMEet[i].dayLeft.ToString();
                    break;
                }
               else if (getUserMEet[i].dayLeft == 0)
                {
                    MeetinId = getUserMEet[i].MeetingID;
                    Meetings sendUser = new Meetings();
                    List<Meetings> userinfo = new List<Meetings>();
                    userinfo = sendUser.GetUserByMeeting(MeetinId);
                    for (int j = 0; j < userinfo.Count; j++)
                    {
                        userName = userinfo[i].FirstName;
                        userName += " ";
                        userName += userinfo[i].LastName;
                        phonNumber = userinfo[i].PhoneNumber;
                        barbername = userinfo[i].BarbName;
                        bphonNumber = userinfo[i].pHonNumber;

                    }
                    General.GlobalFunc.SendSMSAsync(phonNumber, userName + "התור שלך  היום !", barbername);

                    LabarNAME.Text = getUserMEet[i].BarbName.ToString();
                    LaHiarStyle.Text = getUserMEet[i].HairCut.ToString();
                    lblbarberName.Text = getUserMEet[i].BarberName.ToString();
                    lblHiarCutNow.Text = getUserMEet[i].dayLeft.ToString();
                    LabTody.Text = "התור שלך היום בשעה" +getUserMEet[i].Time.ToString() ;
                    break;
                }
                else if(getUserMEet[i].dayLeft==3)
                {
                    MeetinId = getUserMEet[i].MeetingID;
                    Meetings sendUser = new Meetings();
                    List<Meetings> userinfo = new List<Meetings>();
                    userinfo = sendUser.GetUserByMeeting(MeetinId);
                    for (int j = 0; j < userinfo.Count; j++)
                    {
                        userName = userinfo[i].FirstName;
                        userName += " ";
                        userName += userinfo[i].LastName;
                        phonNumber = userinfo[i].PhoneNumber;
                        barbername = userinfo[i].BarbName;
                        bphonNumber = userinfo[i].pHonNumber;

                    }
                    General.GlobalFunc.SendSMSAsync(phonNumber, userName + "התור שלך בעוד 3 ימים!", barbername);
                    LabarNAME.Text = getUserMEet[i].BarbName.ToString();
                    LaHiarStyle.Text = getUserMEet[i].HairCut.ToString();
                    lblbarberName.Text = getUserMEet[i].BarberName.ToString();
                    lblHiarCutNow.Text = getUserMEet[i].dayLeft.ToString();
                    LabTody.Text = "התור שלך  בעוד 3 ימים בשעה " + getUserMEet[i].Time.ToString();
                    break;
                }
                else 
                {
                    i++;
                }
               
            }

        }
    }
}