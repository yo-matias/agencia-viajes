using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class FacturasMap : EntityTypeConfiguration<FacturaModel>
    {
        public FacturasMap()
        {
            this.ToTable("Facturas");

            this.Property(e => e.Total)
                .HasPrecision(8, 2);

            this.HasMany(e => e.DetallesFactura)
                .WithRequired(e => e.Facturas)
                .WillCascadeOnDelete(false);
        }
    }
}
