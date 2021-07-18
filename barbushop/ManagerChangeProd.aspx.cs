using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class ManagerChangeProd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["prodId"] = Request["prodid"];
                if (Session["Muserid"] != null)
                {
                    FillData();
                }
                else
                {
                    Response.Redirect("ManagerPIc.aspx");
                }
            }
        }
        private void updateProd()
        {
            int reval = 0;
            string barid = Session["BarabshopID"].ToString();
            int Barid = int.Parse(barid);
            string proID = Session["prodId"].ToString();
            int prodID = int.Parse(proID);
            //double newPrice = Convert.ToDouble(prodNewPrice.Text);
            string newProdNote = prodNote.Text;

            List<product> productss = new List<product>();
            string products = Session["prodId"].ToString();
            int proid = int.Parse(products);
            product getpro = new product();
            productss = getpro.GetPicByID(proid);
            for(int i=0;i<productss.Count;i++)
            {
                if (prodNewPrice.Text != null&& prodNewPrice.Text != "")
                {
                    double newPrice = Convert.ToDouble(prodNewPrice.Text);
                    product changeProd1 = new product();
                   reval= changeProd1.updateProductPrice(prodID, Barid,newPrice);
                }
                 if(CapProd.Text!=null&& CapProd.Text != "")
                {
                    int newProdCap = int.Parse(CapProd.Text);

                    product changeProd2 = new product();
                   reval= changeProd2.updateProductCpactiy(prodID, Barid, newProdCap);
                }
                 if(prodNote.Text!=""&& prodNote.Text != null)
                {

                    product changeProd3 = new product();
                  reval=  changeProd3.updateProductNote(prodID, Barid,newProdNote);
                }


            }
            if (reval == 1)
            {

                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);


            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }



        }
        private void deleteProduct()
        {
            int retval = 0;
            string barid = Session["BarabshopID"].ToString();
            int Barid = int.Parse(barid);
            string proID = Session["prodId"].ToString();
            int prodID = int.Parse(proID);
            product deletPro = new product();
           retval= deletPro.DeleteProduct(prodID, Barid);
            if (retval == 1)
            {

                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);


            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }
        }
        protected void FillData()
        {
            List<product> productss = new List<product>();
            string products = Session["prodId"].ToString();
            int proid = int.Parse(products);
            product getpro = new product();
            productss = getpro.GetPicByID(proid);

            ProdFinsh.DataSource = productss;
            ProdFinsh.DataBind();
          
        }

        protected void changeProdInfo_Click(object sender, EventArgs e)
        {
            updateProd(); 
        }

        protected void removeProd_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }
    }
}