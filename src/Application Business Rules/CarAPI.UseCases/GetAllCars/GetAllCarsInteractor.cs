
using CarAPI.DTOs;
using CarAPI.Interfaces;
using CarAPI.Port;

namespace CarAPI.GetAllCars
{
    public class GetAllCarsInteractor : IGetAllCarsInputPort
    {
        readonly ICarRepository Repository;

        readonly IGetAllCarsOutputPort OutputPort;

        public GetAllCarsInteractor(ICarRepository repository, IGetAllCarsOutputPort outputPort)
        {
            Repository = repository;
            OutputPort = outputPort;
        }

        public Task Handle()
        {
            var Cars = Repository.GetAll().Select(c =>
            new CarDTO
            {
                Id = c.Id,
                Make = c.Make,
                Color = c.Color,
                Model = c.Model,
                Price = c.Price,
                Year = c.Year
            });

            OutputPort.Handle(Cars);
            return Task.CompletedTask;

        }
    }
}
