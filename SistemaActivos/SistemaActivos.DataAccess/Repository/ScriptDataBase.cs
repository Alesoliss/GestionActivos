using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.DataAccess.Repository
{
    class ScriptDataBase
    {
        #region departamentos
        public static string deptoinsertar = "[Gnrl].[SP_Departamentos_Insertar]";

        public static string deptoactualizar = "[Gnrl].[SP_Departamentos_Actulizar]";

        public static string deptoeliminar = "[Gnrl].[SP_Departamentos_Eliminar]";

        public string deptobuscar = "[Gnrl].[SP_Departamentos_Buscar]";

        public static string deptodetalle = "[Gnrl].[SP_Departamentos_Detalle]";
        #endregion


        #region Empleados
        public static string calculoPrincipal = "[Acti].[SP_Activos_Empleados_CalculoPrincipal]";

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
        #endregion
    }
}