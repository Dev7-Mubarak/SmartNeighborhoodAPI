using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        protected IBaseRepository<Project> _context;

        public ProjectsController(IBaseRepository<Project> context)
        {
            _context = context;
        }
    }
}
