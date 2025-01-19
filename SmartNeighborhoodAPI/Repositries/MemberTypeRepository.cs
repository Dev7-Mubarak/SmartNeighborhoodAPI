namespace SmartNeighborhoodAPI.Repositries
{
    public class MemberTypeRepository
    {
        protected IBaseRepository<MemberType> _memberType;

        public MemberTypeRepository(IBaseRepository<MemberType> memberType)
        {
            _memberType = memberType;
        }
    }
}
