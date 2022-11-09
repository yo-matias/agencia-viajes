using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Dominio.DTO
{
    public class ClienteCorporativo:ClienteGenerico
    {
        public long CUIT { get; set; }
        public string RazonSocial { get; set; }
    }
}
