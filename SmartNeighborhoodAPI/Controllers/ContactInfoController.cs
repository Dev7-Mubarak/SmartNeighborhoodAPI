using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInfoController : ControllerBase
    {
        protected IBaseRepository<ContactInfo> _ContactInfoRepositoy;
        private readonly IMapper _mapper;

        public ContactInfoController(IBaseRepository<ContactInfo> context,IMapper mapper)
        {
            _context = context;
            _mapper=mapper;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(ContactInfoDto contactInfoDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var ContactInfo=_mapper.Map<ContactInfo>(contactInfoDto);

            var result=await _ContactInfoRepositoy.AddAsync(ContactInfo);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Faield To Add ContactInfo"));
            return Ok(ApiResponse<ContactInfoDto>.Success(contactInfo));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var ContactInfos=await _ContactInfoRepositoy.GetAll().ToListAsync();
            
            var ContactInfosDto=_mapper.Map<List<ContactInfo>>(ContactInfos);

            return Ok(ApiResponse<List<ContactInfoDto>>.Success(ContactInfos));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetByIdAsync(int id,ContactInfoDto contactInfoDto)
        {
            var ContactInfo=await _ContactInfoRepositoy.GetByIdAsync(id);
            if(ContactInfo is null)
                return NotFound(ApiResponse<string>.Error(404,"Contact Info Not Found"));

            var ContactInfoDto=_mapper.Map<ContactInfo>(contactInfoDto);

            return Ok(ApiResponse<ContactInfoDto>.Success(contactInfoDto));
        }

        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,ContactInfoDto contactInfoDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExsitsContactInfo=await _ContactInfoRepositoy.GetByIdAsync(id);
            if(ExsitscontactInfoDto is null)
                return NotFound(ApiResponse<string>.Error(404,"Contact Info Not Found"));

            var ContactInfoDto=_mapper.Map(contactInfoDto,ExsitsContactInfo);

            var result=await _ContactInfoRepositoy.UpdateAsync(ContactInfoDto);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Faild To Update ContactInfo"));

            return Ok(ApiResponse<ContactInfo>.Success(ContactInfoDto));
        }
        [HttpDelete("[action]/{id:int}")]

        public async Task<IActionResult>DeleteAsync(int id)
        {
            var ContactInfo=await _ContactInfoRepositoy.GetByIdAsync(id);
            if(ContactInfo is null)
                return NotFound(ApiResponse<string>.Error(404,"ContactInfo Not Found"));

            var result=await _ContactInfoRepositoy.DeleteAsync(id);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Faild to Delete ContactInfo"));
            return Ok(ApiResponse<string>.Success("ContactInfo Deleted Succesfully"));
        }
    }
}
