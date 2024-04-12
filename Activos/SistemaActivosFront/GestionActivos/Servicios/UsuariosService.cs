using GestionActivos.Models;
using GestionActivos.WebAPI;
using SistemaActivos.Common.Model;
using SistemasActivos.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class UsuariosService
    {

        private readonly API _api;

        public UsuariosService(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerUsuariosList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UsuariosViewmodel>, IEnumerable<UsuariosViewmodel>>(req =>
                {
                    req.Path = $"/API/Usuario/Listado";
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

        public async Task<ServiceResult> CrearUsuario(UsuariosViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<UsuariosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Usuario/CreateUsuario";
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

        public async Task<ServiceResult> LlenarUsuario(int Usua_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UsuariosViewmodel>, IEnumerable<UsuariosViewmodel>>(req =>
                {
                    req.Path = $"/API/Usuario/LlenarUsuario/{Usua_Id}";
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

        public async Task<ServiceResult> ActualizarUsuario(UsuariosViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<UsuariosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Usuario/ActualizarUsuario";
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

        public async Task<ServiceResult> Reestablecer(UsuariosViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<UsuariosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Usuario/ReestablecerContra";
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

        public async Task<ServiceResult> EliminarUsuario(UsuariosViewmodel item, int Usua_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<UsuariosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Usuario/EliminarUsuario/{Usua_Id}";
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

        public async Task<ServiceResult> DetallesUsuario(int Usua_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UsuariosViewmodel>, IEnumerable<UsuariosViewmodel>>(req =>
                {
                    req.Path = $"/API/Usuario/DetallesUsuario?Usua_Id={Usua_Id}";
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
