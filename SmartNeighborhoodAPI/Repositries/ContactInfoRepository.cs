namespace SmartNeighborhoodAPI.Repositries
{
    public class ContactInfoRepository
    {
        protected IBaseRepository<ContactInfo> _ContactInfo;

        public ContactInfoRepository(IBaseRepository<ContactInfo> contactInfo)
        {
            _ContactInfo = contactInfo;
        }
    }
}
