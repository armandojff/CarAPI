
using CarAPI.CreateCar;
using CarAPI.DeleteCar;
using CarAPI.GetAllCars;
using CarAPI.Port;
using CarAPI.UseCases.UpdateCar;
using CarAPI.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateCarInputPort, CreateCarInteractor>();
            services.AddTransient<IGetAllCarsInputPort, GetAllCarsInteractor>();
            services.AddTransient<IDeleteCarInputPort, DeleteCarInteractor>();
            services.AddTransient<IUpdateCarInputPort, UpdateCarInteractor>();

            return services;

        }
    }
}
