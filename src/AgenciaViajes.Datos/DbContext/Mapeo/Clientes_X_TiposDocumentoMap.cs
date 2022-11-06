using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class Clientes_X_TiposDocumentoMap : EntityTypeConfiguration<ClientePorTipoDocumento>
    {
        public Clientes_X_TiposDocumentoMap()
        {
            this.ToTable("Clientes_X_TiposDocumento");

            this.Property(e => e.RazonSocial)
                .IsUnicode(false);
        }
    }
}
