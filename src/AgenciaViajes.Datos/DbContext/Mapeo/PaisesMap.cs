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

            this.Property(e => e.Gentilicio)
                .IsUnicode(false);

            this.HasMany(e => e.Clientes)
                .WithRequired(e => e.Nacionalidad)
                .HasForeignKey(e => e.NacionalidadId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Provincias)
                .WithRequired(e => e.Paises)
                .WillCascadeOnDelete(false);
        }
    }
}
