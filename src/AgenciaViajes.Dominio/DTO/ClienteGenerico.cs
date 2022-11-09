using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Dominio.DTO
{
    public class ClienteGenerico
    {
        public int IdCliente { get; set; }

        public int IdTipoCliente { get; set; }
        
        public string Calle { get; set; }

        public int? NroCalle { get; set; }

        public long? Telefono { get; set; }

        public int NacionalidadId { get; set; }

        public int IdCiudad { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }

        public bool Habilitado { get; set; }
    }
}
