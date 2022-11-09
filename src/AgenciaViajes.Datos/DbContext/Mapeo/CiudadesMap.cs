using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class CiudadesMap : EntityTypeConfiguration<CiudadModel>
    {
        public CiudadesMap()
        {
            this.ToTable("Ciudades");

            this.Property(e => e.Ciudad)
                .IsUnicode(false);

            this.HasMany(e => e.Clientes)
                .WithRequired(e => e.Ciudad)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Lugares)
                .WithRequired(e => e.Ciudades)
                .WillCascadeOnDelete(false);
        }
    }
}
