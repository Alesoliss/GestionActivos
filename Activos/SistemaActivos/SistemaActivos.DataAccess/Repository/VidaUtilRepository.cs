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
    public class VidaUtilRepository : IRepository<tbVidaUtil>
    {

        public IEnumerable<tbVidaUtil> FindDetalle(int id)
        {
            string sql = $"[Acti].[SP_VidaUtil_Buscar] '{id}'";

            List<tbVidaUtil> result = new List<tbVidaUtil>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbVidaUtil>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbVidaUtil item)
        {
            string sql = ScriptDataBase.viuinsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@VidU_Descripcion", item.VidU_Descripcion);
                parametro.Add("@VidU_VidaEstimada", item.VidU_VidaEstimada);
                parametro.Add("@VidU_UsuarioCreacion", item.VidU_UsuarioCreacion);
                parametro.Add("@VidU_FechaCreacion", item.VidU_FechaCreacion);

                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };


            }
        }

        public IEnumerable<tbVidaUtil> List()
        {
            const string sql = "[dbo].[SP_VidaUtil_Listado]";
            List<tbVidaUtil> result = new List<tbVidaUtil>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbVidaUtil>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbVidaUtil item)
        {
            string sql = ScriptDataBase.viuactualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@VidU_Id", item.VidU_Id);
                parametro.Add("@VidU_Descripcion", item.VidU_Descripcion);
                parametro.Add("@VidU_VidaEstimada", item.VidU_VidaEstimada);
                parametro.Add("@VidU_UsuarioModificacion", item.VidU_UsuarioModificacion);

                parametro.Add("@VidU_FechaModificacion", item.VidU_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }
        public IEnumerable<tbVidaUtil> FindVidaUtil(int codigo)
        {
            string sql = $"[Acti].[SP_VidaUtil_Buscar] '{codigo}'";
            List<tbVidaUtil> result = new List<tbVidaUtil>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbVidaUtil>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }

        }
        public RequestStatus EliminarVida(int id)
        {
            string sql = ScriptDataBase.vieliminar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("VidU_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

       

      

        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<tbVidaUtil> IRepository<tbVidaUtil>.List()
        {
            throw new NotImplementedException();
        }

        public tbVidaUtil Find(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
