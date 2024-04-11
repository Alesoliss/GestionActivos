using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Models
{
    public class MunicipiosViewModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Muni_Codigo { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Depa_Codigo { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Muni_Descripcion { get; set; }
        
        public DateTime? Muni_FechaCreacion { get; set; }
        public DateTime? Muni_FechaModificacion { get; set; }

        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }
    }
}
