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
    public partial class GestionNacionalidadesForm : Form
    {
        public readonly List<NacionalidadModel> _nacionalidades = NacionalidadLogic.ObtenerNacionalidadesTodas();
        public GestionNacionalidadesForm()
        {
            InitializeComponent();
            VincularListas();
        }

        private void VincularListas()
        {
            gridNacionalidades.DataSource = null;
            gridNacionalidades.DataSource = _nacionalidades;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
