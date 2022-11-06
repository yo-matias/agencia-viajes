namespace AgenciaViajes.Dominio
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TipoDeDocumentoModel
    {
        [Key]
        public int IdTipoDocumento { get; set; }

        [Required]
        [StringLength(60)]
        public string DescripcionTipoDocumento { get; set; }
    }
}
