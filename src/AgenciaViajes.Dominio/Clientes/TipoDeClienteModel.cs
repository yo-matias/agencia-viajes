namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class TipoDeClienteModel
    {
        public TipoDeClienteModel()
        {
            Clientes = new HashSet<ClienteModel>();
        }

        [Key]
        public int IdTipoCliente { get; set; }

        [Required]
        [StringLength(60)]
        public string DescripcionTipoCliente { get; set; }
        
        public virtual ICollection<ClienteModel> Clientes { get; set; }
    }
}
