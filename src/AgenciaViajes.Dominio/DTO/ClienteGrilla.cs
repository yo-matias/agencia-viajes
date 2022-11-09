using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Dominio.DTO
{
    public class ClienteGrillas
    {
        public int IdCliente { get; set; }

        public string TipoCliente { get; set; }

        public string Nacionalidad { get; set; }

        public bool Habilitado { get; set; }
    }
}
