using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Datos.Repositorios
{
    public static class TipoDeDocumentoRepositorio
    {
        /// <summary>
        /// Obtiene la información de tipos de Documentos
        /// </summary>
        /// <returns>Lista de Tipos de Documentos</returns>
        public static List<TipoDeDocumentoModel> ObtenerTiposDeDocumento()
        {
            using (var context = new EntidadesDb())
            {
                var tipos = context.TiposDocumento.OrderBy(t => t.DescripcionTipoDocumento).ToList();
                return tipos;
            }
        }
    }
}
