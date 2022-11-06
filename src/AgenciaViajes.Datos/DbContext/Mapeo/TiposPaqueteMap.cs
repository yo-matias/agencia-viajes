using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class TiposPaqueteMap : EntityTypeConfiguration<TipoDePaqueteModel>
    {
        public TiposPaqueteMap()
        {
            this.ToTable("TiposPaquete");

            this.Property(e => e.CotizacionDolar)
                .HasPrecision(8, 2);

            this.Property(e => e.ImpuestoFijo)
                .HasPrecision(8, 2);

            this.HasMany(e => e.Paquetes)
                .WithRequired(e => e.TiposPaquete)
                .WillCascadeOnDelete(false);
        }
    }
}
