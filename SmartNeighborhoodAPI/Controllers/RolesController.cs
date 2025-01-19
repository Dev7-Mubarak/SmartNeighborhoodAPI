using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        protected IBaseRepository<Role> _context;

        public RolesController(IBaseRepository<Role> context)
        {
            _context = context;
        }
    }
}
