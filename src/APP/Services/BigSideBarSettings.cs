    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    namespace APP.Services
    {
        public class BigSideBarSettings
        {
            public bool Mostrar {get;set;}

            public string TopBarTitle{ get;set; }
            public string TopBarButton{ get;set; }

            public int TipoSidebar{get;set;}

            public int IdRedeAtiva{get;set;}
            public BigSideBarSettings()
            {

            }
        }
    }
