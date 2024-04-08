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
    public class SucursalesRepository : IRepository<tbSucursales>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbSucursales Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbSucursales item)
        {
            string sql = ScriptDataBase.SucursalesInsertar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Sucu_Descripcion", item.Sucu_Descripcion);
                parametro.Add("@Depa_Codigo", item.Depa_Codigo);
                parametro.Add("@Muni_Codigo", item.Muni_Codigo);
                parametro.Add("@Sucu_DireccionExacta", item.Sucu_DireccionExacta);
                parametro.Add("@Sucu_UsuarioCreacion", item.Sucu_UsuarioCreacion);
                parametro.Add("@Sucu_FechaCreacion", item.Sucu_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbSucursales> List()
        {
            string sql = ScriptDataBase.SucursalesListado;

            List<tbSucursales> result = new List<tbSucursales>();

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                result = db.Query<tbSucursales>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbSucursales item)
        {
            string sql = ScriptDataBase.deptoactualizar;

            using (var db = new SqlConnection(SistemaActivosContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Depa_Codigo", item.Depa_Codigo);
                parametro.Add("@Sucu_Descripcion", item.Sucu_Descripcion);
                parametro.Add("@Depa_Codigo", item.Depa_Codigo);
                parametro.Add("@Muni_Codigo", item.Muni_Codigo);
                parametro.Add("@Sucu_DireccionExacta", item.Sucu_DireccionExacta);
                parametro.Add("@Sucu_UsuarioModificacion", item.Sucu_UsuarioModificacion);
                parametro.Add("@Sucu_FechaModificacion", item.Sucu_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
    }
}