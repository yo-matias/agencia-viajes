namespace AgenciaViajes.Library.Models
{
    public class DireccionModel
    {
        public int Id { get; set; }
        public TipoUsoEnum Tipo { get; set; }
        public string Calle { get; set; }
        public string Nro { get; set; }
        public string Piso { get; set; }
        public string Depto { get; set; }
        public CiudadModel Ciudad { get; set; }

        public DireccionModel(int id, TipoUsoEnum tipo, string calle, string nro, string piso, string depto, CiudadModel ciudad)
        {
            Id = id;
            Tipo = tipo;
            Calle = calle;
            Nro = nro;
            Piso = piso;
            Depto = depto;
            Ciudad = ciudad;
        }
    }
}