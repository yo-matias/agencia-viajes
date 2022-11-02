namespace AgenciaViajes.Library.Models
{
    public class PaisModel
    {
        public int IdPais { get; set; }
        public string Descripcion { get; set; }

        public PaisModel(int idPais, string descripcion)
        {
            IdPais = idPais;
            Descripcion = descripcion;
        }
    }
}
