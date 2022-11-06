using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class UsuariosMap : EntityTypeConfiguration<UsuarioModel>
    {
        public UsuariosMap()
        {
            this.ToTable("seguridad.Usuarios");

            this.Property(e => e.Usuario)
                .IsUnicode(false);

            this.Property(e => e.Nombre)
                .IsUnicode(false);

            this.HasMany(e => e.Contraseñas)
                .WithRequired(e => e.Usuarios)
                .HasForeignKey(e => e.IdUsuario)
                .WillCascadeOnDelete(false);
        }
    }
}
