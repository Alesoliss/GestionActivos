﻿using GestionActivos.Models;
using GestionActivos.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Servicios
{
    public class DepartamentoServicios
    {

        private readonly API _api;


        public DepartamentoServicios(API api)
        {
            _api = api;

        }


    public async Task<ServiceResult> TypesActivitiesList()
    {



        var result = new ServiceResult();
        try
        {
            var response = await _api.Get<IEnumerable<TypesActivitiesViewModel>, IEnumerable<TypesActivitiesViewModel>>(req =>
           {
               req.Path = $"/API/TypeActivities/List";
               req.Content = null;
           }
            );
            if(!response.Success)
            {
                return result.FromApi(response);
            }
            else
            {
                return result.Ok(response.Data);
            }
        }
        catch(Exception ex)
        {
            return result.Error(Helpers.GetMessage(ex));
            throw;
        }
    }
}
}