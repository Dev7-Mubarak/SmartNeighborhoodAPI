namespace SmartNeighborhoodAPI.Repositries
{
    public class ComplainTypeRepository
    {
        protected IBaseRepository<ComplainType> _complainType;

        public ComplainTypeRepository(IBaseRepository<ComplainType> complainType)
        {
            _complainType = complainType;
        }
    }
}
