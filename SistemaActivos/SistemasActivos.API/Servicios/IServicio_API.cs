using SistemaActivos.Entities.Entities;
using SistemaActivos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaActivos.Common
{
    public interface IServicio_API
    {
        Task<List<tbDepartamentos>> Lista();
        Task<tbDepartamentos> Obtener(string idDepto);
        Task<bool> Guardar(tbDepartamentos objeto);
        Task<bool> Editar(tbDepartamentos objeto);
        Task<bool> Eliminar(string idDepto);
    }
}
