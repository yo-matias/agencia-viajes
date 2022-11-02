using AgenciaViajes.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Win.Selectores.Interfaces
{
    public interface ILocalidadesRequestor
    {
        void CiudadSeleccionada(CiudadModel ciudad);
    }
}
