using Project7.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project7
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Access application-wide variable
            string SiteName = Application["SiteName"] as string;
            string maxUsers = Application["maxUsers"] as string;
            string adminContactEmail = Application["adminContactEmail"] as string;
            string adminContactPhoneNumber = Application["adminContactPhoneNumber"] as string;
            string adminName = Application["adminName"] as string;

            Console.WriteLine(Application["SiteName"]);

            BaseConfigOne.Text = "SiteName : " + SiteName;
            BaseConfigTwo.Text = "maxUsers : " + maxUsers;
            BaseConfigThree.Text = "adminContactEmail : " + adminContactEmail;
            BaseConfigFour.Text = "adminContactPhoneNumber : " + adminContactPhoneNumber;


            HttpCookie userCookie = new HttpCookie("ProjectTitle");
            userCookie["ProjectTitle"] = "FinalProject";
            userCookie.Expires = DateTime.Now.AddHours(48); // Set expiration time
            Response.Cookies.Add(userCookie);

            // Set a session variable
            Session["startTime"] = DateTime.Now.ToString();
        }

        protected void MemberPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member/Member.aspx");
        }

        protected void StaffPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff/Staff.aspx");
        }

        protected void MemberRegistrationButton_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/MemberReg.aspx");
        }

        protected void MemberLoginButton_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/MemberLogin.aspx");
        }

        protected void StaffLoginButton_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/MemberLogin.aspx");
        }

        protected void TableMemberLoginButtonKshitij_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/MemberLogin.aspx");
        }

        protected void TableStaffLoginButtonKshitij_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/MemberLogin.aspx");
        }

        protected void TableDefaultLoginButtonKshitij_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/Default.aspx");
        }

        protected void TableCookieAndSessionTryItPageButton_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/CookieSessionTryIt.aspx");
        }

        protected void TableMemberPageButtonKshitij_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/Member/Member.aspx");
        }

        protected void TryItPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TryIt.aspx");
        }
    }
}