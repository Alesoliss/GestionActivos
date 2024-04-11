using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class SucursalesServices
    {
        private readonly API _api;

        public SucursalesServices(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> ObtenerSucursalesList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<SucursalesViewModel>, IEnumerable<SucursalesViewModel>>(req =>
                {
                    req.Path = $"/API/Sucursales/Listado";
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

        public async Task<ServiceResult> CrearSucursal(SucursalesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<SucursalesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Sucursales/Create";
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

        public async Task<ServiceResult> LlenarSucursal(int Sucu_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<SucursalesViewModel>, IEnumerable<SucursalesViewModel>>(req =>
                {
                    req.Path = $"​/API​/Sucursales​/LlenarCategoria​/{Sucu_Id}";
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

        public async Task<ServiceResult> ActualizarSucursal(SucursalesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<SucursalesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Sucursales/Actualizar";
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

        public async Task<ServiceResult> EliminarSucursal(SucursalesViewModel item, int Sucu_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<SucursalesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Sucursales/Eliminar/{Sucu_Id}";
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
    }
}
