namespace AgenciaViajes.Library.Models
{
    public class CiudadModel
    {
        public int IdCiudad { get; set; }
        public string Descripcion { get; set; }
        public int IdProvincia { get; set; }
        public virtual ProvinciaModel Provincia { get; set; }

        public CiudadModel(int idCiudad, string descripcion, int idProvincia)
        {
            IdCiudad = idCiudad;
            Descripcion = descripcion;
            IdProvincia = idProvincia;
        }

        public CiudadModel(int idCiudad, string descripcion, ProvinciaModel provincia)
        {
            IdCiudad = idCiudad;
            Descripcion = descripcion;
            IdProvincia = provincia.IdProvincia;
            Provincia = provincia;
        }
    }

}