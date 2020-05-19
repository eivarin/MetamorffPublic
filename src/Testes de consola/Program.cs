    using System;
    using CommonLib;
    using CommonLib.Auth;
    using CommonLib.MutexStuff;
    using CommonLib.TorrentStuff;

    namespace Testes_de_consola
    {
        class Program
        {
            static void Main(string[] args)
            {
                TorrentClientAPI.StartItAll();
                Console.ReadKey();
            }
            
        }
        public class Testes
        {
            public void TesteMagnetCriator()
            {
                Console.WriteLine();
            }
            public void TesteTorrentClient()
            {
                TorrentClientAPI.StartItAll();
            }
            public void TesteEncript()
            {
                string valueToHash = Console.ReadLine().ToString();
                ProcessedPassword password = PassEncript.EncriptarString(valueToHash);
                Console.WriteLine("Hash: " + password.Hash);
                Console.WriteLine("Salt: " + password.Salt);
            }
            public async void TesteLogin()
            {
                bool res = await Authorization.Login("root", "ImGroot1234");
                if (res)
                {
                    Console.WriteLine("You did it");
                }
            }
            public void PrintValues(Values values)
            {
                Console.WriteLine("string: " + values.teste1);
                Console.WriteLine("int: " + Convert.ToString(values.numero));
                if (values.testeBool)
                {
                    Console.WriteLine("Conseguiste");
                }
                else
                {
                    Console.WriteLine("Nao conseguiste");
                }
            }
            public void mudarValues(Values values)
            {
                values.numero = 12;
                values.teste1 = "Adeus lua";
                values.testeBool = true;
            }
            public void testeMutex()
            {
                if (TaskVerifier.IsApplicationFirstInstance("Omeunome"))
                {
                    Console.WriteLine("Primeiro processo");
                }
                else
                {
                    Console.WriteLine("Existe outro processo");
                }
                Console.ReadKey();
            }
        }
        public class Values
        {
            public string teste1 = "ola mundo";
            public bool testeBool = false;
            public int numero = 0;
        }
    }
