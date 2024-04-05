using AHM.Total.Travel.BusinessLogic;
using AHM.Total.Travel.DataAccess.Repositories;
using SistemaActivos.DataAccess.Repository;
using SistemaActivos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeActivos.BusinessLogic
{
    public class GeneralServices
    {
        private readonly DepartamentosRepository _departamentosRepository;

        public GeneralServices(DepartamentosRepository departamentosRepository)
        {
            _departamentosRepository = departamentosRepository;
        }

        #region Departamento

 


        public ServiceResult ListadoDepto1()
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.List();
                return result.Ok(list);
            }
            catch(Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult InsertarDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _departamentosRepository.Insert(item);
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

        public ServiceResult ActualizarDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _departamentosRepository.Update(item);

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

        public IEnumerable<tbDepartamentos> BuscarDepto (string codigo)
        {

            try
            {
                return _departamentosRepository.FindDepto(codigo);

            }
            catch
            {
                return Enumerable.Empty<tbDepartamentos>();
            }
        }

        public ServiceResult BuscarDepto1(string codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.FindDepto(codigo);
                return result.Ok(list);

            }
            catch (Exception ex)
            {
                return result.Error(ex);

            }
        }
        public ServiceResult EliminarDepartamento(string id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _departamentosRepository.EliminarDepartamento(id);
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

    }
}
