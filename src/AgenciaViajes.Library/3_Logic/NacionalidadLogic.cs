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
    /// Lógica de negocio para Nacionalidades
    /// </summary>
    public static class NacionalidadLogic
    {
        /// <summary>
        /// Obtiene todas las Nacionalidades
        /// </summary>
        /// <returns>Lista de Nacionalidades</returns>
        public static List<NacionalidadModel> ObtenerNacionalidadesTodas()
        {
            var nacionalidades = NacionalidadesRepository.ObtenerNacionalidades();

            return nacionalidades;
        }
        
        /// <summary>
        /// Obtiene Nacionalidad
        /// </summary>
        /// <param name="id">Identificador de Nacionalidad</param>
        /// <returns>Nacionalidad</returns>
        public static NacionalidadModel ObtenerNacionalidadesSegunId(int id)
        {
            var nacionalidad = NacionalidadesRepository.ObtenerNacionalidadPorId(id);
            
            return nacionalidad;
        }

        /// <summary>
        /// Inserta una Nacionalidad
        /// </summary>
        /// <param name="nacionalidad">Información de Nacionalidad</param>
        public static void InsertarNacionalidad(NacionalidadModel nacionalidad)
        {
            //TODO: Validar existencia antes del alta?
            NacionalidadesRepository.InsertarNacionalidad(nacionalidad);
        }
    }
}
