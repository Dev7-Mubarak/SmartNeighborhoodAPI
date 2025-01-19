using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        protected IBaseRepository<TeamMember> _context;

        public TeamMembersController(IBaseRepository<TeamMember> context)
        {
            _context = context;
        }
    }
}
