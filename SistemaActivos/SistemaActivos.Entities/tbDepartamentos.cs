﻿//// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
//using System;
//using System.Collections.Generic;

//#nullable disable

//namespace SistemaActivos.Entities
//{
//    public partial class tbDepartamentos
//    {
//        public tbDepartamentos()
//        {
//            tbEmpleados = new HashSet<tbEmpleados>();
//            tbMunicipios = new HashSet<tbMunicipios>();
//            tbSucursales = new HashSet<tbSucursales>();
//        }

//        public string Depa_Codigo { get; set; }
//        public string Depa_Descripcion { get; set; }
//        public int? Depa_UsuarioCreacion { get; set; }
//        public DateTime? Depa_FechaCreacion { get; set; }
//        public int? Depa_UsuarioModificacion { get; set; }
//        public DateTime? Depa_FechaModificacion { get; set; }

//        public virtual tbUsuario Depa_UsuarioCreacionNavigation { get; set; }
//        public virtual tbUsuario Depa_UsuarioModificacionNavigation { get; set; }
//        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
//        public virtual ICollection<tbMunicipios> tbMunicipios { get; set; }
//        public virtual ICollection<tbSucursales> tbSucursales { get; set; }
//    }
//}