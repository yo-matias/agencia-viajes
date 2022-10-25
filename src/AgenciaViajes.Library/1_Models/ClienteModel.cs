using System.Collections.Generic;

namespace AgenciaViajes.Library.Models
{

    public class ClienteModel
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumentoModel DocumentoTipo { get; set; }
        public string DocumentoNro { get; set; }
        public string Telefono { get; set; }
        public List<DireccionModel> Direcciones { get; set; }
        public List<CorreoElectronicoModel> CorreosElectronicos { get; set; }

        public ClienteModel(int id, string razonSocial, string nombre, string apellido, TipoDocumentoModel documentoTipo, string documentoNro, string telefono, List<DireccionModel> direcciones, List<CorreoElectronicoModel> correosElectronicos)
        {
            Id = id;
            RazonSocial = razonSocial;
            Nombre = nombre;
            Apellido = apellido;
            DocumentoTipo = documentoTipo;
            DocumentoNro = documentoNro;
            Telefono = telefono;
            Direcciones = direcciones;
            CorreosElectronicos = correosElectronicos;
        }
    }
}