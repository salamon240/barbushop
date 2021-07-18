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
    public partial class ChangeProManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Muserid"] == null)
                {
                    Response.Redirect("default.aspx");

                }
                else
                {
                    filldatacity();
                    filldatainfo();
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

        protected void UpDataMuser()
        {
            string mUSERid = Session["Muserid"].ToString();
            int MuserID = int.Parse(mUSERid);
            Clint Temp = new Clint()
            {
                FirstName = TextFname.Text,
                LastName = TextLname.Text,
                PhoneNumber = Textphon.Text,
                Email = TextEmail.Text,
                City = int.Parse(DropDownListCity.SelectedItem.Value),
                Gender = Session["Gander"].ToString()


            };
            Temp.updateUser(MuserID);
            Session["Muserid"] = Temp;
            Response.Redirect("managerMain.aspx");


        }
        protected void filldatainfo()
        {
            string USERid = Session["Muserid"].ToString();
            int userID = int.Parse(USERid);
            Clint getUser = new Clint();
            List<Clint> userInfo = new List<Clint>();
            userInfo = getUser.GETuserInfo(userID);
            for (int i = 0; i < userInfo.Count; i++)
            {
                TextFname.Text = userInfo[i].FirstName;
                TextLname.Text = userInfo[i].LastName;
                Textphon.Text = userInfo[i].PhoneNumber;
                TextEmail.Text = userInfo[i].Email;

            }
        }
        protected void btnUserS_Click(object sender, EventArgs e)
        {
            UpDataMuser();
        }
    }
}