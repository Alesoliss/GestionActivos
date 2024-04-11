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
   public class ActivosRepository : IRepository<tbActivos>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

     


        public IEnumerable<tbActivos> FindDetalle(int id)
        {
            string sql = $"[Gnrl].[SP_Activos_Detalle] '{id}'";

            List<tbActivos> result = new List<tbActivos>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbActivos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbActivos item)
        {
            string sql = ScriptDataBase.InsertarActivo;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Acti_Url", item.Acti_Url);
                parametro.Add("@Acti_Descripcion", item.Acti_Descripcion);
                parametro.Add("@Acti_Precio", item.Acti_Precio);
                parametro.Add("@Acti_Marca", item.Acti_Marca);
                parametro.Add("@Acti_Modelo", item.Acti_Modelo);
                parametro.Add("@Acti_NoSerie", item.Acti_NoSerio);
                parametro.Add("@Empl_Id", item.Empl_Id);
                parametro.Add("@VidU_Id", item.VidU_Id);
                parametro.Add("@Acti_FechaAdquisicion", item.Acti_FechaAdquisicion);
                parametro.Add("@Acti_UsuarioCreacion", item.Acti_UsuarioCreacion);
                parametro.Add("@Acti_FechaCreacion", item.Acti_FechaCreacion);
                parametro.Add("@Cate_Id", item.Cate_Id);


                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };


            }
        }


        public IEnumerable<tbActivos> List()
        {
            const string sql = "[dbo].[SP_Activos_Listado]";
            List<tbActivos> result = new List<tbActivos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbActivos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }


        public IEnumerable<tbActivos> ListDash()
        {
            const string sql = "Acti.SP_Activos_Categorias_Porcentaje";
            List<tbActivos> result = new List<tbActivos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbActivos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }


        public IEnumerable<tbActivos> ListPrecio()
        {
            const string sql = "Acti.SP_Activo_PrecioRango_Dashboard";
            List<tbActivos> result = new List<tbActivos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbActivos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public IEnumerable<tbActivos> ListFecha()
        {
            const string sql = "Acti.SP_Activo_FechasAdquicision_Dashboard";
            List<tbActivos> result = new List<tbActivos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbActivos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbActivos item)
        {
            string sql = ScriptDataBase.ActualizarActivo;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Acti_Id", item.Acti_Id);
                parametro.Add("@Acti_Url", item.Acti_Url);
                parametro.Add("@Acti_Descripcion", item.Acti_Descripcion);
                parametro.Add("@Acti_Precio", item.Acti_Precio);
                parametro.Add("@Acti_Marca", item.Acti_Marca);
                parametro.Add("@Acti_Modelo", item.Acti_Modelo);
                parametro.Add("@Acti_NoSerie", item.Acti_NoSerio);
                parametro.Add("@Empl_Id", item.Empl_Id);
                parametro.Add("@VidU_Id", item.VidU_Id);
                parametro.Add("@Acti_FechaAdquisicion", item.Acti_FechaAdquisicion);
                parametro.Add("@Acti_UsuarioModificacion", item.Acti_UsuarioModificacion);
                parametro.Add("@Acti_FechaModificacion", item.Acti_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
        public IEnumerable<tbActivos> FindActivo(int codigo)
        {
            string sql = $"[dbo].[SP_Activos_Buscar] '{codigo}'";
            List<tbActivos> result = new List<tbActivos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbActivos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }
        public RequestStatus EliminarActivo(int id)
        {
            string sql = ScriptDataBase.EliminarActivo;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Acti_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public async Task<IEnumerable<tbVidaUtil>> ObtenerVidaUtil()
        {
            using (var connection = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<tbVidaUtil>("Gnrl.VidaUtil_DropDownlist", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<IEnumerable<tbCategorias>> ObtenerCategoria()
        {
            using (var connection = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<tbCategorias>("Gnrl.Categoria_DropDownlist", commandType: CommandType.StoredProcedure);
                return result;
            }
        }



        IEnumerable<tbActivos> IRepository<tbActivos>.List()
        {
            throw new NotImplementedException();
        }

        public tbActivos Find(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
