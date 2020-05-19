    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using CommonLib.Auth;

    namespace APP.Services
    {
        public class SideBarProps
        {
            public BigSideBarSettings BigSideBarProps {get;set;} = new BigSideBarSettings();

            public int PaginaAtiva {get;set;} = 0;

            public SideBarProps()
            {
                
            }
        }
    }
