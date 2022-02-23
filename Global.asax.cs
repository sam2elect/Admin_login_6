using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Admin_login_6
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Settings settings = Manager.LoadSettings(Server.MapPath("~/App_Data/Settings.xml"));
            Application.Add("settings", settings);
        }
        void Session_Start(object sender, EventArgs e)
        {
            if (Application["Visitor"] == null)
            {
                Application.Add("Visitor",0);
            }
            int counter = Convert.ToInt32(Application["Visitor"]);
            counter++;
            Application["Visitor"] = counter.ToString();
        }
    }
}