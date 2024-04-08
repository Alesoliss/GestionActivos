using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class EstadosCivilesViewModel
    {
        public int EstD_Id { get; set; }
        public string EstD_Descripcion { get; set; }
        public int EstD_UsuarioCreacion { get; set; }
        public DateTime EstD_FechaCracion { get; set; }
        public int? EstD_UsuarioModificacion { get; set; }
        public DateTime? EstD_FechaModificacion { get; set; }
    }
}
