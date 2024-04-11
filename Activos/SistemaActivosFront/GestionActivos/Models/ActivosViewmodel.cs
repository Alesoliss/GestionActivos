﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaActivos.Common.Model
{
   public class ActivosViewmodel
    {
        [Display(Name = "ID")]

        public int Acti_Id { get; set; }
        public string Acti_Url { get; set; }
        public string Acti_Descripcion { get; set; }
        public decimal? Acti_Precio { get; set; }
        public string Acti_Marca { get; set; }
        public string Acti_Modelo { get; set; }
        public string Acti_NoSerio { get; set; }
        public int? Empl_Id { get; set; }
        public int? VidU_Id { get; set; }
        public DateTime? Acti_FechaAdquisicion { get; set; }
        public int? Acti_UsuarioCreacion { get; set; }
        public DateTime? Acti_FechaCreacion { get; set; }
        public int? Acti_UsuarioModificacion { get; set; }
        public DateTime? Acti_FechaModificacion { get; set; }
        public bool? Acti_Estado { get; set; }
        [NotMapped]
        public string Cate_Descripcion { get; set; }
        public int Cate_Id { get; set; }
        [NotMapped]
        public string Encargado { get; set; }
        [NotMapped]
        public string VidU_VidaEstimada { get; set; }

        [NotMapped]
        public string Uuno { get; set; }
        [NotMapped]
        public string Udos { get; set; }

        [NotMapped]
        public int CantidadActivos { get; set; }
        [NotMapped]
        public decimal PorcentajeActivos { get; set; }
        [NotMapped]
        public int Anio { get; set; }
        [NotMapped]
        public decimal TotalCostoDepreciable { get; set; }
        [NotMapped]
        public int TotalAdquisiciones { get; set; }
    }
}