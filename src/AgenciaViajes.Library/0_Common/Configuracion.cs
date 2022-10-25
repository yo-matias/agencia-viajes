using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Library.Common
{
    /// <summary>
    /// Case de acceso a configuración del aplicativo
    /// </summary>
    public static class Configuracion
    {
        /// <summary>
        /// Nombre de la Base de Datos
        /// </summary>
        public static readonly string NombreDB = "AgenciaViajesDB";
        
        /// <summary>
        /// Obtiene la cadena de conexión a DB almacenada en la configuración
        /// </summary>
        /// <returns>Cadena de Conexión a DB</returns>
        public static string ObtenerConnectionString()
        {
            //TODO: Controlar que exista la cadena de conexión
            return ConfigurationManager.ConnectionStrings[NombreDB].ConnectionString;
        }

        /// <summary>
        /// Obtiene configuración
        /// </summary>
        /// <param name="parametro">Parámetro a obtener</param>
        /// <returns>Parámetro de Configuración</returns>
        public static string ObtenerConfig(string parametro)
        {

            return ConfigurationManager.AppSettings[parametro];
        }
    }
}
