using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class PaisesMap : EntityTypeConfiguration<PaisModel>
    {
        public PaisesMap()
        {
            this.ToTable("Paises");

            this.Property(e => e.Pais)
                .IsUnicode(false);

            this.HasMany(e => e.Provincias)
                .WithRequired(e => e.Paises)
                .WillCascadeOnDelete(false);
        }
    }
}
