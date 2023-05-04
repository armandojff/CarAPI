
using CarAPI.DTOs;
using CarAPI.Interfaces;
using CarAPI.POCOs;
using CarAPI.Port;
using CarAPI.UseCasesPorts;

namespace CarAPI.DeleteCar
{
    public class DeleteCarInteractor : IDeleteCarInputPort
    {
        readonly ICarRepository Repository;

        readonly IDeleteCarOutputPort OutputPort;

        public DeleteCarInteractor(ICarRepository repository, IDeleteCarOutputPort outputPort)
        {
            Repository = repository;
            OutputPort = outputPort;
        }

        public Task Handle(DeleteCarDTO car)
        {
            Car NewCar = new Car
            {
                Id = car.Id
            };
            Repository.DeleteCar(NewCar);
       

            OutputPort.Handle(car);
            return Task.CompletedTask;

        }
    }
}
