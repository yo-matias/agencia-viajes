using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class FormasDePagoMap : EntityTypeConfiguration<FormaDePagoModel>
    {
        public FormasDePagoMap()
        {
            this.ToTable("FormasDePago");

            this.Property(e => e.DescripcionFormaPago)
                .IsUnicode(false);

            this.HasMany(e => e.Facturas)
                .WithRequired(e => e.FormasDePago)
                .WillCascadeOnDelete(false);
        }
    }
}
