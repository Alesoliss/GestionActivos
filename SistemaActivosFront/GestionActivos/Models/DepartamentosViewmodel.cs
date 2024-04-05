using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Display(Name = "Usuario Creacion")]

        public int? Depa_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]

        public DateTime? Depa_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modificacion")]

        public int? Depa_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? Depa_FechaModificacion { get; set; }

        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }
    }
}
