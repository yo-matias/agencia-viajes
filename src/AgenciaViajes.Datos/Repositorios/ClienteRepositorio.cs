using AgenciaViajes.Dominio;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
        /// Retorna la lista de todos los Clientes habilitados, con información secundaria del mismo
        /// </summary>
        /// <returns>Lista de Clientes habilitados</returns>
        public static List<ClienteModel> ObtenerClientesHabilitados()
        {
            using (var context = new EntidadesDb())
            {
                var clientes = context.Clientes.Where(c => c.Habilitado)
                                                .Include(c => c.TipoCliente)
                                                .Include(c => c.TipoDocumento)
                                                .Include(c => c.Nacionalidad)
                                                .Include(c => c.Ciudad)
                                                .Include(c => c.Ciudad.Provincias)
                                                .ToList();
                return clientes;
            }
        }

        /// <summary>
        /// Retorna información de un Cliente según el Identificador
        /// </summary>
        /// <returns>Información de Cliente</returns>
        public static ClienteModel ObtenerClientePorId(int idCliente)
        {
            using (var context = new EntidadesDb())
            {
                var cliente = context.Clientes.Where(c => c.IdCliente == idCliente)
                                                .Include(c => c.TipoCliente)
                                                .Include(c => c.TipoDocumento)
                                                .Include(c => c.Nacionalidad)
                                                .Include(c => c.Ciudad)
                                                .Include(c => c.Ciudad.Provincias)
                                                .FirstOrDefault();
                return cliente;
            }
        }

        public static void BajaLogicaCliente(int idCliente)
        {
            using (var context = new EntidadesDb())
            {
                var cliente = context.Clientes.Where(c => c.IdCliente == idCliente)
                                                .FirstOrDefault();
                cliente.Habilitado = false;

                context.SaveChanges();
            }

        }

        public static void GuardarCliente(ClienteModel cliente)
        {
            using (var context = new EntidadesDb())
            {
                var entidad = context.Clientes.Find(cliente.IdCliente);
                if (entidad != null)
                {
                    context.Entry(entidad).CurrentValues.SetValues(cliente);
                }
                else
                {
                    context.Clientes.Add(cliente);
                }
                context.SaveChanges();
            }
        }
    }
}
