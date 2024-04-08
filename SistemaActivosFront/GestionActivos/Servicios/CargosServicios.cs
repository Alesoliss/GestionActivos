using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class CargosServicios
    {
        private readonly API _api;

        public CargosServicios(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> Listado()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CargosViewModel>, IEnumerable<CargosViewModel>>(req =>
                {
                    req.Path = $"/API/Cargos/Listado";
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
                throw new Exception("Error al obtener la lista de Cargos", ex);

                //return result.Error(Helpers.GetMessage(ex));
                //throw;
            }
        }

    }
}
