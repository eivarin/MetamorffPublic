using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLib.MutexStuff;
using APP;
using StrayApp.Pipes;
using WebWindows.Blazor;
using System.Drawing;

namespace StrayApp
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon("logo.ico");


            if (TaskVerifier.IsApplicationFirstInstance("SystemTrayAppMutexMetamorff"))
            {
                PipeServer pipeServer = new PipeServer();
                notifyIcon.Visible = false;
                Application.Run(new FormWindowTeste());
                AbrirWWApp();
            }
            else
            {
                MessageBox.Show("Ja existe outro aberto");
                PipeClient pipeClient = new PipeClient();
                Application.Exit();
            }*/
        }

    }
    public static class FormsExternalStuff
    {
        public static void InitializeNotifyIcon()
        {
            if (TaskVerifier.IsApplicationFirstInstance("SystemTrayAppMutexMetamorff"))
            {
                PipeServer pipeServer = new PipeServer();
                StartUpInternal();
            }
            else
            {
                PipeClient pipeClient = new PipeClient();
                Application.Exit();
            }
        }

        public static void StartUpInternal()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationContext application = new CustomAppContext();
            Application.Run(application);
        }

        public static void AbrirWWApp()
        {
            MyApp.AbrirApp("teste");
        }
        public static void RecievedMessageCheck(string mensagem)
        {
            if (mensagem == "Mensagem")
            {
                AbrirWWApp();
            }
        }
    }
}
