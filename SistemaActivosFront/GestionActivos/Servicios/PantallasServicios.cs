using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class PantallasServicios
    {
        private readonly API _api;

        public PantallasServicios(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> ObtenerPantallas()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PantallasViewModel>, IEnumerable<PantallasViewModel>>(req =>
                {
                    req.Path = $"/API/Role/Create";
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
                throw new Exception("Error al obtener la lista de pantallas", ex);
            }
        }


    }
}
