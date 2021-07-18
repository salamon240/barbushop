using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class UserOrderInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["orderid"] = Request["OrderID"];
            FillDataProducts();
        }

        protected void FillDataProducts()
        {
            string orderid = Session["orderid"].ToString();
            int Orderid = int.Parse(orderid);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            Listorders = oprderProd.GETOrderprodctsByOrder(Orderid);


            for (int i = 0; i < Listorders.Count; i++)
            {

                repOrderDetils.DataSource = Listorders;
                repOrderDetils.DataBind();


                //else
                //{
                //    repOrderConfirm.DataSource = Listorders;
                //    repOrderConfirm.DataBind();
                //}
                string order = Listorders[i].orderStatus;

                LabStatus.Text = order;

            }
        }
    }
}