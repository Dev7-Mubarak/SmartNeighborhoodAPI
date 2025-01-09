using System.Linq.Expressions;

namespace SmartNeighborhoodAPI.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);

        Task<int> AddAsync(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> Entities);
        Task<int> UpdateAsync(T entity);
        IEnumerable<T> UpdateRange(IEnumerable<T> Entities);
        Task<int> DeleteAsync(int Id);
        Task <int> DeleteRange(IEnumerable<T> Entities);
        Task <int>Count();
        Task< int> Count(Expression<Func<T, bool>> Cirtira);
        Task<int> Sum();
    }
}
