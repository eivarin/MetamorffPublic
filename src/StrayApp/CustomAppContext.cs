using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StrayApp
{
    public class CustomAppContext : ApplicationContext
    {
        public CustomAppContext()
        {
            InitializeContext();
        }
        private void InitializeContext()
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.ContextMenuStrip = GetCmsMetamorff();
            notifyIcon.Icon = new Icon("logo.ico");
            notifyIcon.Visible = true;
            FormsExternalStuff.AbrirWWApp();
        }
        private static ContextMenuStrip GetCmsMetamorff()
        {
            ContextMenuStrip CMS = new ContextMenuStrip();
            CMS.Items.Add("Exit", null, new EventHandler(ExitAction));
            CMS.Items.Add("Open", null, new EventHandler(AbrirWWAppEvent));
            return CMS;
        }

        private static void ExitAction(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void AbrirWWAppEvent(object sender, EventArgs e)
        {
            FormsExternalStuff.AbrirWWApp();
        }
    }
}
