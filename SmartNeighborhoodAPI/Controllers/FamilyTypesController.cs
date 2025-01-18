using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyTypesController : ControllerBase
    {
        protected IBaseRepository<FamilyType> _context;

        public FamilyTypesController(IBaseRepository<FamilyType> context)
        {
            _context = context;
        }
    }
}
