using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

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
            string connectionString = ConfigurationManager.ConnectionStrings[NombreDB].ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("No existe información de conexión.");
            }
            return connectionString;
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

        /// <summary>
        /// Valida si la conexión a la DB es funcional
        /// </summary>
        /// <returns>Verdadero en caso de conectar correctamente</returns>
        public static bool ValidarConexionDB()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ObtenerConnectionString()))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
