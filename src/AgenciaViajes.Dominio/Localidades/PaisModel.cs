namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PaisModel
    {
        public PaisModel()
        {
            Provincias = new HashSet<ProvinciaModel>();
        }

        [Key]
        public int IdPais { get; set; }

        [Required]
        [StringLength(60)]
        public string Pais { get; set; }
        
        public virtual ICollection<ProvinciaModel> Provincias { get; set; }
    }
}
