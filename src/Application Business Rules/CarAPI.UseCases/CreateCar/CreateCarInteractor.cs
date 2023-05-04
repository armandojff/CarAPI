using CarAPI.DTOs;
using CarAPI.Interfaces;
using CarAPI.POCOs;
using CarAPI.Port;

namespace CarAPI.CreateCar
{
    public class CreateCarInteractor : ICreateCarInputPort
    {
        /// <summary>
        /// Interactor responsible for creating a new car and handling output port responses. This class implements use cases.
        /// </summary>

        readonly ICarRepository Repository;

        readonly IUnitOfWork UnitOfWork;

        readonly ICreateCarOutputPort OutputPort;

        public CreateCarInteractor(ICarRepository repository, IUnitOfWork unitOfWork, ICreateCarOutputPort outputPort)
        {
            Repository = repository;
            UnitOfWork = unitOfWork;
            OutputPort = outputPort;
        }
        /// <summary>
        /// Here I implement the method of the input port with which we call the repository to perform the operation in the database.
        /// </summary>
        public async Task Handle(CreateCarDTO car)
        {
            Car NewCar = new Car
            {
                Make = car.Make,
                Model = car.Model,
                Year = car.Year,
                Color = car.Color,
                Price = car.Price
            };
            Repository.CreateCar(NewCar);

            await UnitOfWork.SaveChanges();

            await OutputPort.Handle(
                new CarDTO
                {
                    Make = NewCar.Make,
                    Model = NewCar.Model,
                    Year = NewCar.Year,
                    Color = NewCar.Color,
                    Price = NewCar.Price
                });
        }
    }
}
