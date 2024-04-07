﻿using AHM.Total.Travel.BusinessLogic;
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
        public ServiceResult InsertarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.Insert(item);
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
        public IEnumerable<tbPantallas> ListPant(int id)
        {
            return _pantallasRepository.List(id);
        }


        #endregion

        #region PantallasPorRoles
        public IEnumerable<tbPantallasPorRoles> ListPantRole(int Rol_Id)
        {
            return _pantallasRepository.ListPantRoles(Rol_Id);
        }


        #endregion
    }
}