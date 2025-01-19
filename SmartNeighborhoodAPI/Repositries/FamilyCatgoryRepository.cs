namespace SmartNeighborhoodAPI.Repositries
{
    public class FamilyCatgoryRepository
    {
        protected IBaseRepository<FamilyCatgory> _FamilyCatgory;

        public FamilyCatgoryRepository(IBaseRepository<FamilyCatgory> familyCatgory)
        {
            _FamilyCatgory = familyCatgory;
        }
    }
}
