using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_login_6
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VisitorCounter.Text = "You are Visitor No - " + Application["Visitor"].ToString();
            Settings settings = (Settings)Application["settings"];
            Header.Text = settings.DefaultPageText3;
            Footer.Text = settings.DefaultPageText4;

            if (Session["userID"] == null)
            {
                Button_logout.Visible = false;
            }
            else
            {
                Button_logout.Visible = true;
            }
            if (Session["userID"] == null)
            {
                login_lbl.Visible = true;
            }
            else
            {
                login_lbl.Visible = false;
            }
        }

        protected void Logout_click(object sender, EventArgs e)
        {
            Session.Remove("userID");
            Response.Redirect("Default.aspx");
        }
    }
}
