namespace AgenciaViajes.Library.Models
{
    public class NacionalidadModel
    {

        public int IdNacionalidad { get; set; }
        public string Descripcion { get; set; }
        public int IdPais { get; set; }

        public NacionalidadModel(int idNacionalidad, string descripcion, int idPais)
        {
            IdNacionalidad = idNacionalidad;
            Descripcion = descripcion;
            IdPais = idPais;
        }
    }
}