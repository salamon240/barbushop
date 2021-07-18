using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if(!IsPostBack)
            {
                if(Session["Muserid"]==null&& Session["BarabshopID"]==null)
                {
                    Response.Redirect("");
                }
            }
           
        }

        private void UpLoadImage()
        {

            ImageButton imageButton = new ImageButton();
            FileInfo fileInfo = new FileInfo(Session["fileName"].ToString());
            Session["picname"] = fileInfo;
            imageButton.ImageUrl = "~/image/mainPage/Profile/" + fileInfo;
            imageButton.Width = Unit.Pixel(308);
            imageButton.Height = Unit.Pixel(308);
            imageButton.Style.Add("padding", "5px");
            imageButton.Style.Add("border-radius", "50%");
            imageButton.Click += new ImageClickEventHandler(btnUPPic_Click);
            Panel1.Controls.Add(imageButton);
        }
        protected void addpic()
        {

            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                Session["fileName"] = fileName;
                //Chackprod();
                //if (prodIn != true)
                //{
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/mainPage/Profile/" + fileName));
                UpLoadImage();
                //}
            }


        }

        protected void fillData()
        {
            string Muserid = Session["Muserid"].ToString();
            int mUserID = int.Parse(Muserid);
            string bARId = Session["BarabshopID"].ToString();
            int BARId = int.Parse(bARId);
            string picName = Session["fileName"].ToString();
            Barabshops roll = new Barabshops();
            int rtval = roll.updateROll(mUserID, BARId, picName);
            if(rtval==1)
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertmes()", true);

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["s"] = DropDownList.SelectedValue;
            Response.Write(Session["s"]);
        }

        protected void btnUPPic_Click(object sender, EventArgs e)
        {
            addpic();
        }




        protected void btnUpload_Click(object sender, EventArgs e)
        {
            fillData();
        }
    }
}