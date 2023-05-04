using CarAPI.Interfaces;
using CarAPI.POCOs;
using CarAPI.RepositoryEFCore.DataContext;

namespace CarAPI.Repositories
{
    public class CarRepository : ICarRepository
    {
        /// <summary>
        /// Here we implement the entities interface where the company's domain is located, and perform database operations.
        /// </summary>

        readonly CarAPIContext Context;

        public CarRepository(CarAPIContext context)
        {
            Context = context;
        }

        public void CreateCar(Car car)
        {
            Context.Add(car);
        }

        public void DeleteCar(Car car)
        {
            Context.Remove(car);

            Context.SaveChanges();
        }

        public IEnumerable<Car> GetAll()
        {
            return Context.Cars;
        }

        public void UpdateCar(Car cars)
        {
            // First, retrieve the existing car from the database
             var existingCar = Context.Cars.Find(cars.Id);
    
            if (existingCar != null)
            {
                // Update the properties of the existing car
                existingCar.Make = cars.Make;
                existingCar.Model = cars.Model;
                existingCar.Year = cars.Year;
                existingCar.Color = cars.Color;
                existingCar.Price = cars.Price;

                Context.SaveChanges();
            }
        }
    }
}
