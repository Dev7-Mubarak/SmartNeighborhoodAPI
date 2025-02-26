//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProjectFamilesController : ControllerBase
//    {
//        protected IBaseRepository<ProjectFamily> _ProjectFamilyRepository;
//        private readonly IMapper _mapper;


//        public ProjectFamilesController(IBaseRepository<ProjectFamily> ProjectFamilyRepository,IMapper mapper)
//        {
//            _ProjectFamilyRepository = ProjectFamilyRepository;
//            _mapper=mapper;

//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult>AddAsync(ProjectFamilyDto projectFamilyDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var ProjectFamily=_mapper.Map<ProjectFamily>(projectFamilyDto);
//            var result=await _ProjectFamilyRepository.AddAsync(ProjectFamily);
//            if(result<=0)
//                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Project Family"));
//            return Ok(ApiResponse<ProjectFamily>.Success(ProjectFamily));
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetAllAsync()
//        {
//            var ProjectFamilies=await _ProjectFamilyRepository.GetAll().ToListAsync();

//            var ProjectFamiliesDto=_mapper.Map<List<ProjectFamilyDto>>(ProjectFamilies);

//            return Ok(ApiResponse<List<ProjectFamilyDto>>(ProjectFamilies));
//        }
//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult>GetByIdAsync(int id,ProjectFamilyDto projectFamilyDto)
//        {
//            var ProjectFamily=await _ProjectFamilyRepository.GetByIdAsync(id);
//            if(ProjectFamily is null)
//                return NotFound(404,ApiResponse<string>.Error("Project Family Not Found"));
//            var ProjectFamilyDto=_mapper.Map<ProjectFamily>(projectFamilyDto);
//            return Ok(ApiResponse<ProjectFamilyDto>.Success(ProjectFamilyDto));

//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult>UpdateAsync(int id,ProjectFamilyDto projectFamilyDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var ExistsProjectFamily=await _ProjectFamilyRepository.GetByIdAsync(id);
//            if(ExistsProjectFamily is null)
//                return NotFound(404,ApiResponse<string>.Error("Project Family Not Found"));

//            var ProjectFamilyDto=_mapper.Map(projectFamilyDto,ExistsProjectFamily);
//            var result=await _ProjectFamilyRepository.UpdateAsync(ProjectFamilyDto);
//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Project Family"));

//            return Ok(ApiResponse<ProjectFamily>.Success(ProjectFamilyDto);

//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult>DeleteAsync(int id)
//        {
//            var ProjectFamily=await _ProjectFamilyRepository.GetByIdAsync(id);
//            if(ProjectFamily is null)
//                return NotFound(404,ApiResponse<string>.Error("Project Family Not Found"));

//            var result=await _ProjectFamilyRepository.DeleteAsync(ProjectFamily);
//            if(result<=0)
//                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Project Family"));

//            return Ok(ApiResponse<string>.Success("Project Family Delete Succefully"));
//        }
//    }
//}
