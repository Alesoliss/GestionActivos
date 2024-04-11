using GestionActivos.Models;
using GestionActivos.WebAPI;
using SistemasActivos.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class VidaUtilService
    {



        private readonly API _api;

        public VidaUtilService(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerVidaList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VidaUtilViewmodel>, IEnumerable<VidaUtilViewmodel>>(req =>
                {
                    req.Path = $"/API/VidaUtil/Listado";
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

        public async Task<ServiceResult> CrearVida(VidaUtilViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<VidaUtilViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/VidaUtil/Create";
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

        public async Task<ServiceResult> LlenarVida(int VidU_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CategoriasViewmodel>, IEnumerable<CategoriasViewmodel>>(req =>
                {
                    req.Path = $"/VidaUtil​/LlenarVidaUtil​/{VidU_Id}";
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

        public async Task<ServiceResult> ActualizarVida(VidaUtilViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<VidaUtilViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/VidaUtil/Actualizar";
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

        public async Task<ServiceResult> EliminarVida(VidaUtilViewmodel item, int VidU_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<VidaUtilViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/VidaUtil/Eliminar/{VidU_Id}";
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
            public async Task<ServiceResult> DetallesVida(int VidU_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<VidaUtilViewmodel>, IEnumerable<VidaUtilViewmodel>>(req =>
                {
                    req.Path = $"​/API​/VidaUtil​/Detalles?VidU_Id={VidU_Id}";
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

