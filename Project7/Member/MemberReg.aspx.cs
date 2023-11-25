using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Drawing.Imaging;

namespace Project7.Member
{
    public partial class MemberReg : System.Web.UI.Page
    {
        private string captchaString;
        private const string CaptchaSessionKey = "CaptchaKey";
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack) // when register button is clicked, entered captcha is compared to new captcha
            {
                GenerateAndDisplayCaptcha();
            }
        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            string enteredCaptcha = CaptchaTextBox.Text.Trim();
            string captchaString  = Session[CaptchaSessionKey] as string;

            //encrypt password
            var encryptPassword = EncryptionLibrary.Cryptography.encryptData(password);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                StatusLabel.Text = "Please Enter Valid Username/Password.";
                StatusLabel.ForeColor = Color.Red;
                return;
            }

            if (!string.Equals(enteredCaptcha, captchaString, StringComparison.Ordinal))
            {
                StatusLabel.Text = "The Input Does Not Match the Given Text. Try Again";
                StatusLabel.ForeColor = Color.Red;
                GenerateAndDisplayCaptcha();
                return;
            }
                
                string xmlFilePath = Server.MapPath("~/App_Data/Member.xml");
                XDocument xmlDoc = XDocument.Load(xmlFilePath);

                bool userExists = xmlDoc.Descendants("Member")
                                            .Any(member => member.Element("User").Value == username);
                if (userExists)
                {
                    UserTextBox.Text = string.Empty;
                    PasswordTextBox.Text = string.Empty;
                    StatusLabel.Text = "The User Already Exists.";
                    StatusLabel.ForeColor = Color.Red;
                    RefreshCaptcha();
                }
                else
                {
                    xmlDoc.Root.Add(new XElement("Member",
                        new XElement("User", username),
                        new XElement("Password", encryptPassword)));
                    xmlDoc.Save(xmlFilePath);

                    UserTextBox.Text = string.Empty;
                    PasswordTextBox.Text = string.Empty;
                    CaptchaTextBox.Text = string.Empty;

                    StatusLabel.Text = "Registration Successful!";
                    StatusLabel.ForeColor = Color.Green;
                    //redirect?
                }
        }
            private string GenerateRandomString(int length)
            {
                const string chars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789,!%#$@+=-";
                Random random = new Random();
                string captcha = new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            return captcha.Trim();
            }

        private byte[] CreateCaptchaImage(string inputString)
        {
            int mapWidth = inputString.Length * 25;
            Bitmap bitmap = new Bitmap(mapWidth, 40);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Orange);

                Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Black, Color.White, Color.Purple }; 

                Font font = new Font("Arial", 14);
                float x = 10; // Initial X position
                float y = 10; // Initial Y position

                // Draw each character of the captcha string with a different color
                for (int i = 0; i < inputString.Length; i++)
                {
                    using (SolidBrush brush = new SolidBrush(colors[i % colors.Length]))
                    {
                        graphics.DrawString(inputString[i].ToString(), font, brush, new PointF(x, y));
                    }
                    x += 15;
                }

                // Save the bitmap as JPEG into a memory stream
                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }

        private void RefreshCaptcha()
        {
            captchaString = GenerateRandomString(8);
            byte[] captchaImageBytes = CreateCaptchaImage(captchaString);
            CaptchaImage.ImageUrl = "data:image/jpeg;base64, " + Convert.ToBase64String(captchaImageBytes);
            CaptchaTextBox.Text = string.Empty;
        }

        private void GenerateAndDisplayCaptcha()
        {
            string captchaString = GenerateRandomString(8);
            Session[CaptchaSessionKey] = captchaString;
            byte[] captchaImageBytes = CreateCaptchaImage(captchaString);
            CaptchaImage.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(captchaImageBytes);
        }
    }
}