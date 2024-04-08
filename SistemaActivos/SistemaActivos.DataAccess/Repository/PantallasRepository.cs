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
    public class PantallasRepository : IRepository<tbPantallas>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbPantallas Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPantallas item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<tbPantallas>> List(int RolID)
        {
            string sql = ScriptDataBase.PantallasListado;

            //List<tbPantallas> result = new List<tbPantallas>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Id", RolID);
                await db.OpenAsync();                
                var result = await db.QueryAsync<tbPantallas>(sql, parameter, commandType: CommandType.StoredProcedure);
                return result; 
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbPantallas> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbPantallas item)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<tbPantallasPorRoles> ListPantRoles(int Rol_Id)
        {
            string sql = ScriptDataBase.PantallasPorRolesMostrar;

            List<tbPantallasPorRoles> result = new List<tbPantallasPorRoles>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parameters = new { Role_Id = Rol_Id };
                result = db.Query<tbPantallasPorRoles>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
    }
}
