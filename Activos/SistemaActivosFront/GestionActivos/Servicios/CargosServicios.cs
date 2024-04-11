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
            }
        }

        public async Task<ServiceResult> CrearCargos(CargosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<CargosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Cargos/Create";
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

        public async Task<ServiceResult> ActualizarCargo(CargosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<CargosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Cargos/Actualizar";
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

        public async Task<ServiceResult> EliminarCargo(CargosViewModel item, int Carg_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<CargosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Cargos/Eliminar/{Carg_Id}";
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

        public async Task<ServiceResult> Detalles(int Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CargosViewModel>, IEnumerable<CargosViewModel>>(req =>
                {
                    req.Path = $"API/Cargos/Detalles?Carg_Id={Id}";
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
