using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Dominio.DTO
{
    public class ClienteParticular : ClienteGenerico
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
    }
}
