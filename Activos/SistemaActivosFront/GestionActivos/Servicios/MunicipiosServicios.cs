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

        public async Task<ServiceResult> CrearCategoria(MunicipiosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<MunicipiosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Municipios/Create";
                    req.Content = item;
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

        public async Task<ServiceResult> ActualizarMunicipio(MunicipiosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<MunicipiosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Municipios/Actualizar";
                    req.Content = item;
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

        public async Task<ServiceResult> EliminarMunicipio(MunicipiosViewModel item, string Muni_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<MunicipiosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Municipios/Eliminar/{Muni_Codigo}";
                    req.Content = item;
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

        public async Task<ServiceResult> DetallesDepartamento(string Muni_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipiosViewModel>, IEnumerable<MunicipiosViewModel>>(req =>
                {
                    req.Path = $"/API/Municipios/Detalles?Muni_codigo={Muni_Codigo}";
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
