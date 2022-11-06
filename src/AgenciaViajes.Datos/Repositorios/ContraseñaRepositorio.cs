using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Datos
{
    public static class ContraseñaRepositorio
    {
        public static ContraseñaModel ObtenerContraseñaVigentePorUsuario(string usuario)
        {
            var output = new ContraseñaModel();

            using (var context = new EntidadesDb())
            {
                output = context.Contraseñas.Where(c => c.Usuarios.Usuario == usuario && c.FechaVencimiento >= DateTime.Today).FirstOrDefault();
            }

            return output;
        }
        public static ContraseñaModel ObtenerContraseñaVigentePorIdUsuario(int idUsuario)
        {
            var output = new ContraseñaModel();

            using (var context = new EntidadesDb())
            {
                output = context.Contraseñas.Where(c => c.Usuarios.Id == idUsuario && c.FechaVencimiento >= DateTime.Today).FirstOrDefault();
            }

            return output;
        }
    }
}
