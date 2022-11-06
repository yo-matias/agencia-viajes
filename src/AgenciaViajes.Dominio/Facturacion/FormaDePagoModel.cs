namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class FormaDePagoModel
    {
        public FormaDePagoModel()
        {
            Facturas = new HashSet<FacturaModel>();
        }

        [Key]
        public int IdFormaPago { get; set; }

        [Required]
        [StringLength(60)]
        public string DescripcionFormaPago { get; set; }

        public virtual ICollection<FacturaModel> Facturas { get; set; }
    }
}
