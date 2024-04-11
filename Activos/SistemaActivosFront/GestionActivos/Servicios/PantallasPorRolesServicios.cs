using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class PantallasPorRolesServicios
    {
        private readonly API _api;

        public PantallasPorRolesServicios(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> ObtenerPantallasPorRoles()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PantallasPorRolesViewModel>, IEnumerable<PantallasPorRolesViewModel>>(req =>
                {
                    req.Path = $"/API/Role/PantallasPorRoles";
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de pantallasPorRoles", ex);

            }
        }

    }
}
