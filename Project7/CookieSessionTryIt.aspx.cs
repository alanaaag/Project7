using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Project7.Cookie
{
    public partial class CookieSessionTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getCookieDataButton_Click(object sender, EventArgs e)
        {
            // Get the value of the cookie
            CookieDataLabel.Text = Request.Cookies["ProjectTitle"].Value;
        }

        protected void getSessionStorageDataButton_Click(object sender, EventArgs e)
        {
            // Get the session variable
            SessionStorageDataLabel.Text = Session["startTime"] as string;
        }
    }
}