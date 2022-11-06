using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class TiposDocumentoMap : EntityTypeConfiguration<TipoDeDocumentoModel>
    {
        public TiposDocumentoMap()
        {
            this.ToTable("TiposDocumento");

            this.Property(e => e.DescripcionTipoDocumento)
                .IsUnicode(false);
        }
    }
}
