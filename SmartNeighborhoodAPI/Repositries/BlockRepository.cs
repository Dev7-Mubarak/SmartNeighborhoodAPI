namespace SmartNeighborhoodAPI.Repositries
{
    public class BlockRepository
    {
        protected IBaseRepository<Block> _Bloock;

        public BlockRepository(IBaseRepository<Block> bloock)
        {
            _Bloock = bloock;
        }
    }

}
