//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class FamilyController : ControllerBase
//    {
//        protected IBaseRepository<Family> _FamilyRepository;
//        private readonly IMapper _mapper;
//        public FamilyController(IBaseRepository<Family> FamilyRepository,IMapper mapper)
//        {
//            _FamilyRepository = FamilyRepository;
//            _mapper=mapper;
//        }
//        [HttpPost("[action")]
//        public async Task<IActionResult>AddAsync(FamilyDto familyDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            
//            var Family=_mapper.Map<Family>(familyDto);

//            var result=await _FamilyRepository.AddAsync(Family)
//            if(result<=0)
//                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Family"));
//            return Ok(ApiResponse<FamilyDto>.Success(Family);
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetAllAsync()
//        {
//            var Families=await _FamilyRepository.GetAll().ToListAsync();

//            var FamiliesDto=_mapper.Map<List<FamilyDto>>(Families);

//            return Ok(ApiResponse<FamilyDto>.Success(Families);
//        }
//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult>GetByIdAsync(int id,FamilyDto familyDto)
//        {
//            var Family=await _FamilyRepository.GetByIdAsync(id);
//            if(Family is null)
//                return NotFound(ApiResponse<string>.Error(404,"Family Not Found"));

//            var FamilyDto=_mapper.Map<Family>(familyDto);

//            return Ok(ApiResponse<FamilyDto>.Success(familyDto));
//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult>UdpateAsync(int id,FamilyDto familyDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var ExsitsFamily=await _FamilyRepository.GetByIdAsync(id);
//            if(ExsitsFamily is null)
//                return NotFound(404,ApiResponse<string>.Error("Family Not Found"));

//            var UpdateFamily=_mapper.Map(familyDto,ExsitsFamily);

//            var result=await _FamilyRepository.UpdateAsync(UpdateFamily);
//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Family"));
//            return Ok(ApiResponse<Family>.Success(UpdateFamily);
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult>DeleteAsync(int id)
//        {
//            var Family=await _FamilyRepository.GetByIdAsync(id);
//            if(Family is null)
//                return NotFound(404,ApiResponse<string>.Error("Family Not Found"));

//            var result=await _FamilyRepository.DeleteAsync(Family);
//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Family"));

//            return Ok(ApiResponse<string>.Success("Family Deleted Succesfully"));
//        }
//    }
//}
