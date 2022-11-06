namespace AgenciaViajes.Dominio
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class FacturaDetalleModel
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NroFactura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPaquete { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public virtual FacturaModel Facturas { get; set; }

        public virtual PaqueteModel Paquetes { get; set; }
    }
}
