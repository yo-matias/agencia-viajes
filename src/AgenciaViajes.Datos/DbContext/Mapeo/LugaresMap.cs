using AgenciaViajes.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace AgenciaViajes.Datos
{
    public class LugaresMap : EntityTypeConfiguration<LugarModel>
    {
        public LugaresMap()
        {
            this.ToTable("Lugares");

            this.Property(e => e.NombreLugar)
                .IsUnicode(false);
        }
    }
}
