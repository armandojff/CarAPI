using CarAPI.Port;
using CarAPI.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Presenters
{
    public static  class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreateCarOutputPort, CreateCarPresenter>();
            services.AddScoped<IGetAllCarsOutputPort, GetAllCarsPresenter>();
            services.AddScoped<IDeleteCarOutputPort, DeleteCarPresenter>();
            services.AddScoped<IUpdateCarOutputPort, UpdateCarPresenter>();
            return services;

        }
    }
}
