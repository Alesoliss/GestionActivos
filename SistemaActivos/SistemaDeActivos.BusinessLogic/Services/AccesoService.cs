using AHM.Total.Travel.BusinessLogic;
using SistemaActivos.DataAccess.Repository;
using SistemaActivos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeActivos.BusinessLogic.Services
{
    public class AccesoService
    {
        private readonly RolesRepository _rolesRepository;
        private readonly PantallasRepository _pantallasRepository;

        public AccesoService(RolesRepository rolesRepository, PantallasRepository pantallasRepository)
        {
            _rolesRepository = rolesRepository;
            _pantallasRepository = pantallasRepository;
        }


        #region Roles
        public ServiceResult ListRoles()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public (ServiceResult, int) InsertarRol(tbRoles item)
        {
            var result = new ServiceResult();
            int rolid = 0;
            try
            {
                var lost = _rolesRepository.Insert(item);
                rolid = lost.Item2;
                if (lost.Item1.CodeStatus > 0)
                {
                    return (result.Ok(lost), rolid);
                }
                else
                {
                    return (result.Error(lost), rolid);
                }
            }
            catch (Exception ex)
            {
                return (result.Error(ex.Message), rolid);
            }
        }

        public ServiceResult EliminarRol(int id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.EliminarRol(id);
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

        public ServiceResult ActualizarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.Update(item);

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

        #region Pantallas
        public ServiceResult ListPant(int id)
        {
            try
            {
                var lost =  _pantallasRepository.List(id);
                return new ServiceResult().Ok(lost);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }


        #endregion

        #region PantallasPorRoles
        public IEnumerable<tbPantallasPorRoles> ListPantRole1(int Rol_Id)
        {
            return _pantallasRepository.ListPantRoles(Rol_Id);
        }

        public ServiceResult ListPantRole(int Rol_Id)
        {
            try
            {
                var lost = _pantallasRepository.ListPantRoles(Rol_Id);
                return new ServiceResult().Ok(lost);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }


        public string InsertarPor(int id, int RolID, int UserId, DateTime date)
        {
            string error = "";
            try
            {
                int resull = _pantallaRepository.InsertarPOR(id, RolID, UserId, date);
                if (resull != 1)
                    error = "Error";
                return error;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return error;
            }
        }

        #endregion

    }
}
