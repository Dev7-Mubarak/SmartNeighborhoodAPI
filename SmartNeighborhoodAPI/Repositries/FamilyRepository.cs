namespace SmartNeighborhoodAPI.Repositries
{
    public class FamilyRepository
    {
        protected IBaseRepository<Family> _family;

        public FamilyRepository(IBaseRepository<Family> family)
        {
            _family = family;
        }
    }
}
