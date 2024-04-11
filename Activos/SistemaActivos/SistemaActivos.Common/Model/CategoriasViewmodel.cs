using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
   public class CategoriasViewmodel
    {
        public int Cate_Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Cate_Descripcion { get; set; }
        public int? Cate_UsuarioCreacion { get; set; }
        public DateTime? Cate_FechaCreacion { get; set; }
        public int? Cate_UsuarioModificacion { get; set; }
        public DateTime? Cate_FechaModificacion { get; set; }
        public bool? Cate_Estado { get; set; }
        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }

    }
}
