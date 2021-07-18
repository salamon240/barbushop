using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class ManagerSerchOrder : System.Web.UI.Page
    {
        string email = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Muserid"] == null && Session["BarabshopID"] == null)
            {
                Response.Redirect("default.aspx");

            }
            else
            {
                FillDataOrderSerch();
            }

        }
        protected void FillDataOrderSerch()
        {
            string barID = Session["BarabshopID"].ToString();
            int BarID = int.Parse(barID);
            List<Orderss> Listorders = new List<Orderss>();
            Orderss oprderProd = new Orderss();
            if(TexEmail.Text=="")
            {
                Listorders = oprderProd.GETOrderprodcts(BarID);


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
            else
            {
                Listorders = oprderProd.GETOrderprodctsbyEMai(BarID,email);


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

        }

        protected void serch1(object sender, EventArgs e)
        {
             email = TexEmail.Text;
            FillDataOrderSerch();
        }
    }
}