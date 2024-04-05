using GestionActivos.Models;
using GestionActivos.WebAPI;
using SistemasActivos.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class DepartamentoServicios
    {

        private readonly API _api;

        public DepartamentoServicios(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerDepartamentoList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentosViewmodel>, IEnumerable<DepartamentosViewmodel>>(req =>
                {
                    req.Path = $"/API/Departamento/Listado";
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

        public async Task<ServiceResult> CrearDepartamento(DepartamentosViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<DepartamentosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"API/Departamento/Create";
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

        public async Task<ServiceResult> LlenarDepartamento(string Depa_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentosViewmodel>, IEnumerable<DepartamentosViewmodel>>(req =>
                {
                    req.Path = $"/API/Departamento/LlenarDepartamentos/{Depa_Codigo}";
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

        public async Task<ServiceResult> ActualizarDepartamento(DepartamentosViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<DepartamentosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Departamento/Actualizar";
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

        public async Task<ServiceResult> EliminarDepartamento(DepartamentosViewmodel item, string Depa_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<DepartamentosViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Departamento/Eliminar/{Depa_Codigo}";
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

        public async Task<ServiceResult> DetallesDepartamento(string Depa_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentosViewmodel>, IEnumerable<DepartamentosViewmodel>>(req =>
                {
                    req.Path = $"API/Departamento/Detalles?Depa_Codigo={Depa_Codigo}";
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