using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project7
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
            SessionStorageDataLabel.Text = Session["notifications"] as string;
        }
    }
}