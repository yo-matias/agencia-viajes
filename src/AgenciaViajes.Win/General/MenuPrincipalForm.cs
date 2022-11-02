using AgenciaViajes.Library.Common;
using AgenciaViajes.Library.DataAccess;
using AgenciaViajes.Library.Models;
using AgenciaViajes.Win.General;
using AgenciaViajes.Win.Selectores;
using AgenciaViajes.Win.Selectores.Interfaces;
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
    public partial class MenuPrincipalForm : Form, ILocalidadesRequestor
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

            ValidarConexionDB();
        }

        /// <summary>
        /// Controla si es válida la conexión a la DB
        /// </summary>
        private void ValidarConexionDB()
        {
            if (!Configuracion.ValidarConexionDB())
            {
                // Inhabilito botones
                btnGestionNacionalidades.Enabled = false;
                btnGestionLocalidades.Enabled = false;

                // Muestro alerta
                MessageBox.Show("Error al intentar conectar a la DB.", "Error DB", MessageBoxButtons.OK);
                
            }
            
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

        private void btnSelectorLocalidades_Click(object sender, EventArgs e)
        {
            var form = new SelectorLocalidadesForm(this);
            form.Show();
        }

        public void CiudadSeleccionada(CiudadModel ciudad)
        {
            MessageBox.Show($"Localidad seleccionada: {ciudad.Descripcion} de la provincia de {ciudad.Provincia.Descripcion} en el país {ciudad.Provincia.Pais.Descripcion}!");
        }
    }
}
