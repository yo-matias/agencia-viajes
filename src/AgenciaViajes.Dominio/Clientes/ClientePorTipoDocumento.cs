namespace AgenciaViajes.Dominio
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ClientePorTipoDocumento
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoDocumento { get; set; }

        public long NroDocumento { get; set; }

        [Required]
        [StringLength(60)]
        public string RazonSocial { get; set; }
    }
}
