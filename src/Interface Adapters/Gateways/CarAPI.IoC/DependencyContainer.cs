using CarAPI.Presenters;
using CarAPI.RepositoryEFCore;
using CarAPI.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.IoC
{
    /// <summary>
    /// IoC (Inversion of Control) is a design pattern that allows for loosely-coupled and modular software architecture.
    /// It separates the creation and management of objects from their use, allowing for more flexibility and easier maintenance.
    /// </summary>
    public static class DependencyContainer
    {
        public static IServiceCollection AddCarAPIDependencies (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}
