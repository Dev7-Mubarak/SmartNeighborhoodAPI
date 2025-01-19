using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainTypesController : ControllerBase
    {
        protected IBaseRepository<ComplainType> _context;

        public ComplainTypesController(IBaseRepository<ComplainType> context)
        {
            _context = context;
        }
    }
}
