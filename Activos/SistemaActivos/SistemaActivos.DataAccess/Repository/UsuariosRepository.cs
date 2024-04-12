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
    public class UsuariosRepository : IRepository<tbUsuario>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbUsuario Find(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbUsuario> FindDetalle(int id)
        {
            string sql = $"[Acce].SP_Usuario_Detalles '{id}'";

            List<tbUsuario> result = new List<tbUsuario>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbUsuario>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbUsuario item)
        {
            string sql = ScriptDataBase.usuainsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usua_Nombre", item.Usua_Nombre);
                parametro.Add("@Usua_Contrasenia", item.Usua_Contra);
                parametro.Add("@Empl_Id", item.Empl_Id);
                parametro.Add("@Role_Id", item.Role_Id);
                parametro.Add("@Usua_Admin", item.Usua_Admin);
                parametro.Add("@Usua_UsuarioCreacion", item.Usua_UsuarionCreacion);
                parametro.Add("@Usua_FechaCreacion", item.Usua_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };


            }
        }

        public IEnumerable<tbUsuario> List()
        {
            const string sql = "[dbo].[SP_Usuario_Listado]";
            List<tbUsuario> result = new List<tbUsuario>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbUsuario>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbUsuario item)
        {
            string sql = ScriptDataBase.usuactualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usua_Id", item.Usua_Id);
                parametro.Add("@Usua_Nombre", item.Usua_Nombre);
                parametro.Add("@Empl_Id", item.Empl_Id);
                parametro.Add("@Role_Id", item.Role_Id);
                parametro.Add("@Usua_Admin", item.Usua_Admin);
                parametro.Add("@Usua_UsuariosModificacion", item.Usua_UsuarionModificacion);
                parametro.Add("@Usua_FechaModificacion", item.Usua_FechaModificacion);

                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public RequestStatus ActualizarContra(tbUsuario item)
        {
            string sql = ScriptDataBase.usuarescontra;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usua_Id", item.Usua_Id);
                parametro.Add("", item.Usua_Contra);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbUsuario> FindUsuario(int codigo)
        {
            string sql = $"[Acce].[SP_Usuario_Buscar] '{codigo}'";
            List<tbUsuario> result = new List<tbUsuario>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbUsuario>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }

        }



        public RequestStatus EliminarUsuario(int id)
        {
            string sql = ScriptDataBase.usuaeliminar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Usua_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }


        //ddl
        public async Task<IEnumerable<tbUsuario>> ObtenerRoles()
        {
            using (var connection = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<tbUsuario>("[Acce].Roles_DropDownlist", commandType: CommandType.StoredProcedure);
                return result;
            }
        }


    }
}
