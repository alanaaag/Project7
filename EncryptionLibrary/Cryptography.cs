using System.Security.Cryptography;
using System.Text;

namespace EncryptionLibrary
{
    public class Cryptography
    {
        static string seedString = "cse44598";

        public static string encryptData(string data)
        {
            byte[] seed = ASCIIEncoding.ASCII.GetBytes(seedString);
            if (String.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("The input empty or null");
            }

            SymmetricAlgorithm symmetricAlgorithm = DES.Create();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(seed, seed), CryptoStreamMode.Write);
            StreamWriter streamWriter = new StreamWriter(cryptoStream);

            streamWriter.Write(data);
            streamWriter.Flush();
            cryptoStream.FlushFinalBlock();

            var encryptedData = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);

            return encryptedData;
        }
        public static string decryptData(string data)
        {
            byte[] seed = ASCIIEncoding.ASCII.GetBytes(seedString);
            if (String.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("The input empty or null");
            }
            SymmetricAlgorithm symmetricAlgorithm = DES.Create();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(data));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(seed, seed), CryptoStreamMode.Read);
            StreamReader streamReader = new StreamReader(cryptoStream);

            string decryptedData = streamReader.ReadLine();

            return decryptedData;

        }
    }
}
namespace System.Net.Http { }