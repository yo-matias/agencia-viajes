using AgenciaViajes.Dominio;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AgenciaViajes.Datos.Repositorios
{
    public static class CiudadRepositorio
    {
        public static List<CiudadModel> ObtenerCiudades()
        {
            var ciudades = new List<CiudadModel>();

            using (var context = new EntidadesDb())
            {
                ciudades = context.Ciudades.OrderBy(p => p.Ciudad).ToList();
            }

            return ciudades;
        }
        public static List<CiudadModel> ObtenerCiudadesPorProvincia(int idProvincia)
        {
            var ciudades = new List<CiudadModel>();

            using (var context = new EntidadesDb())
            {
                ciudades = context.Ciudades.Where(p => p.IdProvincia == idProvincia).OrderBy(p => p.Ciudad).ToList();
            }

            return ciudades;
        }

        public static List<CiudadModel> ObtenerCiudadesCompleto()
        {
            var ciudades = new List<CiudadModel>();

            using (var context = new EntidadesDb())
            {
                ciudades = context.Ciudades.OrderBy(p => p.Ciudad)
                                            .Include(c => c.Provincias)
                                            .Include(c => c.Provincias.Paises)
                                            .ToList();
            }

            return ciudades;
        }
    }
}
