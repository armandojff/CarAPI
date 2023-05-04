using CarAPI.DTOs;
using CarAPI.Port;

namespace CarAPI.Presenters
{
    public class GetAllCarsPresenter : IGetAllCarsOutputPort, IPresenter<IEnumerable<CarDTO>>
    {
        public IEnumerable<CarDTO> Content { get; private set; }

        public Task Handle(IEnumerable<CarDTO> cars)
        {
            Content = cars;
            return Task.CompletedTask;
        }
    }
}
