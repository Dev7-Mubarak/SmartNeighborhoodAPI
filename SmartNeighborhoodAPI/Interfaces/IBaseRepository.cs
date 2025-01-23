namespace SmartNeighborhoodAPI.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int Id);
    }
}
