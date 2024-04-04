﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaActivos.Entities
{
    public partial class tbUsuario
    {
        public tbUsuario()
        {
            InverseUsua_UsuarionCreacionNavigation = new HashSet<tbUsuario>();
            InverseUsua_UsuarionModificacionNavigation = new HashSet<tbUsuario>();
            tbActivosActi_UsuarioCreacionNavigation = new HashSet<tbActivos>();
            tbActivosActi_UsuarioModificacionNavigation = new HashSet<tbActivos>();
            tbCargosCarg_UsuarioCreacionNavigation = new HashSet<tbCargos>();
            tbCargosCarg_UsuarioModificacionNavigation = new HashSet<tbCargos>();
            tbCategoriasCate_UsuarioCreacionNavigation = new HashSet<tbCategorias>();
            tbCategoriasCate_UsuarioModificacionNavigation = new HashSet<tbCategorias>();
            tbDepartamentosDepa_UsuarioCreacionNavigation = new HashSet<tbDepartamentos>();
            tbDepartamentosDepa_UsuarioModificacionNavigation = new HashSet<tbDepartamentos>();
            tbEmpleadosEmpl_UsuarioCreacionNavigation = new HashSet<tbEmpleados>();
            tbEmpleadosEmpl_UsuarioModificacionNavigation = new HashSet<tbEmpleados>();
            tbEstadosCivilesEstD_UsuarioCreacionNavigation = new HashSet<tbEstadosCiviles>();
            tbEstadosCivilesEstD_UsuarioModificacionNavigation = new HashSet<tbEstadosCiviles>();
            tbMunicipiosMuni_UsuarioCreacionNavigation = new HashSet<tbMunicipios>();
            tbMunicipiosMuni_UsuarioModificacionNavigation = new HashSet<tbMunicipios>();
            tbPantallasPorRolesPaRo_UsuarioCreacionNavigation = new HashSet<tbPantallasPorRoles>();
            tbPantallasPorRolesPaRo_UsuarioModificacionNavigation = new HashSet<tbPantallasPorRoles>();
            tbRolesRole_UsuarioModificacionNavigation = new HashSet<tbRoles>();
            tbRolesRole_UsuarionCreacionNavigation = new HashSet<tbRoles>();
            tbSucursalesSucu_UsuarioCreacionNavigation = new HashSet<tbSucursales>();
            tbSucursalesSucu_UsuarioModificacionNavigation = new HashSet<tbSucursales>();
            tbVidaUtilVidU_UsuarioCreacionNavigation = new HashSet<tbVidaUtil>();
            tbVidaUtilVidU_UsuarioModificacionNavigation = new HashSet<tbVidaUtil>();
        }

        public int Usua_Id { get; set; }
        public string Usua_Nombre { get; set; }
        public string Usua_Contra { get; set; }
        public bool? Usua_Admin { get; set; }
        public bool? Usua_Activo { get; set; }
        public DateTime? Usua_FechaCreacion { get; set; }
        public DateTime? Usua_FechaModificacion { get; set; }
        public int? Usua_UsuarionCreacion { get; set; }
        public int? Usua_UsuarionModificacion { get; set; }
        public int? Empl_Id { get; set; }
        public int? Role_Id { get; set; }

        public virtual tbEmpleados Empl { get; set; }
        public virtual tbRoles Role { get; set; }
        public virtual tbUsuario Usua_UsuarionCreacionNavigation { get; set; }
        public virtual tbUsuario Usua_UsuarionModificacionNavigation { get; set; }
        public virtual ICollection<tbUsuario> InverseUsua_UsuarionCreacionNavigation { get; set; }
        public virtual ICollection<tbUsuario> InverseUsua_UsuarionModificacionNavigation { get; set; }
        public virtual ICollection<tbActivos> tbActivosActi_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbActivos> tbActivosActi_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosCarg_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosCarg_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCategorias> tbCategoriasCate_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCategorias> tbCategoriasCate_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosDepa_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosDepa_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosEmpl_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosEmpl_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesEstD_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesEstD_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosMuni_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosMuni_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRolesPaRo_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRolesPaRo_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesRole_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesRole_UsuarionCreacionNavigation { get; set; }
        public virtual ICollection<tbSucursales> tbSucursalesSucu_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbSucursales> tbSucursalesSucu_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbVidaUtil> tbVidaUtilVidU_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbVidaUtil> tbVidaUtilVidU_UsuarioModificacionNavigation { get; set; }
    }
}