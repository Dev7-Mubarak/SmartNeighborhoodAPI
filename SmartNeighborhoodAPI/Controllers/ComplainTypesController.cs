using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainTypesController : ControllerBase
    {
        protected IBaseRepository<ComplainType> _ComplainTypeRepository;
        private readonly IMapper _mapper;

        public ComplainTypesController(IBaseRepository<ComplainType> context,IMapper mapper)
        {
            _context = context;
            _mapper=mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(ComplainTypeDto complainTypeDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var complianType=_mapper.Map<ComplainType>(complainTypeDto);
            
            var result=await _ComplainTypeRepository.AddAsync(complainType);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error("Faild To Add Complain Type"));
            return Ok(ApiResponse<ComplainType>.Success(complianType));

        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var ComplainTypes=await _ComplainTypeRepository.GetAll().ToListAsync();

            var CompalinTypesDto=_mapper.Map(List<ComplainDTo>(ComplainTypes);

            return Ok(ApiResponse<List<ComplainTypeDto>>.Success(CompalinTypesDto));
        }
        [HttpGet("[action]{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id,ComplainTypeDto complainTypeDto)
        {
            var complianType=_ComplainTypeRepository.GetByIdAsync(id);
            if(complianType is null)
                return NotFound(ApiResponse<string>.Error(404,"Complain Type Not Found"));
            var ComplainTypeDto=_mapper.Map<ComplainType>(complainTypeDto);
            return Ok(ApiResponse<ComplainTypeDto>.Success(complainTypeDto);
        }
        [HttpPut("[action]{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,ComplainTypeDto complainTypeDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExsitsComplianType=await _ComplainTypeRepository.GetByIdAsync(id);
            if(ExsitsComplianType is null)
                return NotFound(ApiResponse<string>.Error(404,"Complain Type Not Found");
            var ComplainTypeDto=_mapper.Map(complainTypeDto,ExsitsComplianType);

            var result=await _ComplainTypeRepository.UpdateAsync(ComplainTypeDto);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Update Complain Type");

            return Ok(ApiResponse<ComplainType>.Success(ComplainTypeDto));
        }
        [HttpDelete("[action]{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var ComplainType=await _ComplainTypeRepository.GetByIdAsync(id);
            if(ComplainType is null)
                return NotFound(ApiResponse<string>.Error(404,"Complain Type Not Found"));

            var result=await _ComplainTypeRepository.DeleteAsync(ComplainType);

            return Ok(ApiResponse<string>.Success("ComplainType Deleted Succesfully"));
        }
    }

}
