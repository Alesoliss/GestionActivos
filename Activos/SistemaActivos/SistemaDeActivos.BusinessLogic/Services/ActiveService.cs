using AHM.Total.Travel.BusinessLogic;
using SistemaActivos.Common.Model;
using SistemaActivos.DataAccess.Repository;
using SistemaActivos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeActivos.BusinessLogic
{
    public class ActiveService
    {
        private readonly EmpleadosRepository _empleadosRepository;
        private readonly ActivosRepository _activosRepository;
        private readonly VidaUtilRepository _vidaUtilRepository;
        private readonly CategoriasRepository _categoriasRepository;
        private readonly UsuariosRepository _usuariosRepository;




        public ActiveService(CategoriasRepository categoriasRepository, VidaUtilRepository vidaUtilRepository,
        EmpleadosRepository empleadosRepository, ActivosRepository activosRepository, UsuariosRepository usuariosRepository)
        {
            _empleadosRepository = empleadosRepository;
            _activosRepository = activosRepository;
            _vidaUtilRepository = vidaUtilRepository;
            _categoriasRepository = categoriasRepository;
            _usuariosRepository = usuariosRepository;

        }


        #region  videUtil
        public ServiceResult ListadoVida()
        {
            var result = new ServiceResult();
            try
            {
                var list = _vidaUtilRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarVida(tbVidaUtil item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _vidaUtilRepository.Insert(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarVida(tbVidaUtil item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _vidaUtilRepository.Update(item);

                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }


        public ServiceResult BuscarDetalleVida(int codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _vidaUtilRepository.FindDetalle(codigo);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex);

            }
        }



        public IEnumerable<tbVidaUtil> BuscarVida(int codigo)
        {

            try
            {
                return _vidaUtilRepository.FindVidaUtil(codigo);

            }
            catch
            {
                return Enumerable.Empty<tbVidaUtil>();
            }
        }


        public ServiceResult EliminarVida(int id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _vidaUtilRepository.EliminarVida(id);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        #endregion




        #region Categoria
        public ServiceResult Listadocategoria()
        {
            var result = new ServiceResult();
            try
            {
                var list = _categoriasRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult Insertarcategoria(tbCategorias item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _categoriasRepository.Insert(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Actualizarcategoria(tbCategorias item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _categoriasRepository.Update(item);

                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }


        public ServiceResult BuscarDetallecategoria(int codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _categoriasRepository.FindDetalle(codigo);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex);

            }
        }



        public IEnumerable<tbCategorias> Buscarcategoria(int codigo)
        {

            try
            {
                return _categoriasRepository.FindCategoria(codigo);

            }
            catch
            {
                return Enumerable.Empty<tbCategorias>();
            }
        }


        public ServiceResult Eliminarcategoria(int id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _categoriasRepository.EliminarCategoria(id);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        #endregion


        #region Empleados



        public ServiceResult Listado()
        {
            var result = new ServiceResult();
            try
            {
                var list = _empleadosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }



        public ServiceResult ListadoActivos(int id, DateTime f1, DateTime f2)
        {
            try
            {
                var result = _empleadosRepository.ListarCalcular(id, f1, f2);
                return new ServiceResult().Ok(result.ToList());
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }

        public async Task<ServiceResult> ObtenerListaEmpleadosDesdeBaseDeDatos()
        {
            try
            {
                var empleados = await _empleadosRepository.ObtenerTodos();
                return new ServiceResult().Ok(empleados);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }

        public ServiceResult ObtenerListaEmpleadosDesdeBaseDeDatos1()
        {
            var result = new ServiceResult();

            try
            {
                var lost = _empleadosRepository.ObtenerTodos1();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion



        #region activos
        public ServiceResult ListadoActivoo()
        {
            var result = new ServiceResult();
            try
            {
                var list = _activosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarActivo(tbActivos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _activosRepository.Insert(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarActivo(tbActivos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _activosRepository.Update(item);

                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }


        public ServiceResult BuscarDetalle(int codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _activosRepository.FindDetalle(codigo);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex);

            }
        }



        public IEnumerable<tbActivos> BuscarActivo(int codigo)
        {

            try
            {
                return _activosRepository.FindActivo(codigo);

            }
            catch
            {
                return Enumerable.Empty<tbActivos>();
            }
        }


        public ServiceResult EliminarActivo(int id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _activosRepository.EliminarActivo(id);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }



        public async Task<ServiceResult> ObtenerCategorias()
        {
            try
            {
                var empleados = await _activosRepository.ObtenerCategoria();
                return new ServiceResult().Ok(empleados);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }



        public async Task<ServiceResult> ObtenerVidaUtil()
        {
            try
            {
                var empleados = await _activosRepository.ObtenerVidaUtil();
                return new ServiceResult().Ok(empleados);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }
        #endregion













        #region usuario
        public ServiceResult ListadoUsuario()
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuariosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertaUsuario(tbUsuario item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _usuariosRepository.Insert(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarUsuario(tbUsuario item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _usuariosRepository.Update(item);

                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult ReestablecerContra(tbUsuario item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _usuariosRepository.ActualizarContra(item);

                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServiceResult BuscarDetalleUsuario(int codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuariosRepository.FindDetalle(codigo);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex);

            }
        }



        public IEnumerable<tbUsuario> BuscarUsuario(int codigo)
        {

            try
            {
                return _usuariosRepository.FindUsuario(codigo);

            }
            catch
            {
                return Enumerable.Empty<tbUsuario>();
            }
        }


        public ServiceResult EliminarUsuario(int id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _usuariosRepository.EliminarUsuario(id);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }


        public async Task<ServiceResult> ObtenerRoles()
        {
            try
            {
                var empleados = await _usuariosRepository.ObtenerRoles();
                return new ServiceResult().Ok(empleados);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }




        #endregion



        #region dashboard

        public ServiceResult ListadoDash()
        {
            var result = new ServiceResult();
            try
            {
                var list = _activosRepository.ListDash();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult ListadoPrecio()
        {
            var result = new ServiceResult();
            try
            {
                var list = _activosRepository.ListPrecio();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult ListadoFecha()
        {
            var result = new ServiceResult();
            try
            {
                var list = _activosRepository.ListFecha();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion


    }
}