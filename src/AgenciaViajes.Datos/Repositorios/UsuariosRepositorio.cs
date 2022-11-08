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
                output = context.Usuarios.Include("Contraseñas").FirstOrDefault(c => c.Usuario == usuario);
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

        public static void ActualizarUsuario(UsuarioModel usuario)
        {
            using (var context = new EntidadesDb())
            {
                var entidad = context.Usuarios.Find(usuario.Id);
                context.Entry(entidad).CurrentValues.SetValues(usuario);
                context.SaveChanges();
            }
        }
    }
}
