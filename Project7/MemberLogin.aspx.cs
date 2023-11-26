using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Project7.Member
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void MemberLoginBackButton_Click(object sender, EventArgs e)
        {
            // Redirect to another page
            Response.Redirect("/Default.aspx");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            try
            {
                bool isMatch = false;
                const string MemberXmlFilePath = "/App_Data/Member.xml";
                string xmlPath = HttpContext.Current.Server.MapPath(MemberXmlFilePath);

                // Load the XML document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlPath);

                // Find the user node with the specified username
                XmlNode userNode = xmlDoc.SelectSingleNode($"//Member[User='{username}']");

                if (userNode != null)
                {
                    // Get the stored encrypted password for the user
                    string storedEncryptedPassword = userNode.SelectSingleNode("Password").InnerText;

                    // Decrypt the stored password
                    string decryptedPassword = EncryptionLibrary.Cryptography.decryptData(storedEncryptedPassword);

                    // Compare the decrypted password with the entered password
                    isMatch = password == decryptedPassword;
                }

                if (isMatch)
                {
                    FormsAuthentication.SetAuthCookie(username, true);
                    // Redirect to another page
                    Response.Redirect("/Member/Member.aspx");
                } else
                {
                    StatusLabel.Text = "Wrong Credentials, Try Again.";
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions (log, display an error, etc.)
                // For simplicity, this example catches all exceptions and returns false
                StatusLabel.Text = ex.ToString();
            }
        }
    }
}