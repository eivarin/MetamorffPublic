    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Text;

    namespace CommonLib.Auth
    {
    public static class SaltGenerator
        {
            public static string RandomString()
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                var ArrayComRNG = new Byte[32]; 
                rng.GetNonZeroBytes(ArrayComRNG);
                string r = Convert.ToBase64String(ArrayComRNG);
                return r;
            }
        }
    }
