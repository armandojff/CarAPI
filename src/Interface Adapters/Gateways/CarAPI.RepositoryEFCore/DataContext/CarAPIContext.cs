using CarAPI.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.RepositoryEFCore.DataContext
{
    /// <summary>
    /// Represents the database context.
    /// </summary>
    public class CarAPIContext : DbContext
    {
        public CarAPIContext(DbContextOptions<CarAPIContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }

    }
}
