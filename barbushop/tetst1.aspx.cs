using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class tetst1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["userid"] == null&& Session["barbarId"]==null)
                {
                    Response.Redirect("userMain.aspx");

                }
                else
                {
                    FillProfile();

                }
            }
        }
        protected void clickme(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

        }
        protected void FillProfile()
        {
            string muser = Session["barbarId"].ToString();
            int muserid = int.Parse(muser);
            Barabshops bar = new Barabshops();
            List<Barabshops> BarPicName = new List<Barabshops>();
            BarPicName = bar.allProfil(muserid);
            //if(BarPicName == "")
            //{
            //    BarPicName = "man.jpg";
            //}
            RepConact.DataSource = BarPicName;
            RepConact.DataBind();





        }
    }
}