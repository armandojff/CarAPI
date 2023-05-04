using CarAPI.DTOs;
using CarAPI.Interfaces;
using CarAPI.POCOs;
using CarAPI.Port;
using CarAPI.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.UseCases.UpdateCar
{
    public class UpdateCarInteractor : IUpdateCarInputPort
    {
        //Es quien resuelve el caso de uso 

        readonly ICarRepository Repository;

        readonly IUnitOfWork UnitOfWork;

        readonly IUpdateCarOutputPort OutputPort;

        public UpdateCarInteractor(ICarRepository repository, IUnitOfWork unitOfWork, IUpdateCarOutputPort outputPort)
        {
            Repository = repository;
            UnitOfWork = unitOfWork;
            OutputPort = outputPort;
        }

        public async Task Handle(UpdateCarDTO car)
        {
            Car NewCar = new Car
            {
                Id = car.Id,
                Make = car.Make,
                Model = car.Model,
                Year = car.Year,
                Color = car.Color,
                Price = car.Price
            };
            Repository.UpdateCar(NewCar);

            await UnitOfWork.SaveChanges();

            await OutputPort.Handle(
                new UpdateCarDTO
                {
                    Id = NewCar.Id,
                    Make = NewCar.Make,
                    Model = NewCar.Model,
                    Year = NewCar.Year,
                    Color = NewCar.Color,
                    Price = NewCar.Price
                });
        }
    }
}
