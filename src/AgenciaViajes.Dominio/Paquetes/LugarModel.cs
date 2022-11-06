namespace AgenciaViajes.Dominio
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class LugarModel
    {
        [Key]
        public int IdLugar { get; set; }

        [Required]
        [StringLength(60)]
        public string NombreLugar { get; set; }

        public int IdCiudad { get; set; }

        public virtual CiudadModel Ciudades { get; set; }
    }
}
