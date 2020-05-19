    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace CommonLib.Auth
    {
        public class LoginInfo
        {
            public bool IsLoggedIn { get; set; } = false;
            
            public string Username { get; set; }
        }
    }
