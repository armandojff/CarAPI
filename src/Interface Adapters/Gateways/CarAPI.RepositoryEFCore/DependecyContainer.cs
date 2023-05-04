
using CarAPI.Interfaces;
using CarAPI.Repositories;
using CarAPI.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.RepositoryEFCore
{
    /// <summary>
    /// Provides a set of static methods to register dependencies in the service container.
    /// </summary>
    public static class DependecyContainer
    {
        /// <summary>
        /// Adds the repositories and unit of work to the service collection.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>The updated service collection.</returns>
        /// 
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarAPIContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("CarAPIdb")));
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
            
        }
    }

}
