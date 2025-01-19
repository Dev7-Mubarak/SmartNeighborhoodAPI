namespace SmartNeighborhoodAPI.Repositries
{
    public class ComplainRepository
    {
        protected IBaseRepository<Complain> _complain;

        public ComplainRepository(IBaseRepository<Complain> complain)
        {
            _complain = complain;
        }
    }
}
