namespace AgenciaViajes.Library.Models
{
    public class ProvinciaModel
    {
        public int IdProvincia { get; set; }
        public string Descripcion { get; set; }
        public int IdPais { get; set; }
        public virtual PaisModel Pais { get; set; }

        public ProvinciaModel(int idProvincia, string descripcion, int idPais)
        {
            IdProvincia = idProvincia;
            Descripcion = descripcion;
            IdPais = idPais;
        }

        public ProvinciaModel(int idProvincia, string descripcion, PaisModel pais)
        {
            IdProvincia = idProvincia;
            Descripcion = descripcion;
            IdPais = pais.IdPais;
            Pais = pais;
        }
    }
}