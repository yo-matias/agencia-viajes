namespace AgenciaViajes.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class ContraseñaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdUsuario { get; set; }

        [Required]
        [StringLength(256)]
        public string Contraseña { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public virtual UsuarioModel Usuarios { get; set; }
    }
}