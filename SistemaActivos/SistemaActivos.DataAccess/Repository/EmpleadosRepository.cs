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

        public IEnumerable<tbEmpleados> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbEmpleados item)
        {
            throw new NotImplementedException();
        }
    }
}