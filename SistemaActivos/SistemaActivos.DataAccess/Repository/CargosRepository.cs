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
    public class CargosRepository : IRepository<tbCargos>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbCargos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCargos item)
        {
            string sql = ScriptDataBase.CargosInsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Descripcion", item.Carg_Descripcion);
                parametro.Add("@Carg_UsuarioCreacion", item.Carg_UsuarioCreacion);
                parametro.Add("@Carg_FechaCreacion", item.Carg_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbCargos> List()
        {
            string sql = ScriptDataBase.CargosListado;

            List<tbCargos> result = new List<tbCargos>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbCargos>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbCargos item)
        {
            string sql = ScriptDataBase.CargosActualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Id", item.Carg_Id);
                parametro.Add("@Carg_Descripcion", item.Carg_Descripcion);
                parametro.Add("@Carg_UsuarioModificacion", item.Carg_UsuarioModificacion);
                parametro.Add("@Carg_FechaModificacion", item.Carg_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
    }
}
