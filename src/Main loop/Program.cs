    using System;
    using System.Diagnostics;
    using APP;
    using CommonLib.MutexStuff;
    using StrayApp.Pipes;
    using StrayApp;
    using System.Windows.Forms;
    using CommonLib.MainStuff;

    namespace Main_loop
    {
        class Program
        {
            static void Main(string[] args)
            {
                MainProps.StartUP();
                AbrirNotifyIcon();
            }
            private static void AbrirBlazor()
            {
                MyApp.AbrirApp("teste");
            }

            private static void AbrirNotifyIcon()
            {
                FormsExternalStuff.InitializeNotifyIcon();
            }
        }
    }
