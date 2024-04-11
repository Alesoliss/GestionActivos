using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class RolesViewModel
    {
        public int Role_Id { get; set; }
        public string Role_Descripcion { get; set; }
        [NotMapped]
        public int scoop { get; set; }
    }
}