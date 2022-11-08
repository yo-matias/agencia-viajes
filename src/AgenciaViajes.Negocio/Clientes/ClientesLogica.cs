using AgenciaViajes.Datos.Repositorios;
using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Negocio.Clientes
{
    public static class ClientesLogica
    {
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
    }
}
