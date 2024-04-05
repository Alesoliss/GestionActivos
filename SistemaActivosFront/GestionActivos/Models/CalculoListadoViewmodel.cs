using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Models
{
    public class CalculoListadoViewmodel
    {
        public IEnumerable<EmpleadosViewmodel> Empleados { get; set; }

    }
}