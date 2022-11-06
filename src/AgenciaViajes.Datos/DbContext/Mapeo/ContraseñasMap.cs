using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class ContraseñasMap : EntityTypeConfiguration<ContraseñaModel>
    {
        public ContraseñasMap()
        {
            this.ToTable("seguridad.Contraseñas");

            this.Property(e => e.Contraseña)
                .IsUnicode(false);
        }
    }
}
