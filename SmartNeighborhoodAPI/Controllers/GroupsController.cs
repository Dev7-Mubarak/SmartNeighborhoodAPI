using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        protected IBaseRepository<Group> _context;

        public GroupsController(IBaseRepository<Group> context)
        {
            _context = context;
        }
    }
}
