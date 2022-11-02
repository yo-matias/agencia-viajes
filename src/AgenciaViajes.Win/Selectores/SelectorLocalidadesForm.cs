using AgenciaViajes.Library.DTO;
using AgenciaViajes.Library.Logic;
using AgenciaViajes.Win.Selectores.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgenciaViajes.Win.Selectores
{
    public partial class SelectorLocalidadesForm : Form
    {
        readonly ILocalidadesRequestor _requestor;
        public List<LocalidadDto> _localidades;

        public SelectorLocalidadesForm(ILocalidadesRequestor caller)
        {
            // Para retornar Localidad
            _requestor = caller;

            InitializeComponent();

            // Búsqueda inicial
            BuscarLocalidades();
        }

        private void BuscarLocalidades()
        {
            var busqueda = AsignarBusqueda();
            _localidades = LocalidadLogic.ObtenerCiudadesPorCriterio(busqueda);
            VincularLista();
        }

        private LocalidadDto AsignarBusqueda()
        {
            var busqueda = new LocalidadDto(txtDescCiudad.Text, txtDescProvincia.Text, txtDescPais.Text);
            return busqueda;
        }

        private void VincularLista()
        {
            gridLocalidades.DataSource = null;
            gridLocalidades.DataSource = _localidades;
        }

        private void GridLocalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtDescCiudad_Enter(object sender, EventArgs e)
        {
            BuscarLocalidades();
        }

        private void TxtDescProvincia_Enter(object sender, EventArgs e)
        {
            BuscarLocalidades();
        }

        private void TxtDescPais_Enter(object sender, EventArgs e)
        {
            BuscarLocalidades();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarLocalidades();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (gridLocalidades.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar una localidad");
                return;
            }
            else
            {
                var localidad = (LocalidadDto)gridLocalidades.SelectedRows[0].DataBoundItem;

                this.Close();
                
                _requestor.CiudadSeleccionada(LocalidadLogic.InstanciarCiudad(localidad));

            }
        }
    }
}
