using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class managerPerson : System.Web.UI.Page
    {
        int cunbtEmp = 0;
        int cuontmeet = 0;
        int cuntOrder = 0;
        private bool booked;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["Muserid"] == null&& Session["BarabshopID"]==null)
                {
                    Response.Redirect("default.aspx");

                }
                else
                {
                    TxtDayOff.Visible = true;
                    FillDataMeittings();
                    FillDataProducts();
                    FillDataEmp();
                    FllDataDayOff();
                    FillDataProductsCanceld();
                    FillDataProductsConfirm();
                    FillDataProductsPaid();
                }

            }
        }
        protected void insertDayOff()
        {
            string barid = Session["BarabshopID"].ToString();
            int barbarid = int.Parse(barid);
            string dayoff = TxtDayOff.Text;
            string mUSerID = Session["Muserid"].ToString();
            int MuserID = int.Parse(mUSerID);
            DayOff insertDAY = new DayOff();
            insertDAY.insertrDayOff(MuserID, dayoff, barbarid);
            FllDataDayOff();
        }
        protected void FillDataMeittings()
        {
            int BarID = (int)Session["BarabshopID"];
            List<Meetings> listMeetings = new List<Meetings>();
            Meetings dd = new Meetings();
            listMeetings = dd.GetBMangerMeetingss(BarID);
            MetingsList.DataSource = listMeetings;
            MetingsList.DataBind();
            for (int i = 0; i < listMeetings.Count; i++)
            {
                cuontmeet += 1;
            }
            lblMettings.Text = cuontmeet.ToString();
        }
        protected void FillDataProducts ()
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsTest(BarID);
         

            for (int i = 0; i < Listorders.Count; i++)
            {
                
                    prodOrder.DataSource = Listorders;
                    prodOrder.DataBind();
                    cuntOrder += 1;
                
                //else
                //{
                //    repOrderConfirm.DataSource = Listorders;
                //    repOrderConfirm.DataBind();
                //}
                string order = Listorders[i].orderStatus;
                

            }
            LblOrders.Text = cuntOrder.ToString();
        }
        protected void FillDataProductsConfirm()
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsConfirm(BarID);


            for (int i = 0; i < Listorders.Count; i++)
            {

                repOrderConfirm.DataSource = Listorders;
                repOrderConfirm.DataBind();
              

                //else
                //{
                //    repOrderConfirm.DataSource = Listorders;
                //    repOrderConfirm.DataBind();
                //}
                string order = Listorders[i].orderStatus;


            }
           
        }
        protected void FillDataProductsCanceld()
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsCanceled(BarID);


            for (int i = 0; i < Listorders.Count; i++)
            {

                RepCancel.DataSource = Listorders;
                RepCancel.DataBind();


                //else
                //{
                //    repOrderConfirm.DataSource = Listorders;
                //    repOrderConfirm.DataBind();
                //}
                string order = Listorders[i].orderStatus;


            }

        }

        protected void FillDataProductsPaid()
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsPaid(BarID);


            for (int i = 0; i < Listorders.Count; i++)
            {

                RepPaid.DataSource = Listorders;
                RepPaid.DataBind();


                //else
                //{
                //    repOrderConfirm.DataSource = Listorders;
                //    repOrderConfirm.DataBind();
                //}
                string order = Listorders[i].orderStatus;


            }

        }
        //protected void FillDataProductsConfirm()
        //{
        //    string barID = Session["BarabshopID"].ToString();
        //    int BarID = int.Parse(barID);
        //    List<Orderss> Listorders = new List<Orderss>();
        //    Orderss oprderProd = new Orderss();
        //    Listorders = oprderProd.GETOrderprodctsConfirm(BarID);
        //    prodOrderr.DataSource = Listorders;
        //    prodOrderr.DataBind();

        //}

        protected void FllDataDayOff()
        {
            int dayoff = 0;
            string date = DateTime.Today.ToString("dd/MM/yyyy");
            List<DayOff> dayOffList = new List<DayOff>();
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            DayOff GetDays = new DayOff();
            dayOffList = GetDays.GetDays(BarID);
            for(int i=0;i<dayOffList.Count;i++)
            {
                dayoff = int.Parse(dayOffList[i].daynow);
                if(dayoff>0)
                {
                    RepDayOff.DataSource = dayOffList;
                    RepDayOff.DataBind();
                }
            }
          

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
                    repEmplo.DataSource = lisemp;
                    repEmplo.DataBind();
                    cunbtEmp += 1;
                }
                Labemp.Text = cunbtEmp.ToString();
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TxtDayOff.Text = Calendar2.SelectedDate.ToShortDateString();
            Session["datapick"] = TxtDayOff.Text;
            DateTime dateNow = DateTime.Parse(TxtDayOff.Text);
            Session["dateMetting"] = dateNow;
        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime today = DateTime.Now;
           DateTime newday= today.AddDays(5);

            if (e.Day.Date < newday)
            {
                // Disable date
                e.Day.IsSelectable = false;
                // Change color of disabled date
                e.Cell.ForeColor = Color.Gray;
            }



            if (e.Day.Date.Date == Calendar2.SelectedDate && booked == true)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            insertDayOff();
            FllDataDayOff();
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //    string barID = Session["BarabshopID"].ToString();
        //    int BarID = int.Parse(barID);
        //    List<Orderss> Listorders = new List<Orderss>();
        //    Orderss oprderProd = new Orderss();
        //    Listorders = oprderProd.GETOrderprodctsConfirm(BarID);


        //    for (int i = 0; i < Listorders.Count; i++)
        //    {

        //        Repeater1.DataSource = Listorders;
        //        Repeater1.DataBind();


        //        //else
        //        //{
        //        //    repOrderConfirm.DataSource = Listorders;
        //        //    repOrderConfirm.DataBind();
        //        //}
        //        string order = Listorders[i].orderStatus;


        //    }

        //}
    }
    
}