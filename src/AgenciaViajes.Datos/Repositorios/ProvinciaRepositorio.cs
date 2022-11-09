using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Datos.Repositorios
{
    public static class ProvinciaRepositorio
    {
        public static List<ProvinciaModel> ObtenerProvincias()
        {
            var provincias = new List<ProvinciaModel>();

            using (var context = new EntidadesDb())
            {
                provincias = context.Provincias.OrderBy(p => p.Provincia).ToList();
            }

            return provincias;
        }
        public static List<ProvinciaModel> ObtenerProvinciasPorPais(int idPais)
        {
            var provincias = new List<ProvinciaModel>();

            using (var context = new EntidadesDb())
            {
                provincias = context.Provincias.Where(p => p.IdPais == idPais).OrderBy(p => p.Provincia).ToList();
            }

            return provincias;
        }
    }
}
