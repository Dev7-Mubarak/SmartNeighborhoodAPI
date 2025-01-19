using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocksController : ControllerBase
    {
        protected IBaseRepository<Block> _context;

        public BlocksController(IBaseRepository<Block> context)
        {
            _context = context;
        }
    }
}
