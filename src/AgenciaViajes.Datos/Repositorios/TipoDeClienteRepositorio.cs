using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Datos.Repositorios
{
    public static class TipoDeClienteRepositorio
    {
        /// <summary>
        /// Obtiene la información de tipos de Clientes
        /// </summary>
        /// <returns>Lista de Tipos de Clientes</returns>
        public static List<TipoDeClienteModel> ObtenerTiposDeClientes()
        {
            using (var context = new EntidadesDb())
            {
                var tipos = context.TiposCliente.OrderBy(t => t.DescripcionTipoCliente).ToList();
                return tipos;
            }
        }
    }
}
