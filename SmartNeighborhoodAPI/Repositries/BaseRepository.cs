
namespace SmartNeighborhoodAPI.Repositries

{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<int> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            if (await _context.SaveChangesAsync() > 0)
                return 1;

            return 0;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> Entities)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> Count(Expression<Func<T, bool>> Cirtira)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(int Id)
        {
            var entity = await GetByIdAsync(Id);
            _context.Set<T>().Remove(entity);

            if (await _context.SaveChangesAsync() > 0)
                return 1;

            return 0;
        }

        public Task<int> DeleteRange(IEnumerable<T> Entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            return _context.Set<T>().AsNoTracking();

        }

        public async Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes)
        { 
        //{
        //    IQueryable<T> query = _context.Set<T>();

        //    if (includes != null)
        //        query = includes.Aggregate(query, (current, include) => current.Include(include));

        //    return await query.FirstOrDefaultAsync(x => x.Id == id);
            return null;
        }

        public Task<int> Sum()
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);

            if (await _context.SaveChangesAsync() > 0)
                return 1;

            return 0;
        }

        public IEnumerable<T> UpdateRange(IEnumerable<T> Entities)
        {
            throw new NotImplementedException();
        }
    }
}