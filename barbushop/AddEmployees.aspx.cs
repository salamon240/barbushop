using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class AddEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               
                if(Session["Muserid"] ==null)
                {
                    Response.Redirect("default.aspx");
                }
                else
                {
                    filldatacity();
                }
            }
        }
        protected void filldatacity()
        {
            String cs = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select cityID,Name from Citys", con);
                con.Open();

                DropDownListCity.DataSource = cmd.ExecuteReader();
                DropDownListCity.DataTextField = "Name";
                DropDownListCity.DataValueField = "cityID";
                DropDownListCity.DataBind();
                ListItem li = new ListItem("בחר עיר", "-1");
                DropDownListCity.Items.Insert(0, li);


            }
        }

        protected void btnUserS_Click(object sender, EventArgs e)
        {
            int Euser = 0;
            int MuserID = (int)Session["Muserid"];
            int BarID = 0;
            Barabshops bar = new Barabshops();
            BarID = bar.GetbarID(MuserID);
            
                Clint empS = new Clint()
            {
                FirstName = TextFname.Text,
                LastName = TextLname.Text,
                PhoneNumber = Textphon.Text,
                Password = TextBox1.Text,
                Email = TextEmail.Text,
                City =int.Parse( DropDownListCity.SelectedItem.Value),
                //Gender = Session["Gander"].ToString()


            };
            empS .insertUser_data();
            if (empS != null)
            {
                 Euser = empS.Getuseer(empS.Email, empS.Password);
                //Session["Euserid"] = Euser;
            }
            bar.insertrOLL(1, Euser, BarID,1);
            Session["BarabshopID"] = BarID;
            ClientScript.RegisterStartupScript(GetType(), "randomtext", "alertme()", true);

            Response.Redirect("managerMain.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("managerMain.aspx");
        }
    }
}