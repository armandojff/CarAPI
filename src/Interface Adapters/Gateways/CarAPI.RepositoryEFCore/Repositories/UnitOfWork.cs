
using CarAPI.Interfaces;
using CarAPI.RepositoryEFCore.DataContext;

namespace CarAPI.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Here we apply the changes made to the database.
        /// </summary>
        readonly CarAPIContext Context;
        
        public UnitOfWork(CarAPIContext context)
        {
            Context = context;
        }

        public Task<int> SaveChanges()
        {
           return Context.SaveChangesAsync();
        }
    }
}
