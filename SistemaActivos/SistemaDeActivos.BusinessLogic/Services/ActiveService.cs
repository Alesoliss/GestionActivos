using AHM.Total.Travel.BusinessLogic;
using SistemaActivos.Common.Model;
using SistemaActivos.DataAccess.Repository;
using SistemaActivos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeActivos.BusinessLogic.Services
{
    public class ActiveService
    {
        private readonly EmpleadosRepository _empleadosRepository;

        public ActiveService(EmpleadosRepository empleadosRepository)
        {
            _empleadosRepository = empleadosRepository;
        }

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



        //public ServiceResult ListadoGeneral()
        //{
        //    try
        //    {
        //        var result = _empleadosRepository.ListadoGeneral();
        //        return new ServiceResult().Ok(result.ToList());
        //    }
        //    catch (Exception ex)
        //    {
        //        return new ServiceResult().Error(ex.Message);
        //    }
        //}
        //prueba 14
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



        #endregion
    }
}