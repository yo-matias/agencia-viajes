using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Dominio.DTO
{
    public class ClienteFormulario
    {
        public int IdCliente { get; set; }
        public int IdTipoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string RazonSocial { get; set; }
        public long DNI { get; set; }
        public long CUIT { get; set; }
        public string Calle { get; set; }
        public int? NroCalle { get; set; }
        public long? Telefono { get; set; }
        public int NacionalidadId { get; set; }
        public int IdCiudad { get; set; }
    }
}
