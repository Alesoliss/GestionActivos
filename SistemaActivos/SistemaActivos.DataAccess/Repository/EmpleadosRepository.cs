using AHM.Total.Travel.DataAccess.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;
using SistemaActivos.Common.Model;
using SistemaActivos.Entities;
using SistemaActivos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.DataAccess.Repository
{
    public class EmpleadosRepository : IRepository<tbEmpleados>
    {
        public IEnumerable<EmpleadosViewmodel> ObtenerPorId(int id)
        {
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                var result = db.Query<EmpleadosViewmodel>("Gnrl.SP_Empleados_DropDownList", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }


        public IEnumerable<EmpleadosViewmodel> ListarCalcular(int id, DateTime f1, DateTime f2)
        {
            string sql = ScriptDataBase.calculoPrincipal;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("ClienteId", id);
                parametro.Add("FechaInicio", f1);
                parametro.Add("FechaFinal", f2);

                var result = db.Query<EmpleadosViewmodel>(sql, parametro, commandType: CommandType.StoredProcedure);
                return result;
            }
        }



        public IEnumerable<tbEmpleados> List()
        {
            const string sql = "[Acti].[SP_Activos_Empleados_CalculoTabla]";
            List<tbEmpleados> result = new List<tbEmpleados>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbEmpleados>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbEmpleados Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEmpleados item)
        {
            throw new NotImplementedException();
        }

  

        public RequestStatus Update(tbEmpleados item)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<tbEmpleados>> ObtenerTodos()
        {
            using (var connection = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<tbEmpleados>("Gnrl.SP_Empleados_DropDownList", commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}