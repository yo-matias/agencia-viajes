using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class ProvinciasMap : EntityTypeConfiguration<ProvinciaModel>
    {
        public ProvinciasMap()
        {
            this.ToTable("Provincias");

            this.Property(e => e.Provincia)
                .IsUnicode(false);

            this.HasMany(e => e.Ciudades)
                .WithRequired(e => e.Provincias)
                .WillCascadeOnDelete(false);
        }
    }
}
