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
    /// Repositorio de trabajar con Nacionalidades en la DB
    /// </summary>
    public static class NacionalidadesRepository
    {
        public static readonly string ConnectionString = Configuracion.ObtenerConnectionString();

        /// <summary>
        /// Obtiene todas las Nacionalidades
        /// </summary>
        /// <returns>Lista de Nacionalidades</returns>
        public static List<NacionalidadModel> ObtenerNacionalidades()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                //var output = connection.Query<NacionalidadModel>("SELECT * FROM [dbo].[Nacionalidades];", commandType: CommandType.Text).ToList();
                var output = connection.Query<NacionalidadModel>("[dbo].[spNacionalidades_ObtenerTodo]", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        /// <summary>
        /// Obtiene una Nacionalidad por su Id
        /// </summary>
        /// <param name="id">Identificador a buscar</param>
        /// <returns>Nacionalidad</returns>
        public static NacionalidadModel ObtenerNacionalidadPorId(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@IdNacionalidad", id);
                
                var output = connection.Query<NacionalidadModel>("[dbo].[spNacionalidades_ObtenerPorId]", parametros, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return output;
            }
        }

        /// <summary>
        /// Inserta una Nacionalidad
        /// </summary>
        /// <param name="nacionalidad">Información de Nacionalidad</param>
        public static void InsertarNacionalidad(NacionalidadModel nacionalidad)
        {
            //TODO: implementar creación de nacionalidad
            throw new NotImplementedException();
        }
    }
}
