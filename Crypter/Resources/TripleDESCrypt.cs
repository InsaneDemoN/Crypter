using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypter.Resources
{
    class TripleDESCrypt
    {
        byte[] encrypted;
        public string EncryptString(string key, string text)
        {
            string res = "";
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider();
            UTF8Encoding uTF = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            triple.Key = md5.ComputeHash(uTF.GetBytes(key));
            triple.Mode = CipherMode.ECB;
            triple.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = triple.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(uTF.GetBytes(text), 0, text.Length);
            res = Convert.ToBase64String(encrypted);


            return res;
        }
        public string DecryptString(string key,string text)
        {
            string res = "";
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider();
            UTF8Encoding uTF = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            triple.Key = md5.ComputeHash(uTF.GetBytes(key));
            triple.Mode = CipherMode.ECB;
            triple.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = triple.CreateDecryptor();
            try
            {
                byte[] cipher = Convert.FromBase64String(text);
                byte[] decrypted = trans.TransformFinalBlock(cipher, 0, cipher.Length);
                res = uTF.GetString(decrypted);
            }
            catch(CryptographicException ce)
            {
                return "bad";
               
            }
            catch(NullReferenceException e)
            {
                return "null";
            }
            catch (FormatException)
            {
                return "badcipher";
            }
           


            return res;
        }
    }
}
