namespace SmartNeighborhoodAPI.Repositries
{
    public class AdRepository : IAdRepository<Ad>
    {
        public Task<int> AddAsync(Ad entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ad> AddRange(IEnumerable<Ad> Entities)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> Count(Expression<Func<Ad, bool>> Cirtira)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRange(IEnumerable<Ad> Entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Ad> GetAll(params Expression<Func<Ad, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<Ad> GetByIdAsync(int id, params Expression<Func<Ad, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<int> Sum()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Ad entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ad> UpdateRange(IEnumerable<Ad> Entities)
        {
            throw new NotImplementedException();
        }
    }
}
