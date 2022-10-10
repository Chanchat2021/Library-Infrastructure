namespace NeuLibrary.Infrastructure.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task Create(T entity);
        IQueryable<T> GetQuery();
        Task<IEnumerable<T>> GetAll();
        //Task<T?> GetById(int id);
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}
