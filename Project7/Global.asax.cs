using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Project7
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Set the initial value of the Global Variables
            Application["SiteName"] = "Team 25 Final Project";
            Application["maxUsers"] = "100";
            Application["adminContactEmail"] = "kdhyani@asu.edu";
            Application["adminContactPhoneNumber"] = "+1 623-268-9886";
            Application["adminName"] = "Kshitij Dhyani";
        }
    }
}