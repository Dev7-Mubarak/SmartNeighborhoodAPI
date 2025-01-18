namespace SmartNeighborhoodAPI.Repositries
{
    public class ConfilctPartyRepository
    {
        protected IBaseRepository<ConfilctParty> _confilctParty;

        public ConfilctPartyRepository(IBaseRepository<ConfilctParty> confilctParty)
        {
            _confilctParty = confilctParty;
        }
    }
}
