using AgenciaViajes.Dominio;
using AgenciaViajes.Negocio;
using AgenciaViajes.Negocio.Localidades;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! Este programa es para pruebas y debug.");
            Console.WriteLine();
            
            // Muestro Países
            List<PaisModel> paises = LocalidadLogica.ObtenerPaises();
            if (paises.Any())
            {
                Console.WriteLine("Actualmente están cargados los siguientes países:");
                foreach (var item in paises)
                {
                    Console.WriteLine($"-> {item.Pais}");
                }
                Console.WriteLine($"Son {paises.Count} países cargados en la base de datos.");
            }
            // -
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Presione para salir");
            Console.ReadLine();
            
        }
    }
}
