using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Datos.Repositorios
{
    public static class ClienteRepositorio
    {
        /// <summary>
        /// Retorna la lista de todos los Clientes
        /// </summary>
        /// <returns>Lista de Clientes</returns>
        public static List<ClienteModel> ObtenerClientes()
        {
            var clientes = new List<ClienteModel>();

            using (var context = new EntidadesDb())
            {
                clientes = context.Clientes.ToList();
            }

            return clientes;
        }

        /// <summary>
        /// Retorna la lista de todos los Clientes habilitados
        /// </summary>
        /// <returns>Lista de Clientes habilitados</returns>
        public static List<ClienteModel> ObtenerClientesHabilitados()
        {
            using (var context = new EntidadesDb())
            {
                var clientes = context.Clientes.Where(c => c.Habilitado).ToList();
                return clientes;
            }
        }
    }
}
