using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_login_6
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                Settings settings = (Settings)Application["settings"];
                TextBox_text1.Text = settings.DefaultPageText1;
                TextBox_text2.Text = settings.DefaultPageText2;
                TextBox_header.Text = settings.DefaultPageText3;
                TextBox_footer.Text = settings.DefaultPageText4;
            }
        }
        protected void Submit_click(object sender, EventArgs e)
        {
            Settings settings = (Settings)Application["settings"];
            settings.DefaultPageText1 = TextBox_text1.Text;
            settings.DefaultPageText2 = TextBox_text2.Text;
            settings.DefaultPageText3 = TextBox_header.Text;
            settings.DefaultPageText4 = TextBox_footer.Text;
            Manager.SaveSettings(Server.MapPath("~/App_Data/Settings.xml"), settings);
            Application["settings"] = settings;
            
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert",
            "<script>alert('" + "Settings Saved Successfully" + "');</script>", false);
        }
       
    }
}