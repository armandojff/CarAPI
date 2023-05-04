
using CarAPI.DTOs;
using CarAPI.Port;

namespace CarAPI.Presenters
{
    /// <summary>
    /// This takes the information coming from the use cases and formats it to what the interface needs. It receives it as a DTO and formats it to JSON, XML, or other needed formats.
    /// </summary>
    /// 
    public class CreateCarPresenter : ICreateCarOutputPort, IPresenter<CarDTO>
    {
        public CarDTO Content { get; private set; }

        public Task Handle(CarDTO car)
        {
            Content = car;
            return Task.CompletedTask;
        }
    }
}
