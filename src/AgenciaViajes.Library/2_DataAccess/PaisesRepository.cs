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
    /// Repositorio de trabajar con Países en la DB
    /// </summary>
    public static class PaisesRepository
    {
        public static readonly string ConnectionString = Configuracion.ObtenerConnectionString();

        /// <summary>
        /// Obtiene todos los Países
        /// </summary>
        /// <returns>Lista de Países</returns>
        public static List<PaisModel> ObtenerPaises()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                //var output = connection.Query<PaisModel>("SELECT * FROM [dbo].[Paises];", commandType: CommandType.Text).ToList();
                var output = connection.Query<PaisModel>("[dbo].[spPaises_ObtenerTodo]", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        /// <summary>
        /// Inserta un País
        /// </summary>
        /// <param name="pais">Información de País</param>
        public static void InsertarPais(PaisModel pais)
        {
            //TODO: Ver implementación de InsertarPais
            throw new NotImplementedException();
        }
    }
}
