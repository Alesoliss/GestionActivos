using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasActivos.API.Model
{
    public class DepartamentosViewmodel
    {
        [Display(Name = "Codigo")]
        public string Depa_Codigo { get; set; }

        [Display(Name = "Departamento")]
        public string Depa_Descripcion { get; set; }
        public int? Depa_UsuarioCreacion { get; set; }
        public DateTime? Depa_FechaCreacion { get; set; }
        public int? Depa_UsuarioModificacion { get; set; }
        public DateTime? Depa_FechaModificacion { get; set; }

      
    }
}
