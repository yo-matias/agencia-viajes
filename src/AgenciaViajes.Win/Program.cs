using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes.Win
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Principal());

            // Integración con pantalla de inicio de sesión
            Login frmLogin = new Login();
            // Si el formulario retorna éxito, inicio menú principal
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Principal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
