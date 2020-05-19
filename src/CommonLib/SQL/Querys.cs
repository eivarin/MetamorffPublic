    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Text;
    using System.Threading.Tasks;

    namespace CommonLib.SQL
    {
        public static class Querys
        {
            private static SqlConnection con  = ConnectionStuff.con;

            private static SqlDataReader SQLReader { get; set; }

            public static async Task<List<List<object>>> SelectQuery(string CamposParaSelecionar, string Tabela, string Condicoes)
            {
                String CommandSTR = "SELECT " + CamposParaSelecionar + " FROM " + Tabela + " WHERE " + Condicoes + ";";
                SqlCommand Command  = new SqlCommand(CommandSTR, con);
                List<List<object>> ListaRes = new List<List<object>>();
                using (SQLReader = await Command.ExecuteReaderAsync())
                {
                    Int32 RowCount = 0;
                    while (SQLReader.Read())
                    {
                        ListaRes.Add(new List<object>());
                        for (int ColumnCount = 0; ColumnCount < SQLReader.FieldCount; ColumnCount++)
                        {
                            ListaRes[RowCount].Add(SQLReader.GetValue(ColumnCount));
                        }
                        RowCount-=-1;
                        ListaRes.Add(new List<object>());
                        ListaRes[0].Add("0RES");
                    }
                    return ListaRes;
                }
            }

            public static async void UpdateQuery(string Tabela, string CamposParaUpdate, string Condicoes)
            {
                String CommandSTR = "UPDATE " + Tabela + " SET " + CamposParaUpdate + " WHERE " + Condicoes + ";";
                SqlCommand Command = new SqlCommand(CommandSTR, con);
                await Command.ExecuteNonQueryAsync();
            }
            public static async void UpdateQueryWithParams(string Tabela, string CamposParaUpdate, string Condicoes, string ParamaterName,object ParameterValue)
            {
                String CommandSTR = "UPDATE " + Tabela + " SET " + CamposParaUpdate + " WHERE " + Condicoes + ";";
                SqlCommand Command = new SqlCommand(CommandSTR, con);
                Command.Parameters.AddWithValue(ParamaterName, ParameterValue);
                await Command.ExecuteNonQueryAsync();
            }
            public static async Task<byte[]> GetByteArrFromDB(string Tabela, string ReqByteArray, string Condicoes)
            {
                byte[] Result = null;
                String CommandSTR = "SELECT " + ReqByteArray + " FROM " + Tabela + " WHERE " + Condicoes + ";";
                SqlCommand Command = new SqlCommand(CommandSTR, con);
                using (SQLReader = await Command.ExecuteReaderAsync())
                {
                    if (SQLReader.Read())
                    {
                        Result = (byte[])SQLReader[0];
                    }
                    return Result;
                }
                
            }
            public static async void InsertQuery(string Tabela, string CamposParaInserir , string ValoresParaInserir)
            {
                String CommandSTR = "INSERT INTO " + Tabela + " " + CamposParaInserir + " VALUES " + ValoresParaInserir + ";";
                SqlCommand Command = new SqlCommand(CommandSTR, con);
                await Command.ExecuteNonQueryAsync();
            }
            public static async void DeleteQuery(string Tabela, string Condicoes)
            {
                String CommandSTR = "DELETE FROM " + Tabela + "WHERE" + Condicoes + ";";
                SqlCommand Command = new SqlCommand(CommandSTR, con);
                await Command.ExecuteNonQueryAsync();
            }
            
        }
    }
