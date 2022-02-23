using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Admin_login_6
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_click(object sender, EventArgs e)
        {
            string UserName = WebConfigurationManager.AppSettings["PFUserName"];
            string Password = WebConfigurationManager.AppSettings["PFPassWord"];
            if (TextBox_username.Text == UserName && TextBox_password.Text == Password)
            {
                Session.Add("UserID", UserName);

                Response.Redirect("admin.aspx");
            }
            else
            {
                LabelMessage.Text = "Enter valid username and password";
            }
        }
    }
}