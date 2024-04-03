using AHM.Total.Travel.BusinessLogic;
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

        public IEnumerable<tbDepartamentos> ListadoDepto(out string error)
        {
            try
            {
                error = string.Empty;
                return _departamentosRepository.List();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return Enumerable.Empty<tbDepartamentos>();
            }
        }

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
            #endregion

    }
}
