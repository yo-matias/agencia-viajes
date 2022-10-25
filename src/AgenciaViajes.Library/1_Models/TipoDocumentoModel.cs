namespace AgenciaViajes.Library.Models
{
    public class TipoDocumentoModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public TipoDocumentoModel(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}