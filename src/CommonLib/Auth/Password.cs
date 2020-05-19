    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace CommonLib.Auth
    {
        public class ProcessedPassword
        {
            public string Hash { get; set; }

            public string Salt { get; set; }

            public ProcessedPassword(string PassHash, string PassSalt)
            {
                Hash = PassHash;
                Salt = PassSalt;
            }
        }
    }
