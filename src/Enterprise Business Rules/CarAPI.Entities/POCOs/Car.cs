using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.POCOs
{
    /// <summary>
    /// Represents a car entity in the business logic.
    /// </summary>
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

    }
}
