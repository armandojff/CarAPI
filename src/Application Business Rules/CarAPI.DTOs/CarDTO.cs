namespace CarAPI.DTOs
{
    /// <summary>
    /// Data Transfer Object for Car entities used for communication between different layers of the application.
    /// </summary>
    public class CarDTO
    {
        public int Id { get; init; }
        public string Make { get; init; }
        public string Model { get; init; }
        public int Year { get; init; }
        public string Color { get; init; }
        public decimal Price { get; init; }
    }
}
