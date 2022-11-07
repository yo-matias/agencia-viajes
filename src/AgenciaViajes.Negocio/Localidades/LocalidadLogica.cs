using AgenciaViajes.Datos;
using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Negocio.Localidades
{
    public static class LocalidadLogica
    {
        /// <summary>
        /// Obtiene la información de todos los países
        /// </summary>
        /// <returns>Lista de Información de Países</returns>
        public static List<PaisModel> ObtenerPaises()
        {
            var paises = PaisesRepositorio.ObtenerPaises();

            return paises;
        }
    }
}
