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
        private readonly CargosRepository _cargosRepository;
        private readonly EmpleadosRepository _empleadosRepository;
        private readonly EstadosCivilesRepository _estadosCivilesRepository;
        private readonly MunicipiosRepository _municipiosRepository;
        private readonly SucursalesRepository _sucursalesRepository;

        public GeneralServices(DepartamentosRepository departamentosRepository, CargosRepository cargosRepository, EmpleadosRepository empleadosRepository, EstadosCivilesRepository estadosCivilesRepository, MunicipiosRepository municipiosRepository, SucursalesRepository sucursalesRepository)
        {
            _departamentosRepository = departamentosRepository;
            _cargosRepository = cargosRepository;
            _empleadosRepository = empleadosRepository;
            _empleadosRepository = empleadosRepository;
            _municipiosRepository = municipiosRepository;
            _sucursalesRepository = sucursalesRepository;
            _estadosCivilesRepository = estadosCivilesRepository;
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

        #region Cargos
        public ServiceResult ListadoCargo()
        {
            var result = new ServiceResult();
            try
            {
                var list = _cargosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarCargo(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _cargosRepository.Insert(item);
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

        public ServiceResult ListadoEmpleados()
        {
            var result = new ServiceResult();
            try
            {
                var list = _empleadosRepository.List1();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarEmpleado(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _empleadosRepository.Insert(item);
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

        #region Estados Cviles
        public ServiceResult ListadoEstadosCiviles()
        {
            var result = new ServiceResult();
            try
            {
                var list = _estadosCivilesRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarEstadoCivil (tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _estadosCivilesRepository.Insert(item);
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

        #region Municipios
        public ServiceResult ListadoMunicipios()
        {
            var result = new ServiceResult();
            try
            {
                var list = _municipiosRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarMunicipios(tbMunicipios item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _municipiosRepository.Insert(item);
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

        #region Sucursales
        public ServiceResult ListadoSucursales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _sucursalesRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarSucursales(tbSucursales item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _sucursalesRepository.Insert(item);
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
