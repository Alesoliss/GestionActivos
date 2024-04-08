using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Models
{
    public class CargosViewModel
    {
        public int Carg_Id { get; set; }
        public string Carg_Descripcion { get; set; }
        public int? Carg_UsuarioCreacion { get; set; }
        public DateTime? Carg_FechaCreacion { get; set; }
        public int? Carg_UsuarioModificacion { get; set; }
        public DateTime? Carg_FechaModificacion { get; set; }
    }
}
