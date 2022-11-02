using AgenciaViajes.Library.DataAccess;
using AgenciaViajes.Library.DTO;
using AgenciaViajes.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Library.Logic
{
    /// <summary>
    /// Lógica de negocio para Localidades
    /// </summary>
    public static class LocalidadLogic
    {
        #region Ciudades
        
        /// <summary>
        /// Obtiene todas las Ciudades
        /// </summary>
        /// <returns>Lista de Ciudades</returns>
        public static List<CiudadModel> ObtenerCiudadesTodas()
        {
            return CiudadesRepository.ObtenerCiudades();
        }

        public static List<CiudadModel> ObtenerCiudadesPorDescripcion(string descripcion)
        {
            return CiudadesRepository.ObtenerCiudadesPorDescripcion(descripcion);
        }

        public static List<LocalidadDto> ObtenerCiudadesPorCriterio(LocalidadDto busqueda)
        {
            return CiudadesRepository.ObtenerCiudadesPorCriterio(busqueda);
        }

        public static CiudadModel InstanciarCiudad(LocalidadDto localidad)
        {
            PaisModel pais = new PaisModel(localidad.IdPais, localidad.DescripcionPais);
            ProvinciaModel provincia = new ProvinciaModel(localidad.IdProvincia, localidad.DescripcionProvincia, pais);
            CiudadModel ciudad = new CiudadModel(localidad.IdCiudad, localidad.DescripcionCiudad, provincia);

            return ciudad;

        }

        #endregion

        #region Provincias

        /// <summary>
        /// Obtiene las Provincias
        /// </summary>
        /// <returns>Lista de Provincias</returns>
        public static List<ProvinciaModel> ObtenerProvinciasTodas()
        {
            return ProvinciasRepository.ObtenerProvincias();
        }

        public static List<ProvinciaModel> ObtenerProvinciasPorDescripcion(string descripcion)
        {
            return ProvinciasRepository.ObtenerProvinciasPorDescripcion(descripcion);
        }

        #endregion

        #region Países

        /// <summary>
        /// Obtiene los Países
        /// </summary>
        /// <returns>Lista de Países</returns>
        public static List<PaisModel> ObtenerPaisesTodas()
        {
            return PaisesRepository.ObtenerPaises();
        }

        public static List<PaisModel> ObtenerPaisesPorDescripcion(string descripcion)
        {
            return PaisesRepository.ObtenerPaisesPorDescripcion(descripcion);
        }
        
        #endregion
    }
}
