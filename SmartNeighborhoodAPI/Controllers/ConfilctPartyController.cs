//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ConfilctPartyController : ControllerBase
//    {
//        protected IBaseRepository<ConfilctParty> _ConfilctPartyRepository;
//        private readonly IMapper _mapper;

//        public ConfilctPartyController(IBaseRepository<ConfilctParty> context,IMapper mapper)
//        {
//            _context = context;
//            _mapper=mapper;
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult>AddAsync(ConfilctPartyDto confilctPartyDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState))

//            var ConfilctyParty=_mapper.Map<ConfilctParty>(confilctPartyDto);

//            var result=_ConfilctPartyRepository.AddAsync(confilctParty);
//            if(result<=0)
//                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add ConfilctParty"));

//            return Ok(ApiResponse<ConfilctParty>.Success(ConfilctyParty));
//        }
//        [HttpGet("action")]
//        public async Task<IActionResult>GetAllAsync()
//        {
//            var ConfilctParties=await _ConfilctPartyRepository.GetAll().ToListAsync();

//            var ConfilctPartyDto=_mapper.Map<list<ConfilctPartyDto>>(ConfilctParties);

//            return Ok(ApiResponse<ConfilctPartyDto>.Success(ConfilctParties);
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetByIdAsync(int id,ConfilctPartyDto confilctPartyDto)
//        {
//            var ConfilctParty=await _ConfilctPartyRepository.GetByIdAsync(id);
//            if(ConfilctParty is null)
//                return NotFound(ApiResponse<string>.Error(404,"ConfilctParty Not Found"));

//            var ConfilctPratyDto=_mapper.Map<ConfilctParty>(confilctPartyDto);

//            return Ok(ApiResponse<ConfilctPartyDto>.Success(ConfilctPratyDto));
//        }
//        [HttpPost("[action]/{id:int}")]
//        public async Task<IActionResult>UpdateAsync(int id ,ConfilctPartyDto confilctPartyDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var ExistsConfilctParty=await _ConfilctPartyRepository.GetByIdAsync(id);
//            if(ExistsConfilctParty is null)
//                return NotFound(ApiResponse<string>.Error(404,"ConfilctParty Not Found"));
//            var ConfilctPartyDto=_mapper.Map(confilctPartyDto,ExistsConfilctParty);

//            var result=await _ConfilctPartyRepository.UpdateAsync(ConfilctPartyDto);
//            if(result<=0)
//                return BadRequest(ApiResponse<string>.Error(500,"Failed To Update ConfilctParty"));

//            return Ok(ApiResponse<ConfilctParty>.Success(ConfilctPartyDto);
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult>DeleteAsync(int id)
//        {
//            var ConfilctParty=await _ConfilctPartyRepository.GetByIdAsync(id);
//            if(ConfilctParty is null)
//                return NotFound(ApiResponse<string>.Error(404,"ConfilctParty Not Found");

//            var result=_ConfilctPartyRepository.DeleteAsync(ConfilctParty);
//            if(result<=0)
//                return BadRequest(ApiResponse<string>.Error(500,"Failed To Delete ConfilctParty"));

//            return Ok(ApiResponse<string>.Success("ConfilctParty Deleted Succusfully");
//        }
//    }
//}
