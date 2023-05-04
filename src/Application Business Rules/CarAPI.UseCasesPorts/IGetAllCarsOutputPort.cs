
using CarAPI.DTOs;

namespace CarAPI.Port
{
    public interface IGetAllCarsOutputPort
    {
        Task Handle(IEnumerable<CarDTO> cars);

    }
}
