namespace AgenciaViajes.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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
        public string RazónSocial { get; set; }

        [StringLength(60)]
        public string NombreCliente { get; set; }

        [StringLength(60)]
        public string ApellidoCliente { get; set; }

        public int? DocumentoTipoId { get; set; }

        [StringLength(12)]
        public string DocumentoNro { get; set; }

        [StringLength(13)]
        public string CUIT { get; set; }

        public int NacionalidadId { get; set; }

        public bool Habilitado { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }

        public virtual CiudadModel Ciudad { get; set; }

        public virtual PaisModel Nacionalidad { get; set; }

        public virtual TipoDeClienteModel TipoCliente { get; set; }

        public virtual TipoDeDocumentoModel TipoDocumento { get; set; }
        public virtual ICollection<FacturaModel> Facturas { get; set; }
    }
}
