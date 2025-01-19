using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonComplainsController : ControllerBase
    {
        protected IBaseRepository<PersonComplain> _context;

        public PersonComplainsController(IBaseRepository<PersonComplain> context)
        {
            _context = context;
        }
    }
}
