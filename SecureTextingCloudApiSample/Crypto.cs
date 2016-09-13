using OpenSSL.Core;
using OpenSSL.Crypto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qliqCloudApiCSharpSample
{
    class Crypto
    {
        public static string decryptFromBase64WithKeyFile(string base64EncryptedData, string privateKeyPath)
        {
            var encryptedData = Convert.FromBase64String(base64EncryptedData);

            var privateKey = File.ReadAllBytes(privateKeyPath);
            RSA rsa;
            var result = new List<byte>();
            using (var bio = new BIO(privateKey))
            {
                rsa = OpenSSL.Crypto.RSA.FromPrivateKey(bio);
            }
            for (var index = 0; index < encryptedData.Length; index += rsa.Size)
            {
                var partLength = Math.Min(rsa.Size, encryptedData.Length - index);
                var encryptedPart = new byte[partLength];
                Array.ConstrainedCopy(encryptedData, index, encryptedPart, 0, partLength);
                try
                {
                    var decryptedPart1 = rsa.PrivateDecrypt(encryptedPart, RSA.Padding.PKCS1);
                    result.AddRange(decryptedPart1);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return System.Text.Encoding.UTF8.GetString(result.ToArray());
        }

        public static bool canLoadPrivateKey(string privateKeyPath)
        {
            try
            {
                var privateKey = File.ReadAllBytes(privateKeyPath);
                RSA rsa;
                var result = new List<byte>();
                using (var bio = new BIO(privateKey))
                {
                    rsa = OpenSSL.Crypto.RSA.FromPrivateKey(bio);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
