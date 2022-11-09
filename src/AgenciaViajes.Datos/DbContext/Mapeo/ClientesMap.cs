using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class ClientesMap : EntityTypeConfiguration<ClienteModel>
    {
        public ClientesMap()
        {
            this.ToTable("Clientes");

            this.Property(e => e.Calle)
                .IsUnicode(false);

            this.Property(e => e.NombreCliente)
                .IsUnicode(false);

            this.Property(e => e.ApellidoCliente)
                .IsUnicode(false);

            this.HasMany(e => e.Facturas)
                .WithRequired(e => e.Clientes)
                .WillCascadeOnDelete(false);
        }
    }
}
