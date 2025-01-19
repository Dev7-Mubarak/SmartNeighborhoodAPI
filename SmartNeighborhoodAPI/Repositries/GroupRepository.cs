namespace SmartNeighborhoodAPI.Repositries
{
    public class GroupRepository
    {
        protected IBaseRepository<Group> _Group;

        public GroupRepository(IBaseRepository<Group> group)
        {
            _Group = group;
        }
    }
}
