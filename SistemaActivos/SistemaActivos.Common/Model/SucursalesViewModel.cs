using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class SucursalesViewModel
    {
        public int Sucu_Id { get; set; }
        public string Sucu_Descripcion { get; set; }
        public string Depa_Codigo { get; set; }
        public string Muni_Codigo { get; set; }
        public string Sucu_DireccionExacta { get; set; }
        public int Sucu_UsuarioCreacion { get; set; }
        public DateTime Sucu_FechaCreacion { get; set; }
        public int? Sucu_UsuarioModificacion { get; set; }
        public DateTime? Sucu_FechaModificacion { get; set; }
    }
}
