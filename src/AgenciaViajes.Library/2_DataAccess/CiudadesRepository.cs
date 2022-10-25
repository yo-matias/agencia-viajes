using AgenciaViajes.Library.Common;
using AgenciaViajes.Library.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Library.DataAccess
{
    /// <summary>
    /// Repositorio de trabajar con Ciudades en la DB
    /// </summary>
    public static class CiudadesRepository
    {
        public static readonly string ConnectionString = Configuracion.ObtenerConnectionString();

        /// <summary>
        /// Obtiene todas las Ciudades
        /// </summary>
        /// <returns>Lista de Ciudades</returns>
        public static List<CiudadModel> ObtenerCiudades()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                //var output = connection.Query<CiudadModel>("SELECT * FROM [dbo].[Ciudades];", commandType: CommandType.Text).ToList();
                var output = connection.Query<CiudadModel>("[dbo].[spCiudades_ObtenerTodo]", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        /// <summary>
        /// Inserta una Ciudad
        /// </summary>
        /// <param name="ciudad">Información de la Ciudad</param>
        public static void InsertarCiudad(CiudadModel ciudad)
        {
            //TODO: Implementar alta de ciudad
            throw new NotImplementedException();
        }
    }
}
