using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        protected IBaseRepository<PersonComplain> _context;

        public PersonController(IBaseRepository<PersonComplain> context)
        {
            _context = context;
        }
    }
}
