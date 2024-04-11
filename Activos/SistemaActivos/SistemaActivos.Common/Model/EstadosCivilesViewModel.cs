using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class EstadosCivilesViewModel
    {
        public int EstD_Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string EstD_Descripcion { get; set; }
        public int EstD_UsuarioCreacion { get; set; }
        public DateTime EstD_FechaCracion { get; set; }
        public int? EstD_UsuarioModificacion { get; set; }
        public DateTime? EstD_FechaModificacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }
    }
}
