using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberTypeController : ControllerBase
    {
        protected IBaseRepository<MemberType> _context;

        public MemberTypeController(IBaseRepository<MemberType> context)
        {
            _context = context;
        }
    }
}
