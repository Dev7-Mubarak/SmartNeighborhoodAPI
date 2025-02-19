using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainsController : ControllerBase
    {
        protected IBaseRepository<Complain> _ComplinRepositroy;
        private IMapper _mapper;

        public ComplainsController(IBaseRepository<Complain> ComplinRepositroy, IMapper mapper)
        {
            _ComplinRepositroy = ComplinRepositroy;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(ComplainDTo ComplainDTo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var Complain = _mapper.Map<Complain>(ComplainDTo);

            var resutl = await _ComplinRepositroy.AddAsync(Complain);
            if (resutl <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Faild To Add Complain"));

            return Ok(ApiResponse<Complain>.Success(Complain));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var Complains = await _ComplinRepositroy.GetAll().ToListAsync();

            var ComplainsDto = _mapper.Map<List<ComplainDTo>>(Complains);

            return Ok(ApiResponse<List<ComplainDTo>>.Success(ComplainsDto);


        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id)
        {
            var Complain = await _ComplinRepositroy.GetByIdAsync(id);

            if (Complain is null)
                return NotFound(ApiResponse<string>.Error(404, "Complain Not Found"));

            var ComplainDto = _mapper.Map<ComplainDTo>(Complain);

            return Ok(ApiResponse<ComplainDTo>.Success(ComplainDto));

        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,ComplainDTo ComplainDTo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var ExistsComplain = _ComplinRepositroy.GetByIdAsync(id);
            if (ExistsComplain is null)
                return NotFound(ApiResponse<string>.Error(404, "Complain Not Found"));

            var UpdateComplain = _mapper.Map(ComplainDTo, ExistsComplain);

            var result =await  _ComplinRepositroy.UpdateAsync(UpdateComplain);
            if (result <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Faild To Update Complain"));
            return Ok(ApiResponse<Complain>.Success(UpdateComplain));

        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var Complain=await _ComplinRepositroy.GetByIdAsync(id);
            if(Complain is null)
                return NotFound(ApiResponse<string>.Error(404,"Complain Not Found"));

            var result=await _ComplinRepositroy.DeleteAsync(Complain);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Delete Complain"));

            return Ok(ApiResponse<string>.Success("Complain Deleted Succesfully"));
        }

    }

}
