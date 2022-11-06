namespace AgenciaViajes.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PaqueteModel
    {
        public PaqueteModel()
        {
            DetallesFactura = new HashSet<FacturaDetalleModel>();
        }

        [Key]
        public int IdPaquete { get; set; }

        [Required]
        [StringLength(60)]
        public string NombrePaquete { get; set; }

        public decimal Precio { get; set; }

        public int Duracion { get; set; }

        public DateTime FechaSalida { get; set; }

        public bool Vigente { get; set; }

        public int IdTipoPaquete { get; set; }
        
        public virtual ICollection<FacturaDetalleModel> DetallesFactura { get; set; }

        public virtual TipoDePaqueteModel TiposPaquete { get; set; }
    }
}
