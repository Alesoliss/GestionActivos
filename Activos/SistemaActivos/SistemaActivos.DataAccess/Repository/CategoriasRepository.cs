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
    public class CategoriasRepository : IRepository<tbCategorias>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbDepartamentos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCategorias> FindDetalle(int id)
        {
            string sql = $"[dbo].[SP_Categorias_Buscar] '{id}'";

            List<tbCategorias> result = new List<tbCategorias>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbCategorias>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbCategorias item)
        {
            string sql = ScriptDataBase.cateinsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Cate_Descripcion", item.Cate_Descripcion);
                parametro.Add("@Cate_UsuarioCreacion", item.Cate_UsuarioCreacion);
                parametro.Add("@Cate_FechaCreacion", item.Cate_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbCategorias> List()
        {
            const string sql = "[dbo].[SP_Categorias_Listado]";
            List<tbCategorias> result = new List<tbCategorias>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbCategorias>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbCategorias item)
        {
            string sql = ScriptDataBase.cateactualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Cate_Id", item.Cate_Id);
                parametro.Add("@Cate_Descripcion", item.Cate_Descripcion);
                parametro.Add("@Cate_UsuarioModificacion", item.Cate_UsuarioModificacion);
                parametro.Add("@@Cate_FechaModificacion", item.Cate_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }
        public IEnumerable<tbCategorias> FindCategoria(int codigo)
        {
            string sql = $"[dbo].[SP_Categorias_Buscar] '{codigo}'";
            List<tbCategorias> result = new List<tbCategorias>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbCategorias>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }

        }
        public RequestStatus EliminarCategoria(int id)
        {
            string sql = ScriptDataBase.cateeliminar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Cate_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        tbCategorias IRepository<tbCategorias>.Find(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
