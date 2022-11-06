namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CiudadModel
    {
        public CiudadModel()
        {
            Clientes = new HashSet<ClienteModel>();
            Lugares = new HashSet<LugarModel>();
        }

        [Key]
        public int IdCiudad { get; set; }

        [Required]
        [StringLength(60)]
        public string Ciudad { get; set; }

        public int IdProvincia { get; set; }

        public virtual ProvinciaModel Provincias { get; set; }
        
        public virtual ICollection<ClienteModel> Clientes { get; set; }

        public virtual ICollection<LugarModel> Lugares { get; set; }
    }
}
