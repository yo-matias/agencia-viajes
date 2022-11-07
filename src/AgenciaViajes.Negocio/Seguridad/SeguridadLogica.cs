using AgenciaViajes.Datos;
using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Negocio.Seguridad
{
    public static class SeguridadLogica
    {
        /// <summary>
        /// Valida que el usuario y la contraseña sean correctos
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <param name="contraseña">Contraseña</param>
        /// <returns>Verdadero si la información es correcta</returns>
        public static bool ValidarUsuario(string usuario, string contraseña)
        {
            var usuarioDB = UsuariosRepositorio.ObtenerUsuario(usuario);
            if (usuario != null)
            {
                var contraseñaDB = ObtenerContraseñaVigente(usuarioDB);
                if (contraseñaDB.Contraseña == contraseña)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Actualiza la información de un Usuario
        /// </summary>
        /// <param name="usuario">Información del Usuario</param>
        public static void ActualizarUsuario(UsuarioModel usuario)
        {
            UsuariosRepositorio.ActualizarUsuario(usuario);
        }

        /// <summary>
        /// Crea un Usuario
        /// </summary>
        /// <param name="usuario">Información del Usuario</param>
        public static void CrearUsuario(UsuarioModel usuario)
        {
            UsuariosRepositorio.CrearUsuario(usuario);
        }

        /// <summary>
        /// Obtiene la información de un Usuario
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <returns>Información del Usuario</returns>
        public static UsuarioModel ObtenerUsuario(string usuario)
        {
            var output = UsuariosRepositorio.ObtenerUsuario(usuario);
            return output;
        }
        
        /// <summary>
        /// Obtiene la contraseña vigente de un Usuario
        /// </summary>
        /// <param name="usuario">Información del Usuario</param>
        /// <returns>Información de la Contraseña vigente</returns>
        private static ContraseñaModel ObtenerContraseñaVigente(UsuarioModel usuario)
        {
            var contraseña = usuario.Contraseñas.OrderByDescending(c => c.Id)
                                                .Where(c => c.FechaVencimiento >= DateTime.Today)
                                                .FirstOrDefault();
            return contraseña;
        }
    }
}
