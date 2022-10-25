namespace AgenciaViajes.Library.Models
{
    public class CorreoElectronicoModel
    {
        public int Id { get; set; }
        public TipoUsoEnum Tipo { get; set; }
        public string Correo { get; set; }

        public CorreoElectronicoModel(int id, TipoUsoEnum tipo, string correo)
        {
            Id = id;
            Tipo = tipo;
            Correo = correo;
        }
    }
}