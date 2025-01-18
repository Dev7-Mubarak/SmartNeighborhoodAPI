namespace SmartNeighborhoodAPI.Repositries
{
    public class FamilyTypeRepository
    {
        protected IBaseRepository<FamilyType> _familyType;

        public FamilyTypeRepository(IBaseRepository<FamilyType> familyType)
        {
            _familyType = familyType;
        }
    }
}
