//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MemberTypeController : ControllerBase
//    {
//        protected IBaseRepository<MemberType> _MemberTypeRepository;
//        private readonly IMapper _mapper;

//        public MemberTypeController(IBaseRepository<MemberType> MemberTypeRepository,IMapper mapper)
//        {
//            _MemberTypeRepository = MemberTypeRepository;
//            _mapper=mapper
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult>AddAsync(MemberTypeDto memberTypeDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
//            var MemberType=_mapper.Map<MemberType>(memberTypeDto);

//            var result=_MemberTypeRepository.AddAsync(MemberType);
//            if(result<=0)
//                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Memeber Type"));
//            return Ok(ApiResponse<MemberTypeDto>.Success(MemberType));
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetAllAsync()
//        {
//            var MemberType=await _MemberTypeRepository.GetAll().ToListAsync();
//            var MemberTypeDto=_mapper.Map<List<MemberTypeDto>>(MemberType);

//            return Ok(ApiResponse<List<MemberTypeDto>>MemberType);
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetByIdAsync(int id,MemberTypeDto memberTypeDto)
//        {
//            var MemberType=await _MemberTypeRepository.GetByIdAsync(id);
//            if(MemberType is null)
//                return NotFound(404,ApiResponse<string>.Error("Memeber Type"));
//            var MemberTypeDto=_mapper.Map<MemberType>(memberTypeDto);
//            return Ok(ApiResponse<MemberTypeDto>.Success(MemberTypeDto));
//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult>UpdateAsync(int id,MemberTypeDto memberTypeDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var ExistsMemberType=await _MemberTypeRepository.GetByIdAsync(id);
//            if(ExistsMemberType is null)
//                return NotFound(404,ApiResponse<string>.Error("Member Type Not Found"));

//            var MemberTypeDto=_mapper.Map(memberTypeDto,
//                ExistsMemberType);

//            var result=await _MemberTypeRepository.UpdateAsync(MemberTypeDto);
//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Memeber Type"));
//            return Ok(ApiResponse<MemberType>.Success(MemberTypeDto));
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult>DeleteAsync(int id)
//        {
//            var MemberType=await _MemberTypeRepository.GetByIdAsync(id);
//            if(MemberType is null)
//                return NotFound(404,ApiResponse<string>.Error("Member Type Not Found"));

//            var result=await _MemberTypeRepository.DeleteAsync(MemberType);

//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Member Type"));

//            return Ok(ApiResponse<string>.Success("Member Type Deleted Succesfully"));
//        }
//    }
//}
