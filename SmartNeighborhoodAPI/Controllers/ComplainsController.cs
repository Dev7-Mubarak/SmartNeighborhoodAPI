using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainsController : ControllerBase
    {
        protected IBaseRepository<Complain> _context;

        public ComplainsController(IBaseRepository<Complain> context)
        {
            _context = context;
        }
    }
}
