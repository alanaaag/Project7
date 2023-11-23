using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project7
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EncyptButton_Click(object sender, EventArgs e)
        {

            
            // GET THE INPUT FROM PAGE
            var input = EncyptInput.Text.ToString();
            // CALL EncryptionLibrary DLL TO ENCRYPT
            var encryptedValue = EncryptionLibrary.Cryptography.encryptData(input);

            // SET RESULTS TO LABLE ON PAGE
            EncyptResult.Text = encryptedValue;
        }

        protected void DecyptButton_Click(object sender, EventArgs e)
        {
            // GET THE INPUT FROM PAGE
            var input = DecyptInput.Text.ToString();
            // CALL EncryptionLibrary DLL TO DECRYPT
            var decryptedValue = EncryptionLibrary.Cryptography.decryptData(input);

            // SET RESULTS TO LABLE ON PAGE
            DecyptResult.Text = decryptedValue;
        }
    }
}