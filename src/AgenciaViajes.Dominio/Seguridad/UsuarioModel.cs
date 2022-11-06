namespace AgenciaViajes.Dominio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class UsuarioModel
    {
        public UsuarioModel()
        {
            Contraseñas = new HashSet<ContraseñaModel>();
        }

        public UsuarioModel(int id, string usuario, string nombre, ICollection<ContraseñaModel> contraseñas)
        {
            Id = id;
            Usuario = usuario;
            Nombre = nombre;
            Contraseñas = contraseñas;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        
        public virtual ICollection<ContraseñaModel> Contraseñas { get; set; }
    }
}
