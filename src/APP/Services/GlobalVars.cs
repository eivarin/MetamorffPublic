    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using CommonLib.Auth;
    using CommonLib.Models;

    namespace APP.Services
    {
        public class GlobalVars
        {
            public string mystring { get; set; } = "nao conseguiste";

            public LoginInfo loginInfo { get; set; }
            
            public string CurrAuthPage {get; set;} = "";

            public NetModel WorkerNetHolder{get;set;}
            public NetModel WorkerFileHolder{get;set;}

            public List<string> PreviousPages{get;set;} = new List<string>();

            public GlobalVars()
            {
                loginInfo = new LoginInfo();
                loginInfo.IsLoggedIn = false;
            }
        }
    }
