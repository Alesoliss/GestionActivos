using Microsoft.Extensions.DependencyInjection;
using SistemaActivos.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaActivos.DataAccess;

namespace SistemaDeActivos.BusinessLogic
{
    public static class ServicesConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string conn)
        {
            service.AddScoped<DepartamentosRepository>();
            SistemaActivosContext.BuildConnectionString(conn);
        }

        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<GeneralServices>();
        }
    }
}
