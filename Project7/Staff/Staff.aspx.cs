using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace Project7.Staff
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StaffButton_Click(object sender, EventArgs e)
        {
            //RESET RESULT IF NEEDED
            StaffResult.Text = "";

            // READ THE STAFF XML AND LOOK FOR THE USER TAG
            string[] results = ReadXML("User").ToArray<string>();

            //LOOP EACH RESULT AND ADD TO THE STAFF RESULT TO PRINT ON PAGE
            foreach (var result in results)
            {
                //ENDCODE TO PRESERVE THE XML TAGS
                string encodedXml = String.Format(HttpUtility.HtmlEncode(result));
                StaffResult.Text += encodedXml + "</br>";
            }
        }

        protected void AddStaffUser_Click(object sender, EventArgs e)
        {
            //RESET STATUS TEXT ON PAGE
            AddStaffStatus.Text = "";

            //GET USER AND PASSWORD
            var username = StaffUserInput.Text;
            var password = StaffPasswordInput.Text;

            //IF USER AND PASSWORD NOT EMPTY / NULL
            if (!username.IsNullOrWhiteSpace() && !password.IsNullOrWhiteSpace())
            {
                // CALL EncryptionLibrary DLL TO ENCRYPT
                var encryptPassword = EncryptionLibrary.Cryptography.encryptData(password);

                //READ STAFF.XML FROM APP_DATA FOLDER
                string path = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");

                // CREATE/LOAD STAFF.XML INTO XDOCUMENT
                XDocument doc = XDocument.Load(path);

                // CREATE NEW MEMEBER, USER, PASSWORD ELEMENTS FOR XML 
                XElement root = new XElement("Member");
                root.Add(new XElement("User", username));
                root.Add(new XElement("Password", encryptPassword));

                // ADD NEW ELEMENTS INTO XML UNDER STAFF ROOT ELEMENT AND SAVE XML
                doc.Element("Staff").Add(root);
                doc.Save(path);

                // CLEAR USER AND PASSWORD FIELDS ONCE COMPLETE
                StaffUserInput.Text = null;
                StaffPasswordInput.Text = null;

                // SET STATUS TEXT TO PAGE
                AddStaffStatus.Text = "Staff List Updated!";
            }
            else
            {
                // IF USER OR PASSWORD EMPTY - SET STATUS TEXT ON PAGE TO ERROR TEXT
                AddStaffStatus.Text = "Please enter proper credentials";
            }
        }
        // PRIVATE METHOD TO HELP WITH DISPLAYING STAFF LIST
        private List<string> ReadXML(string searchTerm)
        {
            List<string> searchResult = new List<string>();

            //READ STAFF.XML FROM APP_DATA FOLDER
            string path = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");

            //CREATE AND LOAD XML DOCUMENT OBJECT
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);

            //SEARCH ELEMENTS
            XmlNodeList elemList = xdoc.GetElementsByTagName(searchTerm);

            //ADD RESULTS TO LIST
            foreach (XmlNode elem in elemList)
            {
                searchResult.Add(elem.InnerText.ToString());
            }

            return searchResult;
        }

        protected void DefaultPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}