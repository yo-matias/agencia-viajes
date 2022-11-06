namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ClienteModel
    {
        public ClienteModel()
        {
            Facturas = new HashSet<FacturaModel>();
        }

        [Key]
        public int IdCliente { get; set; }

        public int IdCiudad { get; set; }

        [StringLength(60)]
        public string Calle { get; set; }

        public int? NroCalle { get; set; }

        public long? Telefono { get; set; }

        public int IdTipoCliente { get; set; }

        [StringLength(60)]
        public string NombreCliente { get; set; }

        [StringLength(60)]
        public string ApellidoCliente { get; set; }

        [StringLength(60)]
        public string Nacionalidad { get; set; }

        public virtual CiudadModel Ciudades { get; set; }

        public virtual TipoDeClienteModel TiposCliente { get; set; }
        
        public virtual ICollection<FacturaModel> Facturas { get; set; }
    }
}
