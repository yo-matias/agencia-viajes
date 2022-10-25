using AgenciaViajes.Library.Logic;
using AgenciaViajes.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes.Win.General
{
    public partial class GestionLocalidadesForm : Form
    {
        #region Listas

        public List<CiudadModel> _ciudades; //= LocalidadLogic.ObtenerCiudadesTodas();
        public List<ProvinciaModel> _provincias; //= LocalidadLogic.ObtenerProvinciasTodas();
        public List<PaisModel> _paises;// = LocalidadLogic.ObtenerPaisesTodas();

        #endregion

        public GestionLocalidadesForm()
        {
            InitializeComponent();
            CargarLocalidades();
        }

        /// <summary>
        /// Vincula las listas con los componentes en pantalla
        /// </summary>
        private void VincularListas()
        {
            // Grid Ciudades
            gridCiudades.DataSource = null;
            gridCiudades.DataSource = _ciudades;

            // GridProvincias
            gridProvincias.DataSource = null;
            gridProvincias.DataSource = _provincias;

            // GridPaises
            gridPaises.DataSource = null;
            gridPaises.DataSource = _paises;
        }

        public void CargarLocalidades()
        {
            CargarPaises();
            CargarProvincias();
            CargarCiudades();

            VincularListas();
        }

        public void CargarPaises()
        {
            _paises = LocalidadLogic.ObtenerPaisesTodas();
        }

        public void CargarProvincias()
        {
            _provincias = LocalidadLogic.ObtenerProvinciasTodas();
        }

        public void CargarCiudades()
        {
            _ciudades = LocalidadLogic.ObtenerCiudadesTodas();
        }

        /// <summary>
        /// Salir de Pantalla
        /// </summary>
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRecargarTodo_Click(object sender, EventArgs e)
        {
            CargarLocalidades();
        }
    }
}