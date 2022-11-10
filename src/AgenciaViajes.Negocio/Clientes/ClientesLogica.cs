using AgenciaViajes.Datos.Repositorios;
using AgenciaViajes.Dominio;
using AgenciaViajes.Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Negocio.Clientes
{
    public static class ClientesLogica
    {
        #region ObtencionDatos

        /// <summary>
        /// Obtiene la información de todos los Clientes
        /// </summary>
        /// <returns>Lista de Clientes</returns>
        public static List<ClienteModel> ObtenerClientes()
        {
            return ClienteRepositorio.ObtenerClientes();
        }

        /// <summary>
        /// Obtiene la información de todos los Clientes habilitados
        /// </summary>
        /// <returns>Lista de Clientes</returns>
        public static List<ClienteModel> ObtenerClientesHabilitados()
        {
            return ClienteRepositorio.ObtenerClientesHabilitados();
        }

        public static List<TipoDeClienteModel> ObtenerTiposDeClientes()
        {
            return TipoDeClienteRepositorio.ObtenerTiposDeClientes();
        }

        public static List<TipoDeDocumentoModel> ObtenerTiposDeDocumentos()
        {

            return TipoDeDocumentoRepositorio.ObtenerTiposDeDocumento();
        }

        #endregion

        public static void GuardarCliente(ClienteModel cliente)
        {
            ClienteRepositorio.GuardarCliente(cliente);
        }

        public static void GuardarClienteCorporativo(ClienteCorporativo cliente)
        {

            throw new NotImplementedException();
        }

        public static void GuardarClienteParticular(ClienteParticular cliente)
        {

            throw new NotImplementedException();
        }

        public static void GuardarClienteFormulario(ClienteFormulario cliente)
        {
            throw new NotImplementedException();
        }

        public static List<ClienteGrid> ObtenerClientesGrid()
        {
            List<ClienteGrid> grid = new List<ClienteGrid>();

            var clientes = ObtenerClientesHabilitados();

            foreach (var cliente in clientes)
            {
                grid.Add(new ClienteGrid
                {
                    IdCliente = cliente.IdCliente,
                    TipoCliente = cliente.TipoCliente.DescripcionTipoCliente,
                    Descripcion = cliente.IdTipoCliente == 1 ? $"{cliente.NombreCliente} {cliente.ApellidoCliente}" : cliente.RazónSocial
                });
            }

            return grid;
        }

        public static ClienteModel ObtenerClientePorId(int idCliente)
        {
            return ClienteRepositorio.ObtenerClientePorId(idCliente);
        }

        public static void EliminarCliente(int idCliente)
        {

            ClienteRepositorio.BajaLogicaCliente(idCliente);
        }
    }
}
