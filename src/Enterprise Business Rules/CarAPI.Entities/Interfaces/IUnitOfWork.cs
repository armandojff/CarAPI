namespace CarAPI.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();

    }
}
