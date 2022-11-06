namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ProvinciaModel
    {
        public ProvinciaModel()
        {
            Ciudades = new HashSet<CiudadModel>();
        }

        [Key]
        public int IdProvincia { get; set; }

        [Required]
        [StringLength(60)]
        public string Provincia { get; set; }

        public int IdPais { get; set; }
        
        public virtual ICollection<CiudadModel> Ciudades { get; set; }

        public virtual PaisModel Paises { get; set; }
    }
}
