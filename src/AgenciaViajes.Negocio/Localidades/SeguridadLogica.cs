using AgenciaViajes.Datos;
using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Negocio.Localidades
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

        private static ContraseñaModel ObtenerContraseñaVigente(UsuarioModel usuario)
        {
            var contraseña = usuario.Contraseñas.OrderByDescending(c => c.Id)
                                                .Where(c => c.FechaVencimiento >= DateTime.Today)
                                                .FirstOrDefault();
            return contraseña;
        }
    }
}
