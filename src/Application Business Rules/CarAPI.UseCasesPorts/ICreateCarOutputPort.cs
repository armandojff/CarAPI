using CarAPI.DTOs;

namespace CarAPI.Port
{
    /// <summary>
    /// This port receives data from the interactor and the presenter consumes it to subsequently send it to the controller.
    /// </summary>
    public interface ICreateCarOutputPort
    {
        Task Handle(CarDTO car);
    }
}
