using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Models
{
    public class RolesViewModel
    {
        public int Role_Id { get; set; }
        public string Role_Descripcion { get; set; }
        [NotMapped]
        public int Pant_Id { get; set; }
        [NotMapped]
        public string? Pant_Descripcion { get; set; } 
        [NotMapped]
        public int scoop { get; set; }
    }
}
