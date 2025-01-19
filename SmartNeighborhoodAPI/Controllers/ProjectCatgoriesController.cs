using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectCatgoriesController : ControllerBase
    {
        protected IBaseRepository<ProjectCatogory> _context;

        public ProjectCatgoriesController(IBaseRepository<ProjectCatogory> context)
        {
            _context = context;
        }
    }
}
