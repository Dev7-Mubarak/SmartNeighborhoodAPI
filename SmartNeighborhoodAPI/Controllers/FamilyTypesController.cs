//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class FamilyTypesController : ControllerBase
//    {
//        protected IBaseRepository<FamilyType> _FamilyTypeRepositoy;
//        private readonly IMapper _mapper;

//        public FamilyTypesController(IBaseRepository<FamilyType> FamilyTypeRepositoy,IMapper mapper)
//        {
//            _FamilyTypeRepositoy = FamilyTypeRepositoy;
//            _mapper=mapper;
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult>AddAsync(FamilyTypeDto familyTypeDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var FamilyType=_mapper.Map<FamilyType>(familyTypeDto);
//            var result=await _FamilyTypeRepositoy.AddAsync(FamilyType);
//            if(result<=0)
//                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Family Type"));
//            return Ok(ApiResponse<FamilyTypeDto>.Success(FamilyType));
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetAllAsync()
//        {
//            var FamiliesType=await _FamilyTypeRepositoy.GetAll().ToListAsync();
//            var FamiliesTypeDto=_mapper.Map<List<FamilyTypeDto>>(FamiliesType);

//            return Ok(ApiResponse<FamiliesTypeDto>.Success(FamiliesType));
//        }
//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult>GetByIdAsync(int id,FamilyTypeDto familyTypeDto)
//        {
//            var FamilyType=await _FamilyTypeRepositoy.GetByIdAsync(id);
//            if(FamilyType is null)
//                return NotFound(404,ApiResponse<string>.Error("Family Type Not Found"));
//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult>UpdateAsync(int id ,FamilyTypeDto familyTypeDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var ExstisFamilyType=await _FamilyTypeRepositoy.GetByIdAsync(id);

//            if(ExstisFamilyType is null)
//                return NotFound(404,ApiResponse<string>.Error("Family Type Not found"));

//            var FamilyTypeDto=_mapper.Map(familyTypeDto,ExstisFamilyType);

//            var result=await _FamilyTypeRepositoy.UpdateAsync(familyTypeDto);
//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Family Type"));
//            return Ok(ApiResponse<FamilyType>.Success(FamilyTypeDto));
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult>DeleteAsync(int id)
//        {
//            var FamilyType=await _FamilyTypeRepositoy.GetByIdAsync(id);
//            if(FamilyType is null)
//                return NotFound(404,ApiResponse<string>.Error("Family Type Not Found"));

//            var result=await _FamilyTypeRepositoy.DeleteAsync(FamilyType);
//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Family Type"));

//            return Ok(ApiResponse<string>.Success("Family Type Deleted Succesfully"));
//        }

//    }
//}
