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
    /// Repositorio de trabajar con Provincias en la DB
    /// </summary>
    public static class ProvinciasRepository
    {
        public static readonly string ConnectionString = Configuracion.ObtenerConnectionString();

        /// <summary>
        /// Obtiene todas las Provincias
        /// </summary>
        /// <returns>Lista de Provincias</returns>
        public static List<ProvinciaModel> ObtenerProvincias()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                //var output = connection.Query<ProvinciaModel>("SELECT * FROM [dbo].[Provincias];", commandType: CommandType.Text).ToList();
                var output = connection.Query<ProvinciaModel>("[dbo].[spProvincias_ObtenerTodo]", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        /// <summary>
        /// Inserta una Provincia
        /// </summary>
        /// <param name="provincia">Información de Provincia</param>
        public static void InsertarProvincia(ProvinciaModel provincia)
        {
            //TODO: Implementar alta de Provincia
            throw new NotImplementedException();
        }
    }
}
