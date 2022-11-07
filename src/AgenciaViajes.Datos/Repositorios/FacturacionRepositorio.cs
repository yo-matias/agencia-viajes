using AgenciaViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Datos
{
    public static class FacturacionRepositorio
    {
        public static void GenerarFactura()
        {
            throw new NotImplementedException();
        }

        public static FacturaModel ObtenerFacturaPorNro(int nroFactura)
        {
            var output = new FacturaModel();

            using (var context = new EntidadesDb())
            {
                output = context.Facturas.Where(f => f.NroFactura == nroFactura).FirstOrDefault();
            }

            return output;
        }

        public static List<FacturaModel> ObtenerFacturaPorCliente(ClienteModel cliente)
        {
            return ObtenerFacturaPorCliente(cliente.IdCliente);
        }

        public static List<FacturaModel> ObtenerFacturaPorCliente(int idCliente)
        {
            var output = new List<FacturaModel>();

            using (var context = new EntidadesDb())
            {
                output = context.Facturas.Where(f => f.Clientes.IdCliente == idCliente).ToList();
            }

            return output;
        }
    }
}
