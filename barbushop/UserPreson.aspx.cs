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
using barbushop.DataDB;

namespace barbushop
{
    public partial class UserPreson : System.Web.UI.Page
    {
        public int mettintimee;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["userid"] == null)
                {
                    Response.Redirect("default.aspx");
                }

 
                //Cuonter();
                FillDataMeittings();
                //FillDataMeitting();
                FillDataOrders();
            }

        }

        protected void cangePerson_Click(object sender, EventArgs e)
        {
            
        }
        protected void FillDataOrders()
        {
            int numOrders = 0;

            int userID = (int)Session["userid"];
            Orderss getUserOrder = new Orderss();
            List<Orderss> listOrder = new List<Orderss>();
            listOrder = getUserOrder.GETOrderprodctsUser(userID);
            for (int i = 0; i < listOrder.Count; i++)
            {
                numOrders += 1;
            }
            LblOrders.Text = numOrders.ToString();
            RptOrder.DataSource = listOrder;
            RptOrder.DataBind();
          
        }
        protected void FillDataMeittings()
        {
            int numbMtings = 0;
            int userID = (int)Session["userid"];
            List<Meetings> listMeetings = new List<Meetings>();
            Meetings dd = new Meetings();
            listMeetings = dd.GetMeetingss(userID);
            for (int i = 0; i < listMeetings.Count; i++)
            {
                numbMtings += 1;
            }
            lblMettings.Text = numbMtings.ToString();
            MetingsList.DataSource = listMeetings;
            MetingsList.DataBind();
        }
        
        //protected void Cuonter()
        //{
        //    int numOrders = 0;
        //    int numbMtings = 0;
        //    var barnarshopID = Session["barbarId"].ToString();
        //  string Cuserid = Session["userid"].ToString();
        //    DataTable data = new MyDB().Where("UserID", Cuserid).Get("Meetings", "MeetingTime", "MeetingDate");

        //    foreach (DataRow row in data.Rows)
        //    {
        //        numbMtings += 1;




        //    }
        //    lblMettings.Text = numbMtings.ToString();
        //    DataTable datas = new MyDB().Where("UserID", Cuserid).Get("Orderss", "*");
        //    foreach (DataRow row in datas.Rows)
        //    {
        //        numOrders += 1;
        //    }
        //    LblOrders.Text = numOrders.ToString();
        //}


    }
}