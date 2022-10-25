using AgenciaViajes.Library.Common;
using AgenciaViajes.Library.DataAccess;
using AgenciaViajes.Win.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes.Win.General
{
    public partial class MenuPrincipalForm : Form
    {
        
        public MenuPrincipalForm()
        {
            //TODO: sacar esto
            // Para el Splash
            Thread thread = new Thread(new ThreadStart(SplashForm));
            // Inicia hilo
            thread.Start();
            // Espera 3 segundos
            Thread.Sleep(1000);

            InitializeComponent();

            // Corta hilo
            thread.Abort();
        }

        public void SplashForm()
        {
            Application.Run(new SplashForm());
        }

        #region Gestiones

        private void BtnGestionNacionalidades_Click(object sender, EventArgs e)
        {
            var gestionNacionalidadesForm = new GestionNacionalidadesForm();
            gestionNacionalidadesForm.Show();
        }

        private void BtnGestionLocalidades_Click(object sender, EventArgs e)
        {
            var gestionLocalidadesForm = new GestionLocalidadesForm();
            gestionLocalidadesForm.Show();
        }

        #endregion

        #region General

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }

        #endregion
    }
}
