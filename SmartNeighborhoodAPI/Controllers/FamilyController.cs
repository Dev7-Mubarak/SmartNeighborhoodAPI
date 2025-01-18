using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyController : ControllerBase
    {
        protected IBaseRepository<Family> _context;

        public FamilyController(IBaseRepository<Family> context)
        {
            _context = context;
        }
    }
}
