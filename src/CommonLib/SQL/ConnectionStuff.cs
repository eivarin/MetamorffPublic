    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    namespace CommonLib.SQL
    {
        static class ConnectionStuff
        {
            private static string ConString { get; set; } = "Data Source=metamorffdb.ccscdo6x7yw4.eu-west-2.rds.amazonaws.com,1433;Initial Catalog=Metamorff;User ID=client;Password=N1c3Cl!3n7P4$$w0rD;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            public static SqlConnection con { get; private set; } = new SqlConnection(ConString);

            public static async void OpenCon()
            {
                await con.OpenAsync();
            }
        }
    }
