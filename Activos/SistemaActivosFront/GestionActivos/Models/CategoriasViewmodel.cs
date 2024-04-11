using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemasActivos.API.Model
{
   public class CategoriasViewmodel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public int Cate_Id { get; set; }
        [Display(Name ="Categoria")]
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public string Cate_Descripcion { get; set; }
        public int? Cate_UsuarioCreacion { get; set; }
        public DateTime? Cate_FechaCreacion { get; set; }
        public int? Cate_UsuarioModificacion { get; set; }
        public DateTime? Cate_FechaModificacion { get; set; }

        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }

    }
}
