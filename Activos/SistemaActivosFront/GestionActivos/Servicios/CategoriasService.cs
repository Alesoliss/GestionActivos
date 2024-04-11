using GestionActivos.Models;
using GestionActivos.WebAPI;
using SistemasActivos.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class CategoriasService
    {




        private readonly API _api;

        public CategoriasService(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerCategoriaList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CategoriasViewmodel>, IEnumerable<CategoriasViewmodel>>(req =>
                {
                    req.Path = $"/API/Categoria/Listado";
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





        public async Task<ServiceResult> CrearCategoria(CategoriasViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<CategoriasViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Categoria/Create";
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

        public async Task<ServiceResult> LlenarCategoria(int Cate_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentosViewmodel>, IEnumerable<DepartamentosViewmodel>>(req =>
                {
                    req.Path = $"/API/Categoria/LlenarCategoria/{Cate_Id}";
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

        public async Task<ServiceResult> ActualizarCategoria(CategoriasViewmodel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<CategoriasViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Categoria/Actualizar";
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

        public async Task<ServiceResult> Eliminarcategoria(CategoriasViewmodel item, int Cate_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<CategoriasViewmodel, ServiceResult>(req =>
                {
                    req.Path = $"/API/Categoria/Eliminar/{Cate_Id}";
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

        public async Task<ServiceResult> DetallesCategoria(int Cate_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CategoriasViewmodel>, IEnumerable<CategoriasViewmodel>>(req =>
                {
                    req.Path = $"/API/Categoria/Detalles?Cate_Id={Cate_Id}";
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
