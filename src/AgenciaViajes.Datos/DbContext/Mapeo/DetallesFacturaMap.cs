using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class DetallesFacturaMap : EntityTypeConfiguration<FacturaDetalleModel>
    {
        public DetallesFacturaMap()
        {
            this.ToTable("DetallesFactura");

            this.Property(e => e.Precio)
                .HasPrecision(8, 2);
        }
    }
}
