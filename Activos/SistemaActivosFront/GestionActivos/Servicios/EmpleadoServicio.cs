using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class EmpleadoServicio
    {
        private readonly API _api;

        public EmpleadoServicio(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerCalculoList(int empleadoId, DateTime fechaInicio, DateTime fechaFinal)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EmpleadosViewmodel>, IEnumerable<EmpleadosViewmodel>>(req =>
                {
                    req.Path = $"/API/Empleados/listadoActivos?id={empleadoId}&f1={fechaInicio}&f2={fechaFinal}";
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
            }
        }

        public async Task<ServiceResult> ObtenerCalculosList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EmpleadosViewmodel>, IEnumerable<EmpleadosViewmodel>>(req =>
                {
                    req.Path = $"/API​/Empleados​/Listado";
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


      
        // Método para obtener la lista de empleados
        //public async Task<IEnumerable<EmpleadosViewmodel>> ObtenerListaEmpleados()
        //{
        //    try
        //    {
        //        // Aquí definimos la ruta para obtener la lista de empleados
        //        var response = await _api.Get<IEnumerable<EmpleadosViewmodel>, IEnumerable<EmpleadosViewmodel>>(req =>
        //        {
        //            req.Path = $"/API/Empleados/listaEmpleados";
        //        });

        //        // Manejo de la respuesta
        //        if (response.Success)
        //        {
        //            return response.Data;
        //        }
        //        else
        //        {
        //            return new List<EmpleadosViewmodel>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al obtener la lista de empleados", ex);
        //    }
        //}


        public async Task<IEnumerable<EmpleadosViewmodel>> ObtenerListaEmpleados()
        {
            try
            {
                var response = await _api.Get<IEnumerable<EmpleadosViewmodel>, IEnumerable<EmpleadosViewmodel>>(req =>
                {
                    req.Path = $"/API/Empleados/listaEmpleados";
                });

                if (response.Success)
                {
                    return response.Data;
                }
                else
                {
                    return new List<EmpleadosViewmodel>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de empleados", ex);
            }
        }

        public async Task<ServiceResult> ObtenerListaEmpleados1()
        {
            var result = new ServiceResult();

            try
            {
                var response = await _api.Get<IEnumerable<EmpleadosViewmodel>, IEnumerable<EmpleadosViewmodel>>(req =>
                {
                    req.Path = $"/API/Empleados/listaEmpleados1";
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
            }
        }
    }
}