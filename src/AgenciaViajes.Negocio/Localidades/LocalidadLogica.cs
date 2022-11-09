using AgenciaViajes.Datos;
using AgenciaViajes.Datos.Repositorios;
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

        /// <summary>
        /// Obtiene la información de todos las provincias
        /// </summary>
        /// <returns>Lista de Información de Provincias</returns>
        public static List<ProvinciaModel> ObtenerProvincias()
        {
            return ProvinciaRepositorio.ObtenerProvincias();
        }

        public static List<ProvinciaModel> ObtenerProvinciasPorPais(int idPais)
        {
            return ProvinciaRepositorio.ObtenerProvinciasPorPais(idPais);
        }

        /// <summary>
        /// Obtiene la información de todos las ciudades
        /// </summary>
        /// <returns>Lista de Información de Ciudades</returns>
        public static List<CiudadModel> ObtenerCiudades()
        {
            return CiudadRepositorio.ObtenerCiudades();
        }

        /// <summary>
        /// Obtiene la información de todos las ciudades
        /// </summary>
        /// <returns>Lista de Información de Ciudades</returns>
        public static List<CiudadModel> ObtenerCiudadesPorProvincia(int idProvincia)
        {
            return CiudadRepositorio.ObtenerCiudadesPorProvincia(idProvincia);
        }
    }
}
