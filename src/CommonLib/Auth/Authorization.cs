    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using CommonLib.SQL;

    namespace CommonLib.Auth
    {
        public class Authorization
        {

            public static async Task<bool> Login(string UN, string PW)
            {
                bool res = false;
                try
                {
                    List<List<object>> ResParaSalt = await Querys.SelectQuery("PasswordSalt", "Users", "Username = '" + UN + "'");
                    string Salt = ResParaSalt[0][0].ToString();
                    ProcessedPassword Password = PassEncript.EncriptarString(PW, Salt);
                    List<List<object >> ResultadoFinal = await Querys.SelectQuery("*", "Users", "Username = '" + UN + "' AND " + "PasswordHash = '" + Password.Hash + "'");
                    if (ResultadoFinal[0][0].ToString() != "0RES")
                    {
                        res = true;
                    }
                }
                catch (Exception e)
                {
                    res = false;
                }
                return res;
            }
        }
    }
