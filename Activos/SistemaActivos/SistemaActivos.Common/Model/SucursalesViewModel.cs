﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class SucursalesViewModel
    {
        public int Sucu_Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Sucu_Descripcion { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Depa_Codigo { get; set; }
        [NotMapped]
        public string Depa_Descripcion { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Muni_Codigo { get; set; }
        [NotMapped]
        public string Muni_Descripcion { get; set; }
        public string Sucu_DireccionExacta { get; set; }
        public int Sucu_UsuarioCreacion { get; set; }
        public DateTime Sucu_FechaCreacion { get; set; }
        public int? Sucu_UsuarioModificacion { get; set; }
        public DateTime? Sucu_FechaModificacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }
    }
}
