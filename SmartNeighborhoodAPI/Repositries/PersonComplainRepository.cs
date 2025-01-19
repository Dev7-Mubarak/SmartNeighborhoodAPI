namespace SmartNeighborhoodAPI.Repositries
{
    public class PersonComplainRepository
    {
        protected IBaseRepository<PersonComplain> _personComplain;

        public PersonComplainRepository(IBaseRepository<PersonComplain> personComplain)
        {
            _personComplain = personComplain;
        }
    }
}
