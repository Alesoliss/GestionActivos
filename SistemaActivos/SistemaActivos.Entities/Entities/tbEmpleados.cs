﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaActivos.Entities.Entities
{
    public partial class tbEmpleados
    {
        public tbEmpleados()
        {
            tbActivos = new HashSet<tbActivos>();
            tbUsuario = new HashSet<tbUsuario>();
        }

        public int Empl_Id { get; set; }
        public string Empl_DNI { get; set; }
        public string Empl_PNombre { get; set; }
        public string Empl_SNombre { get; set; }
        public string Empl_PApellido { get; set; }
        public string Empl_SApellido { get; set; }
        public string Empl_Sexo { get; set; }
        public int? EstD_Id { get; set; }
        public string Depa_Codigo { get; set; }
        public string Muni_Codigo { get; set; }
        public string Empl_DireccionE { get; set; }
        public int? Empl_UsuarioCreacion { get; set; }
        public DateTime? Empl_FechaCreacion { get; set; }
        public int? Empl_UsuarioModificacion { get; set; }
        public DateTime? Empl_FechaModificacion { get; set; }
        public bool? Empl_Estado { get; set; }
        public int? Sucu_Id { get; set; }

        public virtual tbDepartamentos Depa_CodigoNavigation { get; set; }
        public virtual tbUsuario Empl_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuario Empl_UsuarioModificacionNavigation { get; set; }
        public virtual tbEstadosCiviles EstD { get; set; }
        public virtual tbMunicipios Muni_CodigoNavigation { get; set; }
        public virtual ICollection<tbActivos> tbActivos { get; set; }
        public virtual ICollection<tbUsuario> tbUsuario { get; set; }
    }
}