using AgenciaViajes.Dominio;
using AgenciaViajes.Dominio.DTO;
using AgenciaViajes.Negocio.Clientes;
using AgenciaViajes.Negocio.Localidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes.Win
{
    public partial class Clientes : Form
    {
        private List<PaisModel> _paises;// = LocalidadLogica.ObtenerPaises();
        private List<PaisModel> _nacionalidad;// = LocalidadLogica.ObtenerPaises();
        private List<ProvinciaModel> _provincias;// = LocalidadLogica.ObtenerProvincias();
        private List<CiudadModel> _ciudades;// = LocalidadLogica.ObtenerCiudades();
        private List<TipoDeClienteModel> _tiposCliente;// = LocalidadLogica.ObtenerCiudades();
        private List<TipoDeDocumentoModel> _tiposDocumento;// = LocalidadLogica.ObtenerCiudades();

        private List<ClienteModel> _clientes = ClientesLogica.ObtenerClientes();

        public Clientes()
        {
            InitializeComponent();
            CargarDatos();
            VincularListas();
        }

        private void VincularListas()
        {
            paisModelBindingSource.DataSource = _paises;
            provinciaModelBindingSource.DataSource = _provincias;
            ciudadModelBindingSource.DataSource = _ciudades;

            tipoDeClienteModelBindingSource.DataSource = _tiposCliente;
            tipoDeDocumentoModelBindingSource.DataSource = _tiposDocumento;

            nacionalidadModelBindingSource.DataSource = _paises; //_nacionalidad;
        }

        private void CargarDatos()
        {
            CargarPaises();
            CargarProvincias();
            CargarCiudades();
            CargarTiposDeClientes();
            CargarTiposDeDocumento();
            CargarNacionalidad();
        }


        #region Botones
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ClienteFormulario cliente = AsignarDatosFormulario();
            ClientesLogica.GuardarClienteFormulario(cliente);
        }

        private ClienteFormulario AsignarDatosFormulario()
        {
            ClienteFormulario cliente = new ClienteFormulario();
            cliente.IdCliente = 0;
            cliente.IdTipoCliente = (int)comboTipoCliente.SelectedValue;
            cliente.NombreCliente = txtNombre.Text;
            cliente.ApellidoCliente = txtApellido.Text;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.DNI = long.Parse(txtDNI.Text);
            cliente.CUIT = long.Parse(txtCUIT.Text);
            cliente.Calle = txtCalle.Text;
            cliente.NroCalle = int.Parse(txtCalleNro.Text);
            cliente.Telefono = long.Parse(txtTelefono.Text);
            cliente.NacionalidadId = (int)comboNacionalidad.SelectedValue;
            cliente.IdCiudad = (int)comboCiudad.SelectedValue;
            return cliente;
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
            CargarCiudades(0);
        }

        private void CargarCiudades(int idProvincia)
        {
            if (idProvincia == 0)
            {
                _ciudades = null; //LocalidadLogica.ObtenerCiudades();
                VincularListas();
            }
            else
            {
                _ciudades = LocalidadLogica.ObtenerCiudadesPorProvincia(idProvincia);
                VincularListas();
            }
        }

        private void CargarProvincias()
        {
            CargarProvincias(0);
        }
        
        private void CargarProvincias(int idPais)
        {
            if (idPais == 0)
            {
                _provincias = null; // LocalidadLogica.ObtenerProvincias();
                VincularListas();
            }
            else
            {
                _provincias = LocalidadLogica.ObtenerProvinciasPorPais(idPais);
                VincularListas();
            }
        }

        private void CargarPaises()
        {
            _paises = LocalidadLogica.ObtenerPaises();
            VincularListas();
        }

        private void CargarTiposDeDocumento()
        {
            _tiposDocumento = ClientesLogica.ObtenerTiposDeDocumentos();
        }

        private void CargarTiposDeClientes()
        {
            _tiposCliente = ClientesLogica.ObtenerTiposDeClientes();
        }
        private void CargarNacionalidad()
        {
            _nacionalidad = LocalidadLogica.ObtenerPaises();
        }

        #endregion

        #region AsignarDatos

        #endregion
    }
}
