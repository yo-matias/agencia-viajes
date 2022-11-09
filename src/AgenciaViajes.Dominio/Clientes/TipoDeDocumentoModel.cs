namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TipoDeDocumentoModel
    {
        public TipoDeDocumentoModel()
        {
            Clientes = new HashSet<ClienteModel>();
        }

        [Key]
        public int IdTipoDocumento { get; set; }

        [Required]
        [StringLength(60)]
        public string DescripcionTipoDocumento { get; set; }

        public virtual ICollection<ClienteModel> Clientes { get; set; }
    }
}
