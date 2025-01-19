using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfilctPartyController : ControllerBase
    {
        protected IBaseRepository<ConfilctParty> _context;

        public ConfilctPartyController(IBaseRepository<ConfilctParty> context)
        {
            _context = context;
        }
    }
}
