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
    public class MunicipiosRepository : IRepository<tbMunicipios>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbMunicipios Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMunicipios item)
        {
            string sql = ScriptDataBase.MunicipiosInsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Muni_Codigo", item.Muni_Codigo);
                parametro.Add("@Depa_Codigo", item.Depa_Codigo);
                parametro.Add("@Muni_Descripcion", item.Muni_Descripcion);
                parametro.Add("@Muni_UsuarioCreacion", item.Muni_UsuarioCreacion);
                parametro.Add("@Muni_FechaCreacion", item.Muni_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public IEnumerable<tbMunicipios> List()
        {
            string sql = ScriptDataBase.MunicipiosListar;

            List<tbMunicipios> result = new List<tbMunicipios>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbMunicipios>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbMunicipios item)
        {
            string sql = ScriptDataBase.MunicipiosActualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Muni_Codigo", item.Muni_Codigo);
                parametro.Add("@Depa_Codigo", item.Depa_Codigo);
                parametro.Add("@Muni_Descripcion", item.Muni_Descripcion);
                parametro.Add("@Muni_UsuarioModificacion", item.Muni_UsuarioModificacion);
                parametro.Add("@Muni_FechaModificacion", item.Muni_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbMunicipios> FindMuni(string codigo)
        {
            //string sql = ScriptDataBase.MunicipiosBuscar;
            string sql = $"[Gnrl].[SP_Municipios_Buscar] '{codigo}'";
            List<tbMunicipios> result = new List<tbMunicipios>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
               
                result = db.Query<tbMunicipios>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }

        }

        public RequestStatus EliminarMunicipio(string id)
        {
            string sql = ScriptDataBase.MunicipiosEliminar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Muni_Codigo", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
        public IEnumerable<tbMunicipios> FindDetalle(string id)
        {
            string sql = $"[Gnrl].[SP_Municipios_Detalle] '{id}'";

            List<tbMunicipios> result = new List<tbMunicipios>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbMunicipios>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }
    }
}
