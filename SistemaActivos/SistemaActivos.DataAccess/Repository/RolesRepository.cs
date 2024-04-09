using AHM.Total.Travel.DataAccess.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;
using SistemaActivos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.DataAccess.Repository
{
    public class RolesRepository : IRepository<tbRoles>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus EliminarRol(int id)
        {
            string sql = ScriptDataBase.RolesEliminar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Role_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public tbRoles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public (RequestStatus, int) Insert(tbRoles item)
        {
            string sql = ScriptDataBase.RolesInsertar;
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Descripcion", item.Role_Descripcion);
                parameter.Add("@Role_UsuarionCreacion", item.Role_UsuarionCreacion);
                parameter.Add("@Role_FechaCreacion", item.Role_FechaCreacion);
                parameter.Add("@role_id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                int roleId = parameter.Get<int>("@role_id");

                string mensaje = (result == 1) ? "exito" : "error";
                return (new RequestStatus { CodeStatus = result, MessageStatus = "" }, roleId);
            }

            throw new NotImplementedException();
        }

        public IEnumerable<tbRoles> List()
        {
            string sql = ScriptDataBase.RolesListado;

            List<tbRoles> result = new List<tbRoles>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbRoles>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbRoles item)
        {
            string sql = ScriptDataBase.RolesActualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Role_Id", item.Role_Id);
                parametro.Add("@Role_Descripcion", item.Role_Descripcion);
                parametro.Add("@Role_UsuarionModificacion", item.Role_UsuarioModificacion);
                parametro.Add("@Role_FechaModificacion", item.Role_FechaModificacion);

                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbRoles> LlenarRoles(int RolID)
        {
            string sql = ScriptDataBase.RolesBuscar;

            List<tbRoles> result = new List<tbRoles>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parameters = new { Role_Id = RolID };
                result = db.Query<tbRoles>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        RequestStatus IRepository<tbRoles>.Insert(tbRoles item)
        {
            throw new NotImplementedException();
        }
    }
}
