using AgenciaViajes.Library.DataAccess;
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
        
        #endregion
    }
}
