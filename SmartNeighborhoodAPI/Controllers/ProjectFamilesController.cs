using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectFamilesController : ControllerBase
    {
        protected IBaseRepository<ProjectFamily> _context;

        public ProjectFamilesController(IBaseRepository<ProjectFamily> context)
        {
            _context = context;
        }
    }
}
