
using CarAPI.DTOs;

namespace CarAPI.Port
{
    /// <summary>
    /// This port receives data from the controller and then sends it to the interactor.
    /// </summary>
    public interface ICreateCarInputPort
    {
        Task Handle(CreateCarDTO car);

    }
}
