using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class PaquetesMap : EntityTypeConfiguration<PaqueteModel>
    {
        public PaquetesMap()
        {
            this.ToTable("Paquetes");

            this.Property(e => e.NombrePaquete)
                .IsUnicode(false);

            this.Property(e => e.Precio)
                .HasPrecision(8, 2);

            this.HasMany(e => e.DetallesFactura)
                .WithRequired(e => e.Paquetes)
                .WillCascadeOnDelete(false);
        }
    }
}
