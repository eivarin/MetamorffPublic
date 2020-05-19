    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Security.Cryptography;

    namespace CommonLib.Auth
    {
        public static class PassEncript
        {
            public static ProcessedPassword EncriptarString(string ToEncrypt)
            {
                string salt = SaltGenerator.RandomString();
                string hash;
                using (SHA512 sha512Hash = SHA512.Create())
                {
                    byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(ToEncrypt + salt));
                    hash = Convert.ToBase64String(bytes, 0, bytes.Length);
                }
                ProcessedPassword password = new ProcessedPassword(hash, salt);
                return password;
            }

            public static ProcessedPassword EncriptarString(string ToEncrypt, string salt)
            {
                string hash;
                using (SHA512 sha512Hash = SHA512.Create())
                {
                    byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(ToEncrypt + salt)) ;
                    hash = Convert.ToBase64String(bytes, 0, bytes.Length);
                }
                ProcessedPassword password = new ProcessedPassword(hash, salt);
                return password;
            }
        }
    }
    