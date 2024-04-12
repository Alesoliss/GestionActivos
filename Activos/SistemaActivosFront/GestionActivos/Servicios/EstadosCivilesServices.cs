using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class EstadosCivilesServices
    {
        private readonly API _api;

        public EstadosCivilesServices(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> ObtenerEstadosCivilesList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EstadosCivilesViewModel>, IEnumerable<EstadosCivilesViewModel>>(req =>
                {
                    req.Path = $"/API/EstadosCiviles/Listado";
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
        public async Task<ServiceResult> CrearEstadoCivil(EstadosCivilesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<EstadosCivilesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/EstadosCiviles/Create";
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
        public async Task<ServiceResult> ActualizarEstadoCivil(EstadosCivilesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<EstadosCivilesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/EstadosCiviles/Actualizar";
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

        public async Task<ServiceResult> EliminarEstado(EstadosCivilesViewModel item, int EstD_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<EstadosCivilesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/EstadosCiviles/Eliminar/{EstD_Id}";
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

        public async Task<ServiceResult> DetallesEstados(int EstD_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EstadosCivilesViewModel>, IEnumerable<EstadosCivilesViewModel>>(req =>
                {
                    req.Path = $"/API/EstadosCiviles/Detalles?EstD_Id={EstD_Id}";
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
