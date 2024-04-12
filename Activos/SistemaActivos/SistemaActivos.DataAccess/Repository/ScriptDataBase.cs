using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.DataAccess.Repository
{
    class ScriptDataBase
    {
        #region activos
        public static string InsertarActivo = "[Acti].[SP_Activos_Insertar]";
        public static string ActualizarActivo = "[Acti].[SP_Activos_Actulizar]";
        public static string EliminarActivo = "[Acti].[SP_Activos_Eliminar]";
        public static string BuscarActivo = "[dbo].[SP_Activos_Buscar]";
        public static string DetalleActivo = "[Acti].[SP_Activos_Insertar]";
        public static string ListadoActivo = "[dbo].[SP_Activos_Listado]";


        #endregion


        #region departamentos
        public static string deptoinsertar = "[Gnrl].[SP_Departamentos_Insertar]";

        public static string deptoactualizar = "[Gnrl].[SP_Departamentos_Actulizar]";

        public static string deptoeliminar = "[Gnrl].[SP_Departamentos_Eliminar]";

        public string deptobuscar = "[Gnrl].[SP_Departamentos_Buscar]";

        public static string deptodetalle = "[Gnrl].[SP_Departamentos_Detalle]";
        #endregion

        #region Cargos
        public static string CargosInsertar = "[Gnrl].[SP_Cargos_Insertar]";
        public static string CargosListado = "[Gnrl].[SP_Cargos_Listado]";
        public static string CargosBuscar = "[Gnrl].[SP_Cargos_Buscar]";
        public static string CargosActualizar = "[Gnrl].[SP_Cargo_Actualizar]";
        public static string CargosEliminar = "[Gnrl].[SP_Cargo_Eliminar]";
        public static string CargoDetalle = "[Gnrl].[SP_Cargos_Detalle]";
        public static string DepartamentosDropDownList = "[Gnrl].[SP_Departamentos_DropDowlist]";

        #endregion

        #region Estados Civiles
        public static string EstadosCivilesListar = "[Gnrl].[SP_EstadosCiviles_Listado]";
        public static string EstadosCivilesInsertar = "[Gnrl].[SP_EstadosCiviles_Insertar]";
        public static string EstadosCivilesActualizar = "[Gnrl].[SP_EstadosCiviles_Actulizar]";
        public static string EstadosCivilesEliminar = "[Gnrl].[SP_EstadosCiviles_Eliminar]";
        public static string EstadosCivilesBuscar = "[Gnrl].[SP_EstadosCiviles_Buscar]";
        public static string EstadosCivilesDetalles = "[Gnrl].[SP_EstadosCiviles_Detalle]";
        #endregion

        #region Municipios
        public static string MunicipiosInsertar = "[Gnrl].[SP_Municipios_Insertar]";
        public static string MunicipiosListar = "[Gnrl].[SP_Municipios_Listado]";
        public static string MunicipiosActualizar = "[Gnrl].[SP_Municipios_Actulizar]";
        public static string MunicipiosBuscar = "[Gnrl].[SP_Municipios_Buscar]";
        public static string MunicipiosEliminar = "[Gnrl].[SP_Municipios_Eliminar]";
        #endregion

        #region Sucursales
        public static string SucursalesActualizar = "[Gnrl].[SP_Sucursales_Actulizar]";
        public static string SucursalesInsertar = "[Gnrl].[SP_Sucursales_Insertar]";
        public static string SucursalesEliminar = "[Gnrl].[SP_Sucursales_Eliminar]";
        public static string SucursalesListado = "[Gnrl].[SP_Sucursales_Listado]";
        public static string SucursalesBuscar = "[Gnrl].[SP_Sucursales_Buscar]";
        #endregion

        #region Empleados
        public static string calculoPrincipal = "[Acti].[SP_Activos_Empleados_CalculoPrincipal]";
        public static string EmpleadosListado = "[Gnrl].[SP_Empleados_Listado]";
        public static string EmpleadosIngresar = "[Gnrl].[SP_Empleados_Ingresar]";
        public static string EmpleadosBuscar = "[Gnrl].[SP_Empleados_Buscar]";
        public static string EmpleadosActualizar = "[Gnrl].[SP_Empleados_Actualizar]";
        public static string EmpleadosEliminar = "[Gnrl].[SP_Empleados_Eliminar]";
        #endregion


        #region Pantallas
        public static string PantallasListado = "[Acce].[SP_Pantallas_Listado]";
        public static string PantallasBuscar = "[Acce].[SP_Pantallas_Buscar]";
        #endregion

        #region Roles
        public static string RolesListado = "[Acce].[SP_Roles_Listado]";
        public static string RolesInsertar = "[Acce].[SP_Roles_Insertar]";
        public static string RolesActualizar = "[Acce].[SP_Roles_Actulizar]";
        public static string RolesEliminar = "[Acce].[SP_Roles_Eliminar]";
        public static string RolesBuscar = "[Acce].[SP_Roles_Buscar]";
        #endregion

        #region PantallasPorRoles
        public static string PantallasPorRolesListado = "[Acce].[SP_PantallasPorRoles_Listado]";
        public static string PantallasPorRolesInsertar = "[Acce].[SP_PantallasPorRoles_Insertar]";
        public static string PantallasPorRolesActualizar = "[Acce].[SP_PantallasPorRoles_Actulizar]";
        public static string PantallasPorRolesEliminar = "[Acce].[SP_PantallasPorRoles_Eliminar]";
        public static string PantallasPorRolesBuscar = "[Acce].[SP_PantallasPorRoles_Buscar]";
        public static string PantallasPorRolesMostrar = "[Acce].[SP_PantallasPorRoles_Mostrar]";
        #endregion



    #region categorias
        public static string cateeliminar = "[Acti].[SP_Categorias_Eliminar]";
        public static string cateinsertar = "[Acti].[SP_Categorias_Insertar]";
        public static string cateactualizar = "[Acti].[SP_Categoria_Actulizar]";

        #endregion


        #region usuarios
        public static string usuaeliminar = "[Acce].[SP_Usuarios_Eliminar]";
        public static string usuainsertar = "[Acce].[SP_Usuarios_Insertar]";
        public static string usuactualizar = "[Acce].[SP_Usuarios_Actualizar]";
        public static string usuarescontra = "[Acce].[SP_Usuarios_RecuperarContrasenia]";
        #endregion

        #region vidautil
        public static string vieliminar = "[Acti].[SP_VidaUtil_Eliminar]";
        public static string viuinsertar = "[Acti].[SP_VidaUtil_Insertar]";
        public static string viuactualizar = "[Acti].[SP_VidaUtil_Actulizar]";
        public static string viubuscar = "[dbo].[SP_VidaUtil_Buscar]";


        #endregion
    }
}