using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP;

namespace StrayApp
{
    public partial class FormWindowTeste : Form
    {
        public FormWindowTeste()
        {
            InitializeComponent();
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            FormsExternalStuff.AbrirWWApp();
        }
    }
}
