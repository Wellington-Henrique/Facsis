using System;
using System.Windows.Forms;
using Facsis.View;

namespace Facsis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Form janela = new frmSplash();

            //if (janela.ShowDialog() == DialogResult.OK)
            //{
            //    janela = new frmLogin();

            //    if (janela.ShowDialog() == DialogResult.OK)
            //        Application.Run(new mdiPrincipal());

            Application.Run(new frmCadProduto());
        //}
        }
    }
}
