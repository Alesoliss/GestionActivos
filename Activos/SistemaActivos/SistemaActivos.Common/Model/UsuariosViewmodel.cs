using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class UsuariosViewmodel
    {
        public int Usua_Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Usua_Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Usua_Contra { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public bool? Usua_Admin { get; set; }
        public bool? Usua_Activo { get; set; }
        public DateTime? Usua_FechaCreacion { get; set; }
        public DateTime? Usua_FechaModificacion { get; set; }
        public int? Usua_UsuarionCreacion { get; set; }
        public int? Usua_UsuarionModificacion { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? Empl_Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? Role_Id { get; set; }
        [NotMapped]
        public string Empleado { get; set; }
        [NotMapped]
        public string Uuno { get; set; }
        [NotMapped]
        public string Udos { get; set; }

        [NotMapped]
        public string Rol { get; set; }

    }
}
