using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuickCopy
{
    public class EncryptionHandler
    { 

        public static byte[] Encrypt(string key, string data)
        {
            byte[] iv = new byte[16];
            using (Aes aes = new AesManaged())
            {
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 128;
                aes.Key = Encoding.ASCII.GetBytes(key);
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plainText = Encoding.UTF8.GetBytes(data);
                        cryptoStream.Write(plainText, 0, plainText.Length);
                    }
                    return memoryStream.ToArray();
                }
            }
        }

        public static string Decrypt(string key, byte[] data)
        {
            byte[] iv = new byte[16];

            using (Aes aes = new AesManaged())
            {
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 128;
                aes.Key = Encoding.ASCII.GetBytes(key);
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(data, 0, data.Length);
                    }
                    return Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }

    }
}
