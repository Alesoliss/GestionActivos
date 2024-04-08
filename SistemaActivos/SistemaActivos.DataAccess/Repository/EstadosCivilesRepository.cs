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
    public class EstadosCivilesRepository : IRepository<tbEstadosCiviles>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbEstadosCiviles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEstadosCiviles item)
        {
            string sql = ScriptDataBase.EstadosCivilesInsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@EstD_Descripcion", item.EstD_Descripcion);
                parametro.Add("@EstD_UsuarioCreacion", item.EstD_UsuarioCreacion);
                parametro.Add("@EstD_FechaCreacion", item.EstD_FechaCracion);

                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbEstadosCiviles> List()
        {
            string sql = ScriptDataBase.EstadosCivilesListar;

            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbEstadosCiviles>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbEstadosCiviles item)
        {
            string sql = ScriptDataBase.EstadosCivilesActualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@EstD_Id", item.EstD_Id);
                parametro.Add("@EstD_Descripcion", item.EstD_Descripcion);
                parametro.Add("@EstD_UsuarioModificacion", item.EstD_UsuarioModificacion);
                parametro.Add("@EstD_FechaModificacion", item.EstD_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            throw new NotImplementedException();
        }
    }
}
