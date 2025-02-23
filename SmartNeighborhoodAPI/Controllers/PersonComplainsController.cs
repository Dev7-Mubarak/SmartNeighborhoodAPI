using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonComplainsController : ControllerBase
    {
        protected IBaseRepository<PersonComplain> _PersonComplainRepository;
        private readonly IMapper _mapper;

        public PersonComplainsController(IBaseRepository<PersonComplain>PersonComplainRepository,IMapper mapper)
        {
            _PersonComplainRepository = PersonComplainRepository;
            _mapper=mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(PersonComplainDto personComplainDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var PersonComplain=_mapper.Map<PersonComplain>(personComplainDto);

            var result=await _PersonComplainRepository.AddAsync(PersonComplain);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Falied To Add Person Complain"));
            return Ok(ApiResponse<PersonComplain>.Success(PersonComplain));

        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var PersonComplains=await _PersonComplainRepository.GetAll().ToListAsync();

            var PersonComplainsDto=_mapper.Map<List<PersonComplainDto>(PersonComplains);

            return Ok(ApiResponse<List<PersonComplainDto>>(PersonComplains));
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id,PersonComplainDto personComplainDto)
        {
            var PersonComplain=await _PersonComplainRepository.GetByIdAsync(id);
            if(PersonComplain is null)
                return NotFound(404,ApiResponse<string>.Error("Person Complain Not Found"));

            var PersonComplainDto=_mapper.Map<PersonComplain>(personComplainDto);

            return Ok(ApiResponse<PersonComplainDto>(PersonComplainDto));
        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,PersonComplainDto personComplainDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExistsPersonComplain=await _PersonComplainRepository.GetByIdAsync(id);
            if(ExistsPersonComplain is null)
                return NotFound(404,ApiResponse<string>.Error("Person Complain Not Found"));

            var PersonComplainDto=_mapper.Map(personComplainDto,ExistsPersonComplain);

            var result=await _PersonComplainRepository.UpdateAsync(personComplainDto);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Person Complain"));

            return Ok(ApiResponse<PersonComplain>.Success(PersonComplainDto));
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var PersonComplain=await _PersonComplainRepository.GetByIdAsync(id);
            if(PersonComplain is null)
                return NotFound(404,ApiResponse<string>.Error("Person Complain Not Found"));

            var result=await _PersonComplainRepository.DeleteAsync(PersonComplain);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Person Complain"));

            return Ok(ApiResponse<string>.Success("Person Complain Deleted Succesfully"));
        }
    }
}
