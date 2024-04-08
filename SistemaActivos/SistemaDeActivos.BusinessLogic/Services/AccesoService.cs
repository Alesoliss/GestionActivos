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
        private readonly UsuarioRepository _usuarioRepository;

        public AccesoService(RolesRepository rolesRepository, PantallasRepository pantallasRepository, UsuarioRepository usuarioRepository)
        {
            _rolesRepository = rolesRepository;
            _pantallasRepository = pantallasRepository;
            _usuarioRepository = usuarioRepository;
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
        public async Task<ServiceResult> ListPant(int id)
        {
            try
            {
                var lost = await _pantallasRepository.List(id);
                return new ServiceResult().Ok(lost);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error(ex.Message);
            }
        }


        #endregion

        #region PantallasPorRoles
        public IEnumerable<tbPantallasPorRoles> ListPantRole(int Rol_Id)
        {
            return _pantallasRepository.ListPantRoles(Rol_Id);
        }


        #endregion

        #region Usuarios

        public ServiceResult ListUsuarios()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _usuarioRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarUsuario(tbUsuario item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _usuarioRepository.Insert(item);
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
                var lost = _usuarioRepository.Update(item);

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


        public IEnumerable<tbUsuario> BuscarUsuario(int codigo)
        {

            try
            {
                return _usuarioRepository.FindUsuario(codigo);

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
                var lost = _usuarioRepository.EliminarUsuario(id);
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
