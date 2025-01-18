using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInfoController : ControllerBase
    {
        protected IBaseRepository<ContactInfo> _context;

        public ContactInfoController(IBaseRepository<ContactInfo> context)
        {
            _context = context;
        }
    }
}
