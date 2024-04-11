using GestionActivos.Models;
using GestionActivos.WebAPI;
using SistemaActivos.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class ActivosServicios
    {
        private readonly API _api;

        public ActivosServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerActivosList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<ActivosViewmodel>, IEnumerable<ActivosViewmodel>>(req =>
                {
                    req.Path = $"/API/Activo/ListadoActivo";
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

        public async Task<ServiceResult> CrearActivo(ActivosViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<ActivosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Activo/CreateActivo";
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

        public async Task<ServiceResult> LLenarActivos(int Acti_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<ActivosViewmodel>, IEnumerable<ActivosViewmodel>>(req =>
                {
                    req.Path = $"/API/Activo/LlenarActivo/{Acti_Id}";
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

        public async Task<ServiceResult> ActualizarActivos(ActivosViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<ActivosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Activo/ActualizarActivo";
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

        public async Task<ServiceResult> EliminarActivos(ActivosViewmodel item, int Acti_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<ActivosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Activo/EliminarActivo/{Acti_Id}";
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

        public async Task<ServiceResult> DetallesActivos(int Acti_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<ActivosViewmodel>, IEnumerable<ActivosViewmodel>>(req =>
                {
                    req.Path = $"/API/Activo/DetallesActivo?Acti_Id={Acti_Id}";
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
