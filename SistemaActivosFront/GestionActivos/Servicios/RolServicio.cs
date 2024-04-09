using GestionActivos.Models;
using GestionActivos.WebAPI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class RolServicio
    {
        private readonly API _api;

        public RolServicio(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> Listado()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<RolesViewModel>, IEnumerable<RolesViewModel>>(req =>
                {
                    req.Path = $"/API/Role/Listado";
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
                throw new Exception("Error al obtener la lista de empleados", ex);

                //return result.Error(Helpers.GetMessage(ex));
                //throw;
            }
        }

        public async Task<ServiceResult> CrearRoles(RolesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<RolesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Role/Create";
                    req.Content = item;
                });
                if (!response.Success)
                {
                    
                    return result.FromApi(response);
                }
                else
                {
                    var prueba = response.Message.ToString();
                    return result.Ok(prueba);
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
