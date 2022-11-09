using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class TiposClienteMap : EntityTypeConfiguration<TipoDeClienteModel>
    {
        public TiposClienteMap()
        {
            this.ToTable("TiposCliente");

            this.Property(e => e.DescripcionTipoCliente)
                .IsUnicode(false);

            this.HasMany(e => e.Clientes)
                .WithRequired(e => e.TipoCliente)
                .WillCascadeOnDelete(false);
        }
    }
}
