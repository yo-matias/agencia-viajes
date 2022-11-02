using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Library.DTO
{
    public class LocalidadDto
    {
        [DisplayName("Id. de Ciudad")]
        public int IdCiudad { get; set; }

        [DisplayName("Ciudad")]
        public string DescripcionCiudad { get; set; }
        
        [DisplayName("Id. de Provincia")]
        public int IdProvincia { get; set; }
        
        [DisplayName("Provincia")]
        public string DescripcionProvincia { get; set; }
        
        [DisplayName("Id. de País")]
        public int IdPais { get; set; }
        
        [DisplayName("País")]
        public string DescripcionPais { get; set; }

        public LocalidadDto(int idCiudad, int idProvincia, int idPais)
        {
            IdCiudad = idCiudad;
            IdProvincia = idProvincia;
            IdPais = idPais;
        }

        public LocalidadDto(string descripcionCiudad, string descripcionProvincia, string descripcionPais)
        {
            DescripcionCiudad = descripcionCiudad;
            DescripcionProvincia = descripcionProvincia;
            DescripcionPais = descripcionPais;
        }

        public LocalidadDto(int idCiudad, string descripcionCiudad, int idProvincia, string descripcionProvincia, int idPais, string descripcionPais)
        {
            IdCiudad = idCiudad;
            DescripcionCiudad = descripcionCiudad;
            IdProvincia = idProvincia;
            DescripcionProvincia = descripcionProvincia;
            IdPais = idPais;
            DescripcionPais = descripcionPais;
        }
    }
}
