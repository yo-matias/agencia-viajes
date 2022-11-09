using AgenciaViajes.Datos;
using AgenciaViajes.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AgenciaViajes.Datos
{
    public static class PaisesRepositorio
    {
        public static List<PaisModel> ObtenerPaises()
        {
            var paises = new List<PaisModel>();

            using (var context = new EntidadesDb())
            {
                paises = context.Paises.OrderBy(p => p.Pais).ToList();
            }

            return paises;
        }
    }
}
