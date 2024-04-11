using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
   public class VidaUtilViewmodel
    {

        public int VidU_Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? Cate_Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string VidU_Descripcion { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal? VidU_VidaEstimada { get; set; }
        public int? VidU_UsuarioCreacion { get; set; }
        public DateTime? VidU_FechaCreacion { get; set; }
        public int? VidU_UsuarioModificacion { get; set; }
        public DateTime? VidU_FechaModificacion { get; set; }
        public bool? VidU_Estado { get; set; }
        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }
    }
}
