using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.RepositoryEFCore.DataContext
{
    /// <summary>
    /// Factory class to create instances of <see cref="CarAPIContext"/>.
    /// </summary>
    class CarAPIContextFactory : IDesignTimeDbContextFactory<CarAPIContext>
    {
        public CarAPIContext CreateDbContext ( string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<CarAPIContext>();

            OptionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=CarAPIdb;User Id=postgres;Password=3004092;");

            return new CarAPIContext(OptionsBuilder.Options);
        }
    }
}
