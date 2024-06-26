﻿using AHM.Total.Travel.DataAccess.Repositories;
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
    public class DepartamentosRepository : IRepository<tbDepartamentos>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbDepartamentos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbDepartamentos> FindDetalle(string id)
        {
            string sql = $"[Gnrl].[SP_Departamentos_Detalle] '{id}'";

            List<tbDepartamentos> result = new List<tbDepartamentos>();
            
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbDepartamentos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbDepartamentos item)
        {
            string sql = ScriptDataBase.deptoinsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Depa_Codigo", item.Depa_Codigo);
                parametro.Add("@Depa_Descripcion", item.Depa_Descripcion);
                parametro.Add("@Depa_UsuarioCreacion", item.Depa_UsuarioCreacion);
                parametro.Add("@Depa_FechaCreacion", item.Depa_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };


            }
        }

        public IEnumerable<tbDepartamentos> List()
        {
            const string sql = "[Gnrl].[SP_Departamentos_Listado]";
            List<tbDepartamentos> result = new List<tbDepartamentos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbDepartamentos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbDepartamentos item)
        {
            string sql = ScriptDataBase.deptoactualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Depa_Codigo", item.Depa_Codigo);
                parametro.Add("@Depa_Descripcion", item.Depa_Descripcion);
                parametro.Add("@Depa_UsuarioModificacion", item.Depa_UsuarioModificacion);
                parametro.Add("@Depa_FechaModificacion", item.Depa_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }
        public IEnumerable<tbDepartamentos> ObtenerDeptos()
        {
            var sql = ScriptDataBase.DepartamentosDropDownList;
            List<tbDepartamentos> result = new List<tbDepartamentos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result =  db.Query<tbDepartamentos>(sql, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public IEnumerable<tbDepartamentos> FindDepto(string codigo)
        {
            string sql = $"[Gnrl].[SP_Departamentos_Buscar] '{codigo}'";
            List<tbDepartamentos> result = new List<tbDepartamentos>();
            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbDepartamentos>(sql, commandType: System.Data.CommandType.Text).ToList();
                return result;
            }

        }
        public RequestStatus EliminarDepartamento(string id)
        {
            string sql = ScriptDataBase.deptoeliminar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Depa_Codigo", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }
    }
}
