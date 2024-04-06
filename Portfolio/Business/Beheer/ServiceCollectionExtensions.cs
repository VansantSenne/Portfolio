using Beheer.Handlers;
using DAL.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beheer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ProjectServices(this IServiceCollection services)
        {
            services.AddTransient<IPortfolioContext, PortolioContext>();
            services.AddTransient<IGetProjectsHandler, GetProjectsHandler>();
            return services;
        }
    }
}
