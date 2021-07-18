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
using barbushop.General;

namespace barbushop
{
    public partial class MangerCancel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Muserid"] == null)
                {
                    Response.Redirect("default.aspx");

                }
                else
                {
                    FillDataMeittings();
                    FillOrderData();
                    FillDataEmp();
                    FillOrderConfirmData();
                }

            }
        }

       
        protected void FillDataMeittings()
        {
            int MuserID = (int)Session["Muserid"];
            List<Meetings> listMeetings = new List<Meetings>();
            Meetings dd = new Meetings();
            listMeetings = dd.GetMangerMeetingss(MuserID);
            RepMeeting.DataSource = listMeetings;
            RepMeeting.DataBind();
        
        }
        protected void FillDataEmp()
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Employess> lisemp = new List<Employess>();
            Employess getEmp = new Employess();
            lisemp = getEmp.GetEmpUser(BarID);
            for (int i = 0; i < lisemp.Count; i++)
            {
                if (lisemp[i].Status == 1)
                {
                    repEmp.DataSource = lisemp;
                    repEmp.DataBind();
                  
                }
              
            }
        }




        protected void FillOrderData()
        {


            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsTest(BarID);
            for(int i=0; i<Listorders.Count;i++)
            {
                if(Listorders[i].StatusID!=2&&Listorders[i].StatusID!=3&&Listorders[i].StatusID!=5)
                {
                    yourrepeter.DataSource = Listorders;
                    yourrepeter.DataBind();
                }
            }
         


           
        }

        protected void FillOrderConfirmData()
        {


            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsConfirm(BarID);
            for (int i = 0; i < Listorders.Count; i++)
            {
                
                    RepOrderConfitm.DataSource = Listorders;
                    RepOrderConfitm.DataBind();
                
            }




        }

        protected void cencelMeetings(object sender, CommandEventArgs e)
        {
            int reval = 0;
            int rtval = 0;
            string barbername = "";
            string phonNumber = "";
            string userName = "";

            string p = e.CommandArgument.ToString();
            int meetingId = int.Parse(p);
            Meetings cencelMeetings = new Meetings();
           reval= cencelMeetings.DeleteMeetings(meetingId,3);
            FillDataMeittings();

            Meetings sendUser = new Meetings();
            List<Meetings> userinfo = new List<Meetings>();
            userinfo = sendUser.GetUserByMeeting(meetingId);
            for (int i = 0; i < userinfo.Count; i++)
            {
                userName = userinfo[i].FirstName;
                userName += " ";
                userName += userinfo[i].LastName;
                phonNumber = userinfo[i].PhoneNumber;
                barbername = userinfo[i].BarbName;

            }
            if (reval == 1)
            {

                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);
                General.GlobalFunc.SendSMSAsync("0545607333", phonNumber+ "!התור שלך בוטל נשמח אם תקבע למועד אחר :", barbername);

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }
        }
        protected void cancelOrder(object sender, CommandEventArgs e)
        {
            int reval = 0;
            int rtval = 0;
            string barbername = "";
            string phonNumber = "";
            string userName = "";

            string p = e.CommandArgument.ToString();
            int status = 0;
            int orderID = int.Parse(p);
            Orderss OrderCencel = new Orderss();
           reval= OrderCencel.OrderCencel(orderID);
            FillOrderData();
            Orderss sendUser = new Orderss();
            List<Orderss> userinfo = new List<Orderss>();
            userinfo = sendUser.GETuserInfoByOrderid(orderID);
            for (int i = 0; i < userinfo.Count; i++)
            {
                userName = userinfo[i].FirstName;
                userName += " ";
                userName += userinfo[i].LastName;
                phonNumber = userinfo[i].PhoneNumber;
                barbername = userinfo[i].BarbName;

            }
            if (reval == 1)
            {

                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);
                General.GlobalFunc.SendSMSAsync(phonNumber, userName + "ההזמנה שלך בוטלה!", barbername);


            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }
        }
        protected void confirmlOrder(object sender, CommandEventArgs e)
        {
            int rtval = 0;
            string barbername = "";
            string phonNumber = "";
            string userName = "";
            string p = e.CommandArgument.ToString();
            int orderID = int.Parse(p);
            Orderss OrderConfirm = new Orderss();
            
           rtval=OrderConfirm.updateOrdersData(orderID,2);
            FillOrderData();
            FillOrderConfirmData();
            Orderss sendUser = new Orderss();
            List<Orderss> userinfo = new List<Orderss>();
            userinfo = sendUser.GETuserInfoByOrderid(orderID);
            for(int i=0;i<userinfo.Count; i++)
            {
                userName = userinfo[i].FirstName;
                userName += " ";
                userName += userinfo[i].LastName;
                phonNumber = userinfo[i].PhoneNumber;
                barbername=userinfo[i].BarbName;

            }

            if(rtval==1)
            {

                General.GlobalFunc.SendSMSAsync(phonNumber, userName + "ההזמנה שלך אושרה ומחכה לך לאיסוף ולסיום התשלום", barbername);
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);

            }
            else 
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }


        }
        protected void PaidOrder(object sender, CommandEventArgs e)
        {
            int reval = 0;
            string barbername = "";
            string phonNumber = "";
            string userName = "";
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string p = commandArgs[0];
            string proid = commandArgs[1];
            int prodiD = int.Parse(proid);
            int orderID = int.Parse(p);
            Orderss OrderConfirm = new Orderss();

          reval= OrderConfirm.updateOrdersData(orderID, 3);
            Orderss ordecap = new Orderss();
            List<Orderss> listorders = new List<Orderss>();
            listorders = ordecap.GetProductId(orderID);
            for (int i = 0; i < listorders.Count; i++)
            {
                if(listorders[i].productId==prodiD)
                {
                    globfunc cap = new globfunc();



                    int newCpa = cap.cpaProduct(listorders[i].amunt, listorders[i].ProdCapacity);
                    ordecap.updateProductCpactiy(prodiD, BarID, newCpa);
                }

            }
            FillOrderConfirmData();
            Orderss sendUser = new Orderss();
            List<Orderss> userinfo = new List<Orderss>();
            userinfo = sendUser.GETuserInfoByOrderid(orderID);
            for (int i = 0; i < userinfo.Count; i++)
            {
                userName = userinfo[i].FirstName;
                userName += " ";
                userName += userinfo[i].LastName;
                phonNumber = userinfo[i].PhoneNumber;
                barbername = userinfo[i].BarbName;

            }

            if (reval == 1)
            {

                General.GlobalFunc.SendSMSAsync(phonNumber, userName + "תודה שרכשת אצלנו", barbername);
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }
        }
        protected void cancelEmployees(object sender, CommandEventArgs e)
        {
            int reval = 0;
            string p = e.CommandArgument.ToString();
            int EmpID = int.Parse(p);
            Employess deleteEmp = new Employess();
            reval= deleteEmp.DeleteEmp(EmpID);
            FillDataEmp();
            if (reval == 1)
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