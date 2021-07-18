using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;
using System.Data;
using barbushop.DataCod;

namespace barbushop
{
    public partial class masterAddPic : System.Web.UI.Page
    {
        private bool prodIn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["BarabshopID"]!=null && Session["Muserid"] != null)
                {
                    UpLoadImage();
                }
                else
                {
                    Response.Redirect("managerMain.aspx");
                }
            }
            


        }
        protected void Chackprod()
        {
            string barid = Session["BarabshopID"].ToString();
            int Barid = int.Parse(barid);
            var picname = Session["fileName"].ToString();
            product prod = new product();
            //prodIn = prod.Chackprod(picname);
            DataTable data = new MyDB().Where("ProdPicname", picname).Where("BarbushopID", barid).Get("Productss", "ProdName");
            if (data.Rows.Count > 0)
            {

                prodIn = true;
            }


        }
        protected void btnUPPic_Click(object sender, EventArgs e)
        {
           
                if (FileUpload1.HasFile)
                {
                    string fileName = FileUpload1.FileName;
                    Session["fileName"] = fileName;
                    Chackprod();
                   if (prodIn != true)
                   {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/mainPage/products/" + fileName));
                    MangerADDpic();
                   }
                }
            ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);
            
           

        }
        private void UpLoadImage()
        {
            string barid = Session["BarabshopID"].ToString();
            int barID = int.Parse(barid);
            product picName = new product();
            List<product> pic = new List<product>();
            pic = picName.GetPicName(barID);
            for (int i=0;i<pic.Count;i++)
            {
                ImageButton imageButton = new ImageButton();
                //FileInfo fileInfo = new FileInfo(strFileName);
                Session["picname"] = pic[i];
                imageButton.ImageUrl = "~/image/mainPage/products/" + pic[i].ProdPicname;
                imageButton.Width = Unit.Pixel(100);
                imageButton.Height = Unit.Pixel(100);
                imageButton.Style.Add("padding", "5px");
                imageButton.Click += new ImageClickEventHandler(ImageButton_Click);
                Panel1.Controls.Add(imageButton);
            }
       

          
        }
        protected void MangerADDpic()
        {
            int barid = (int)Session["BarabshopID"];
            string cute = Session["cutid"].ToString();
            int cut = int.Parse(cute);
            double price =double.Parse( txtPric.Text);
            product prod = new product()
            {
                ProdName = txtproductName.Text,
                ProdPicname = Session["fileName"].ToString(),
                ProdPriceType = price,
                ProdNote = txtnote.Text,
                productId = cut,
                ProdCapacity = int.Parse(txtCapacity.Text),
                BarbushopID = barid


            };
            prod.MangerADDpic();

          

        }

        private void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            
            Response.Redirect("~/((ImageButton)sender).ImageUrl");

        }

        protected void CutDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["cutid"] = CutDropDown.SelectedValue;
        }

        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("managerAddPic.aspx");
        }
    }
}