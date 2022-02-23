using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin_login_6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Settings settings = (Settings)Application["settings"];
                Label_text1.Text = settings.DefaultPageText1;
                Label_text2.Text = settings.DefaultPageText2;            
            }
            catch (Exception)
            {

            }
        }
    }
}