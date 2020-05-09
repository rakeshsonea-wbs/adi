using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;


namespace PeerReviewSample.Utilities
{
    class Encrypter
    {
        public static string Encrypt(string text)
        {

            byte[] arrbyte = new byte[text.Length];
            SHA256 hash = new SHA256CryptoServiceProvider();
            arrbyte = hash.ComputeHash(Encoding.UTF8.GetBytes(text));
            return Convert.ToBase64String(arrbyte);
        }
    }
}
