﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaActivos.Entities.Entities
{
    public partial class tbVidaUtil
    {
        public tbVidaUtil()
        {
            tbActivos = new HashSet<tbActivos>();
        }

        public int VidU_Id { get; set; }
        public int? Cate_Id { get; set; }
        public string VidU_Descripcion { get; set; }
        public decimal? VidU_VidaEstimada { get; set; }
        public int? VidU_UsuarioCreacion { get; set; }
        public DateTime? VidU_FechaCreacion { get; set; }
        public int? VidU_UsuarioModificacion { get; set; }
        public DateTime? VidU_FechaModificacion { get; set; }
        public bool? VidU_Estado { get; set; }

        public virtual tbCategorias Cate { get; set; }
        public virtual tbUsuario VidU_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuario VidU_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbActivos> tbActivos { get; set; }
    }
}