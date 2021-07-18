using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using barbushop.DataCod;

namespace barbushop
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public string usernum;
        DataTable ch = new DataTable();
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


                //FillData();
                FillDataMeittings();
                FillDataOrders();
            }
        }
        protected void FillDataMeittings()
        {
            int userID = (int)Session["userid"];
            List<Meetings> listMeetings = new List<Meetings>();
            Meetings dd = new Meetings();
            listMeetings = dd.GetMeetingss(userID);
            MetingsList.DataSource = listMeetings;
            MetingsList.DataBind();
        }
        protected void test(object sender, CommandEventArgs e)
        {
            string barbername = "";
            string phonNumber = "";
            string bphonNumber = "";
            string userName = "";
            int retval = 0;
            string p = e.CommandArgument.ToString();
            int cancelMeet = int.Parse(p);
            int status = 4;
            Meetings CancelMeet = new Meetings();
           retval= CancelMeet.DeleteMeetings(cancelMeet,status);
            Meetings sendUser = new Meetings();
            List<Meetings> userinfo = new List<Meetings>();
            userinfo = sendUser.GetUserByMeeting(cancelMeet);
            for (int i = 0; i < userinfo.Count; i++)
            {
                userName = userinfo[i].FirstName;
                userName += " ";
                userName += userinfo[i].LastName;
                phonNumber = userinfo[i].PhoneNumber;
                barbername = userinfo[i].BarbName;
                bphonNumber = userinfo[i].pHonNumber;

            }
            if (retval != 0)
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);
                General.GlobalFunc.SendSMSAsync(bphonNumber, barbername + "התור שלך בוטל!", userName);


            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }

            FillDataMeittings();
            
        }
        protected void orderCencel(object sender, CommandEventArgs e)
        {
            string barbername = "";
            string phonNumber = "";
            string bphonNumber = "";
            string userName = "";
            int retval = 0;
            string p = e.CommandArgument.ToString();
            int orderid = int.Parse(p);
            int status = 5;
            Orderss CancelOrder = new Orderss();
          retval= CancelOrder.updateOrdersData(orderid, status);
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
                bphonNumber = userinfo[i].pHonNumber;

            }
            if (retval!=0)
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);
                General.GlobalFunc.SendSMSAsync(bphonNumber, barbername + "ההזמנה שלך בוטלה!", userName);


            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }
            FillDataOrders();

        }

        protected void FillDataOrders()
        {
            int userID = (int)Session["userid"];
            Orderss getUserOrder = new Orderss();
            List<Orderss> listOrder = new List<Orderss>();
            listOrder = getUserOrder.GETOrderprodctsUser(userID);
         
                    RptOrder.DataSource = listOrder;
                    RptOrder.DataBind();
            
         

        }

    }
}