namespace AgenciaViajes.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class FacturaModel
    {
        public FacturaModel()
        {
            DetallesFactura = new HashSet<FacturaDetalleModel>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NroFactura { get; set; }

        public int IdCliente { get; set; }

        public decimal Total { get; set; }

        public DateTime FechaEmision { get; set; }

        public int IdFormaPago { get; set; }

        public virtual ClienteModel Clientes { get; set; }
        
        public virtual ICollection<FacturaDetalleModel> DetallesFactura { get; set; }

        public virtual FormaDePagoModel FormasDePago { get; set; }
    }
}
