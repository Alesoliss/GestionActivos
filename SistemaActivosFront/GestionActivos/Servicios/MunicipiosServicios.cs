using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class MunicipiosServicios
    {
        private readonly API _api;

        public MunicipiosServicios(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> ObtenerMunicipioList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipiosViewModel>, IEnumerable<MunicipiosViewModel>>(req =>
                {
                    req.Path = $"/API/Municipios/Listado";
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
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }
    }
}
