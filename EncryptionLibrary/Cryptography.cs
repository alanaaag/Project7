using System.Security.Cryptography;
using System.Text;

namespace EncryptionLibrary
{
    public class Cryptography
    {
        //  COMMON SEED FOR ENCYPT/ DECRPTY
        static string seedString = "cse44598";

        //ENCRYPT METHOD
        public static string encryptData(string data)
        {
            //CONVERT SEED STRING INTO BYTE ARRAY
            byte[] seed = ASCIIEncoding.ASCII.GetBytes(seedString);
            
            //IF INPUT IS NULL ERROR OUT
            if (String.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("The input empty or null");
            }

            //CREATE SymmetricAlgorithm,MemoryStream (WITH SEED), CryptoStream AND StreamWriter
            SymmetricAlgorithm symmetricAlgorithm = DES.Create();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(seed, seed), CryptoStreamMode.Write);
            StreamWriter streamWriter = new StreamWriter(cryptoStream);

            //PUT THE DATA INTO STREAMWRITER
            streamWriter.Write(data);
            streamWriter.Flush();
            cryptoStream.FlushFinalBlock();

            //CONVERT ENCRYPTED DATA INTO BASE 64
            var encryptedData = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);

            return encryptedData;
        }
        public static string decryptData(string data)
        {
            //CONVERT SEED STRING INTO BYTE ARRAY
            byte[] seed = ASCIIEncoding.ASCII.GetBytes(seedString);

            //IF INPUT IS NULL ERROR OUT

            if (String.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("The input empty or null");
            }

            //CREATE SymmetricAlgorithm,MemoryStream (WITH SEED), CryptoStream AND StreamWriter
            SymmetricAlgorithm symmetricAlgorithm = DES.Create();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(data));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(seed, seed), CryptoStreamMode.Read);
            StreamReader streamReader = new StreamReader(cryptoStream);

            //READ/DECRYPT DATA
            string decryptedData = streamReader.ReadLine();

            return decryptedData;

        }
    }
}
namespace System.Net.Http { }