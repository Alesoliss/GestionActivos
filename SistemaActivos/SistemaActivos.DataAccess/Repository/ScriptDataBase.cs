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
        #endregion

    }
}
