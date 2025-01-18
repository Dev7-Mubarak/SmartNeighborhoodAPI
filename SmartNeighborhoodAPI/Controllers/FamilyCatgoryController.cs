using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyCatgoryController : ControllerBase
    {
        protected IBaseRepository<FamilyCatgory> _context;

        public FamilyCatgoryController(IBaseRepository<FamilyCatgory> context)
        {
            _context = context;
        }
    }
}
