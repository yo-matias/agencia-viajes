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
        public static List<PaisModel> ObtenerPaises()
        {
            var paises = PaisesRepositorio.ObtenerPaises();

            return paises;
        }
    }
}
