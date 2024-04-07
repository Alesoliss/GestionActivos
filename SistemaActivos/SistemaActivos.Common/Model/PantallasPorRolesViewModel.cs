using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class PantallasPorRolesViewModel
    {
        public int PaRo_Id { get; set; }
        public int? Role_Id { get; set; }
        public int? Pant_Id { get; set; }

        [NotMapped]
        public string PantallasDescripcion { get; set; }
    }
}
