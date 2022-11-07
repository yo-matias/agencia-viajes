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

        public static void ActualizarUsuario(UsuarioModel usuario)
        {
            UsuariosRepositorio.ActualizarUsuario(usuario);
        }

        public static void CrearUsuario(UsuarioModel usuario)
        {
            UsuariosRepositorio.CrearUsuario(usuario);
        }

        public static UsuarioModel ObtenerUsuario(string usuario)
        {
            var output = UsuariosRepositorio.ObtenerUsuario(usuario);
            return output;
        }
        private static ContraseñaModel ObtenerContraseñaVigente(UsuarioModel usuario)
        {
            var contraseña = usuario.Contraseñas.OrderByDescending(c => c.Id)
                                                .Where(c => c.FechaVencimiento >= DateTime.Today)
                                                .FirstOrDefault();
            return contraseña;
        }
    }
}
