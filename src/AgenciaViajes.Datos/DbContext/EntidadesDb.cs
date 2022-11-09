using AgenciaViajes.Dominio;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AgenciaViajes.Datos
{
    public partial class EntidadesDb : DbContext
    {
        public EntidadesDb()
            : base("name=AgenciaViajesDB")
        {
        }

        public virtual DbSet<CiudadModel> Ciudades { get; set; }
        public virtual DbSet<ClienteModel> Clientes { get; set; }
        public virtual DbSet<FacturaDetalleModel> DetallesFactura { get; set; }
        public virtual DbSet<FacturaModel> Facturas { get; set; }
        public virtual DbSet<FormaDePagoModel> FormasDePago { get; set; }
        public virtual DbSet<LugarModel> Lugares { get; set; }
        public virtual DbSet<PaisModel> Paises { get; set; }
        public virtual DbSet<PaqueteModel> Paquetes { get; set; }
        public virtual DbSet<ProvinciaModel> Provincias { get; set; }
        public virtual DbSet<TipoDeClienteModel> TiposCliente { get; set; }
        public virtual DbSet<TipoDeDocumentoModel> TiposDocumento { get; set; }
        public virtual DbSet<TipoDePaqueteModel> TiposPaquete { get; set; }
        
        public virtual DbSet<ContraseñaModel> Contraseñas { get; set; }
        public virtual DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mapeo de propiedades de cada entidad dentro de clases individuales
            modelBuilder.Configurations.Add(new CiudadesMap());
            modelBuilder.Configurations.Add(new ClientesMap());
            modelBuilder.Configurations.Add(new TiposClienteMap());
            modelBuilder.Configurations.Add(new TiposDocumentoMap());

            modelBuilder.Configurations.Add(new DetallesFacturaMap());
            modelBuilder.Configurations.Add(new FacturasMap());
            modelBuilder.Configurations.Add(new FormasDePagoMap());
            modelBuilder.Configurations.Add(new LugaresMap());
            modelBuilder.Configurations.Add(new PaisesMap());

            modelBuilder.Configurations.Add(new PaquetesMap());
            modelBuilder.Configurations.Add(new ProvinciasMap());
            modelBuilder.Configurations.Add(new TiposPaqueteMap());
            
            modelBuilder.Configurations.Add(new UsuariosMap());
            modelBuilder.Configurations.Add(new ContraseñasMap());
        }


        /// <summary>
        /// Esta rutina es para evitar error de referencia en la capa de presentación
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "<Pending>")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
