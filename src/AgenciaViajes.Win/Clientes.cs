using AgenciaViajes.Dominio;
using AgenciaViajes.Dominio.DTO;
using AgenciaViajes.Negocio.Clientes;
using AgenciaViajes.Negocio.Localidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AgenciaViajes.Win
{
    public partial class Clientes : Form
    {
        private List<PaisModel> _paises;// = LocalidadLogica.ObtenerPaises();
        private List<ProvinciaModel> _provincias;// = LocalidadLogica.ObtenerProvincias();
        private List<CiudadModel> _ciudades;// = LocalidadLogica.ObtenerCiudades();
        private List<TipoDeClienteModel> _tiposCliente;// = LocalidadLogica.ObtenerCiudades();
        private List<TipoDeDocumentoModel> _tiposDocumento;// = LocalidadLogica.ObtenerCiudades();

        private List<ClienteGrid> _clientes;
        private ClienteModel _cliente = new ClienteModel();

        public Clientes()
        {
            InitializeComponent();
            CargarDatos();
            LimpiarFormulario();
        }

        private void CargarDatos()
        {
            CargarPaises();
            CargarProvincias();
            CargarCiudades();

            CargarTiposDeClientes();
            CargarTiposDeDocumento();

            CargarClientes();
        }


        #region Botones
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() && ValidarCliente())
            {
                clienteModelBindingSource.EndEdit();
                ClientesLogica.GuardarCliente(_cliente);
                LimpiarFormulario();
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Por favor, verifique la información ingresada.", "Error en Formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        #endregion

        #region Combos_Localidad

        private void ComboPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var pais = (PaisModel)comboPais.SelectedItem;
            if (pais != null)
            {
                CargarProvincias(pais.IdPais);
            }
        }

        private void ComboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var provincia = (ProvinciaModel)comboProvincia.SelectedItem;
            if (provincia != null)
            {
                CargarCiudades(provincia.IdProvincia);
            }
        }

        private void ComboCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //
        }

        #endregion

        #region CargaCombos

        private void CargarCiudades()
        {
            CargarCiudades(-1);
        }

        private void CargarCiudades(int idProvincia)
        {
            _ciudades = LocalidadLogica.ObtenerCiudadesPorProvincia(idProvincia);
            ciudadModelBindingSource.DataSource = _ciudades;
        }

        private void CargarProvincias()
        {
            CargarProvincias(-1);
        }

        private void CargarProvincias(int idPais)
        {
            _provincias = LocalidadLogica.ObtenerProvinciasPorPais(idPais);
            provinciaModelBindingSource.DataSource = _provincias;
        }

        private void CargarPaises()
        {
            _paises = LocalidadLogica.ObtenerPaises();
            nacionalidadModelBindingSource.DataSource = _paises;
            paisModelBindingSource.DataSource = _paises;
        }

        private void CargarTiposDeDocumento()
        {
            _tiposDocumento = ClientesLogica.ObtenerTiposDeDocumentos();
            tipoDeDocumentoModelBindingSource.DataSource = _tiposDocumento;
        }

        private void CargarTiposDeClientes()
        {
            _tiposCliente = ClientesLogica.ObtenerTiposDeClientes();
            tipoDeClienteModelBindingSource.DataSource = _tiposCliente;
        }
        private void CargarClientes()
        {
            _clientes = ClientesLogica.ObtenerClientesGrid();
            clienteGridBindingSource.DataSource = _clientes;
        }

        #endregion

        #region AsignarDatos

        #endregion

        #region BotonesGrid

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickBotonGrid(sender, e);
        }

        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickBotonGrid(sender, e);
        }

        private void ClickBotonGrid(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int idCliente = (int)gridClientes.Rows[e.RowIndex].Cells[2].Value;

                switch (e.ColumnIndex)
                {
                    case 0:
                        // Editar
                        EditarFilaGrid(idCliente);
                        break;
                    case 1:
                        // Eliminar
                        EliminarFilaGrid(idCliente);
                        break;
                    default:
                        // No es un botón válido
                        break;
                }
            }
        }

        private void EliminarFilaGrid(int idCliente)
        {
            EliminarCliente(idCliente);
        }

        private void EditarFilaGrid(int idCliente)
        {
            CargarClienteEdicion(idCliente);
        }

        private void EliminarCliente(int idCliente)
        {
            var dialogResult = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ClientesLogica.EliminarCliente(idCliente);
                CargarClientes();
            }
        }

        private void CargarClienteEdicion(int idCliente)
        {
            _cliente = ClientesLogica.ObtenerClientePorId(idCliente);
            clienteModelBindingSource.DataSource = _cliente;
            CargarProvincias(_cliente.Ciudad.Provincias.IdPais);
            CargarCiudades(_cliente.Ciudad.IdProvincia);
        }

        #endregion

        private void LimpiarFormulario()
        {
            clienteModelBindingSource.EndEdit();
            _cliente = new ClienteModel();
            clienteModelBindingSource.DataSource = _cliente;

            comboCiudad.SelectedIndex = -1;
            comboProvincia.SelectedIndex = -1;
            comboPais.SelectedIndex = -1;
        }

        private void ComboTipoCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            MostrarOcultarTipoCliente();
        }

        private void MostrarOcultarTipoCliente()
        {
            var tipoCliente = (TipoDeClienteModel)comboTipoCliente.SelectedItem;
            if (tipoCliente != null)
            {
                switch (tipoCliente.IdTipoCliente)
                {
                    case 1:
                        // Particular
                        txtRazonSocial.Enabled = false;
                        txtRazonSocial.Text = string.Empty;
                        _cliente.RazónSocial = string.Empty;

                        txtCUIT.Enabled = false;
                        txtCUIT.Text = string.Empty;
                        _cliente.CUIT = string.Empty;
                        break;
                    case 2:
                        // Corporativo
                        txtRazonSocial.Enabled = true;

                        txtCUIT.Enabled = true;
                        break;
                    default:
                        // No es un tipo de cliente válido
                        break;
                }
            }
        }

        #region Validaciones

        private void ComboTipoCliente_Validating(object sender, CancelEventArgs e)
        {
            var tipoCliente = (TipoDeClienteModel)comboTipoCliente.SelectedItem;
            if (tipoCliente == null)
            {
                errorProviderTipoCliente.SetError(comboTipoCliente, "Tipo de Cliente es requerido.");
            }
            else
            {
                errorProviderTipoCliente.SetError(comboTipoCliente, null);
            }
        }
        private void TxtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            var tipoCliente = (TipoDeClienteModel)comboTipoCliente.SelectedItem;
            if (tipoCliente != null
                && tipoCliente.IdTipoCliente == 2
                && string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                errorProviderRazonSocial.SetError(txtRazonSocial, "Razón Social es requerido.");
            }
            else
            {
                errorProviderRazonSocial.SetError(txtRazonSocial, null);
            }
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorProviderDNI.SetError(txtTelefono, "Teléfono es requerida.");
            }
            else if (!int.TryParse(txtTelefono.Text, out _))
            {
                errorProviderTelefono.SetError(txtTelefono, "Teléfono debe ser numérico.");
            }
            else
            {
                errorProviderTelefono.SetError(txtTelefono, null);
            }
        }

        private void ComboCiudad_Validating(object sender, CancelEventArgs e)
        {
            var ciudad = (CiudadModel)comboCiudad.SelectedItem;
            if (ciudad == null)
            {
                errorProviderCiudad.SetError(comboCiudad, "Localidad es requerida.");
            }
            else
            {
                errorProviderCiudad.SetError(comboCiudad, null);
            }
        }

        private void TxtCalleNro_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCalleNro.Text))
            {
                errorProviderDNI.SetError(txtCalleNro, "Altura es requerida.");
            }
            else if (!int.TryParse(txtCalleNro.Text, out _))
            {
                errorProviderCalleNro.SetError(txtCalleNro, "Altura debe ser numérica.");
            }
            else
            {
                errorProviderCalleNro.SetError(txtCalleNro, null);
            }
        }
        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            var tipoCliente = (TipoDeClienteModel)comboTipoCliente.SelectedItem;
            if (tipoCliente != null
                && tipoCliente.IdTipoCliente == 1
                && string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProviderNombre.SetError(txtNombre, "Nombre es requerido.");
            }
            else
            {
                errorProviderNombre.SetError(txtNombre, null);
            }
        }

        private void TxtApellido_Validating(object sender, CancelEventArgs e)
        {
            var tipoCliente = (TipoDeClienteModel)comboTipoCliente.SelectedItem;
            if (tipoCliente != null
                && tipoCliente.IdTipoCliente == 1
                && string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProviderApellido.SetError(txtApellido, "Apellido es requerido.");
            }
            else
            {
                errorProviderApellido.SetError(txtApellido, null);
            }
        }

        private void TxtCUIT_Validating(object sender, CancelEventArgs e)
        {
            var tipoCliente = (TipoDeClienteModel)comboTipoCliente.SelectedItem;
            if (tipoCliente != null
                && tipoCliente.IdTipoCliente == 2
                && string.IsNullOrEmpty(txtCUIT.Text))
            {
                errorProviderCUIT.SetError(txtCUIT, "CUIT es requerido.");
            }
            else
            {
                errorProviderCUIT.SetError(txtCUIT, null);
            }
        }

        #endregion

        private void ComboTipoDocumento_Validating(object sender, CancelEventArgs e)
        {
            var tipoDocumento = (TipoDeDocumentoModel)comboTipoDocumento.SelectedItem;
            if (tipoDocumento == null
                && !string.IsNullOrEmpty(txtDNI.Text))
            {
                errorProviderTipoDocumento.SetError(comboTipoDocumento, "Tipo de Documento es requerido.");
            }
            else
            {
                errorProviderTipoDocumento.SetError(comboTipoDocumento, null);
            }
        }

        private void TxtDNI_Validating(object sender, CancelEventArgs e)
        {
            var tipoDocumento = (TipoDeDocumentoModel)comboTipoDocumento.SelectedItem;
            if (tipoDocumento != null
                && string.IsNullOrEmpty(txtDNI.Text))
            {
                errorProviderDNI.SetError(txtDNI, "Tipo de Documento es requerido.");
            }
            else
            {
                errorProviderDNI.SetError(txtDNI, null);
            }
        }

        private bool ValidarCliente()
        {
            // Aunque están los métodos de "Validating", agrego esto temporalmente para salvar falso positivo
            bool valido = true;
            
            if (_cliente == null)
            {
                valido = false;
            }

            if (_cliente.IdTipoCliente == 0)
            {
                valido = false;
            }

            if (_cliente.IdCiudad == 0)
            {
                valido = false;
            }

            if (_cliente.NacionalidadId == 0)
            {
                valido = false;
            }

            return valido;
        }
    }
}
