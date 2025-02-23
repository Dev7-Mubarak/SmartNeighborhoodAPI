using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyCatgoryController : ControllerBase
    {
        protected IBaseRepository<FamilyCatgory> _FamilyCatgoryRepository;
        private readonly IMapper _mapper;

        public FamilyCatgoryController(IBaseRepository<FamilyCatgory> context,IMapper mapper)
        {
            _context = context;
            _mapper=mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(FamilyCatgoryDto familyCatgoryDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var FamilyCatgory=_mapper.Map<FamilyCatgory>(familyCatgoryDto);
            var result=await _FamilyCatgoryRepository.AddAsync(FamilyCatgory);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Family Catgory"));

            return Ok(ApiResponse<FamilyCatgoryDto>.Success(FamilyCatgory));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var FamilyCatgories=await _FamilyCatgoryRepository.GetAll().ToListAsync();

            var FamilyCatgoriesDto=-_mapper.Map<List<FamilyCatgoryDto>>(FamilyCatgories);

            return Ok(ApiResponse<List<FamilyCatgoryDto>>.Success(FamilyCatgories));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetByIdAsync(int id,FamilyCatgoryDto familyCatgoryDto)
        {
            var FamilyCatgory=await _FamilyCatgoryRepository.GetByIdAsync(id);

            if(FamilyCatgory is null)
                return NotFound(ApiResponse<string>.Error(404,"Family Catgory Not Found"));

            var FamilyCatgoryDto=_mapper.Map<FamilyCatgory>(familyCatgoryDto);

            return Ok(ApiResponse<FamilyCatgoryDto>.Success(FamilyCatgoryDto));
        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id,FamilyCatgoryDto familyCatgoryDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExsitsFamilyCatgory=await _FamilyCatgoryRepository.GetByIdAsync(id);
            if(ExsitsFamilyCatgory is null)
                NotFound(ApiResponse<string>.Error(404,"Family Catgory Not Found"));
            var FamilyCatgoryDto=_mapper.Map(familyCatgoryDto,ExsitsFamilyCatgory);

            var result=await _FamilyCatgoryRepository.UpdateAsync(FamilyCatgoryDto);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Update FamilyCatgory"));

            return Ok(ApiResponse<FamilyCatgory>.Success(FamilyCatgoryDto));
        }
        [HttpDelete("[action]/{id:int}")]

        public async Task<IActionResult>DeleteAsync(int id)
        {
            var FamilyCatgory=await _FamilyCatgoryRepository.GetByIdAsync(id);
            if(FamilyCatgory is null)
                return NotFound(ApiResponse<string>.Error(404,"Family Catgory Not Found"));

            var result=_FamilyCatgoryRepository.DeleteAsync(FamilyCatgory);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Delete Family Catgory"))
            return Ok(ApiResponse<string>.Success("Family Catgory Deleted Succesfully"));
        }
    }
}
