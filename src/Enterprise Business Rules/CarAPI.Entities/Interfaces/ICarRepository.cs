using CarAPI.POCOs;
using System.Net.Http.Headers;
using System.Reflection.Emit;

namespace CarAPI.Interfaces
{
    /// <summary>
    /// Abstraction for the operations that will be performed in the data handling layer.
    /// </summary>
    public interface ICarRepository
    {
        /// <summary>
        /// Creates a new car in the repository.
        /// </summary>
        void CreateCar(Car cars);

        /// <summary>
        /// Retrieves all cars from the repository.
        /// </summary>
        /// <returns>An IEnumerable containing all the cars in the repository.</returns>
        IEnumerable<Car> GetAll();

        /// <summary>
        /// Updates an existing car in the repository.
        /// </summary>
        /// <param name="cars">The updated car object.</param>
        void UpdateCar(Car cars);

        /// <summary>
        /// Deletes an existing car from the repository.
        /// </summary>
        /// <param name="car">The car object to delete.</param>
        void DeleteCar(Car car);    

    }
}
