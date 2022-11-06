namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class TipoDePaqueteModel
    {
        public TipoDePaqueteModel()
        {
            Paquetes = new HashSet<PaqueteModel>();
        }

        [Key]
        public int IdTipoPaquete { get; set; }

        public decimal CotizacionDolar { get; set; }

        public bool Visa { get; set; }

        public decimal ImpuestoFijo { get; set; }

        public int ImpuestoPorcentaje { get; set; }
        
        public virtual ICollection<PaqueteModel> Paquetes { get; set; }
    }
}
