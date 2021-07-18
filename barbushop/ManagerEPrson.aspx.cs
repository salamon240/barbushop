using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        private bool booked;
        private int cuontmeet;
        private int cuntOrder;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["Euserid"]!=null && Session["BarabshopID"]!=null)
                {
                    FillDataMeittings();
                    FillDataProducts();
                    FllDataDayOff();
                }
                else
                {
                    Response.Redirect("managerMain.aspx");
                }
            }

        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {

            DateTime today = DateTime.Now;
            DateTime newday = today.AddDays(5);

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

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TxtDayOff.Text = Calendar2.SelectedDate.ToShortDateString();
            Session["datapick"] = TxtDayOff.Text;
            DateTime dateNow = DateTime.Parse(TxtDayOff.Text);
            Session["dateMetting"] = dateNow;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            insertDayOff();
            FllDataDayOff();
        }
        protected void FillDataMeittings()
        {
            int MuserID = (int)Session["Euserid"];
            List<Meetings> listMeetings = new List<Meetings>();
            Meetings dd = new Meetings();
            listMeetings = dd.GetMangerMeetingss(MuserID);
            MetingsList.DataSource = listMeetings;
            MetingsList.DataBind();
            for (int i = 0; i < listMeetings.Count; i++)
            {
                cuontmeet += 1;
            }
            lblMettings.Text = cuontmeet.ToString();
        }
        protected void FillDataProducts()
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsConfirm(BarID);
            prodOrder.DataSource = Listorders;
            prodOrder.DataBind();
            for (int i = 0; i < Listorders.Count; i++)
            {
                cuntOrder += 1;
            }
            LblOrders.Text = cuntOrder.ToString();
        }
        protected void FllDataDayOff()
        { int day = 0;
            string eUser = Session["Euserid"].ToString();
            int euser = int.Parse(eUser);
            List<DayOff> dayOffList = new List<DayOff>();
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            DayOff GetDays = new DayOff();
            dayOffList = GetDays.GetDays(BarID);
            for(int i=0;i<dayOffList.Count;i++)
            {
                if(dayOffList[i].UserID==euser)
                {
                    day = int.Parse(dayOffList[i].daynow);
                    if(day<=  0)
                    {
                        i++;
                    }
                    else
                    {
                        LabDaYOff.Text = dayOffList[i].DateDayOff.ToString();
                        break;
                    }

                  
                }
            }
   

        }
        protected void insertDayOff()
        {
            string barid = Session["BarabshopID"].ToString();
            int barbarid = int.Parse(barid);
            string dayoff = TxtDayOff.Text;
            string mUSerID = Session["Euserid"].ToString();
            int MuserID = int.Parse(mUSerID);
            DayOff insertDAY = new DayOff();
            insertDAY.insertrDayOff(MuserID, dayoff, barbarid);
        }
        protected void PaidOrder(object sender, CommandEventArgs e)
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string p = commandArgs[0];
            string proid = commandArgs[1];
            int prodiD = int.Parse(proid);
            int orderID = int.Parse(p);
            Orderss OrderConfirm = new Orderss();

            OrderConfirm.updateOrdersData(orderID, 3);
            Orderss ordecap = new Orderss();
            List<Orderss> listorders = new List<Orderss>();
            listorders = ordecap.GetProductId(orderID);
            for (int i = 0; i < listorders.Count; i++)
            {
                if (listorders[i].productId == prodiD)
                {
                    globfunc cap = new globfunc();



                    int newCpa = cap.cpaProduct(listorders[i].amunt, listorders[i].ProdCapacity);
                    ordecap.updateProductCpactiy(prodiD, BarID, newCpa);
                }

            }
            FillDataProducts();
        }

    }
}