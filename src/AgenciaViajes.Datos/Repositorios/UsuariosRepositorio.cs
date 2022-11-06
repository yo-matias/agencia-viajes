using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Datos
{
    public static class UsuariosRepositorio
    {
        public static UsuarioModel ObtenerUsuario(string usuario)
        {
            var output = new UsuarioModel();
            
            using (var context = new EntidadesDb())
            {
                output = context.Usuarios.Where(u => u.Usuario == usuario).FirstOrDefault();
            }

            return output;
        }

        public static void CrearUsuario(UsuarioModel usuario)
        {
            using (var context = new EntidadesDb())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }
    }
}
