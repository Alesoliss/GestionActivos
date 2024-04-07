using Microsoft.Extensions.DependencyInjection;
using SistemaActivos.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaActivos.DataAccess;
using SistemaDeActivos.BusinessLogic.Services;

namespace SistemaDeActivos.BusinessLogic
{
    public static class ServicesConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string conn)
        {
            service.AddScoped<DepartamentosRepository>();
            service.AddScoped<RolesRepository>();
            service.AddScoped<EmpleadosRepository>();
            service.AddScoped<PantallasPorRolesRepository>();
            service.AddScoped<PantallasRepository>();
            SistemaActivosContext.BuildConnectionString(conn);

        }

        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<GeneralServices>();
            service.AddScoped<AccesoService>();
            service.AddScoped<ActiveService>();

        }
        
    }
}