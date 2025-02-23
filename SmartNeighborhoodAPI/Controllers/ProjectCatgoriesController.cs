using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectCatgoriesController : ControllerBase
    {
        protected IBaseRepository<ProjectCatogory> _ProjectCatgoryRepository;
        private readonly IMapper _mapper;
        public ProjectCatgoriesController(IBaseRepository<ProjectCatogory> ProjectCatgoryRepository,IMapper mapper)
        {
            _ProjectCatgoryRepository = ProjectCatgoryRepository;
            _mapper=mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(ProjectCatgoryDto projectCatgoryDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState))

            var ProjectCatgory=_mapper.Map<ProjectCatogory>(projectCatgoryDto);
            var result=await _ProjectCatgoryRepository.AddAsync(ProjectCatgory);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Project Catgory"));
            return Ok(ApiResponse<ProjectCatogory>.Success(ProjectCatgory));

        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var ProjectCatgories=await _ProjectCatgoryRepository.GetAll().ToListAsync();

            var ProjectCatgories=_mapper.Map<List<ProjectCatgoryDto>>(ProjectCatgories);

            return Ok(ApiResponse<List<ProjectCatgoryDto>>.Success(ProjectCatgories));
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id ,ProjectCatgoryDto projectCatgoryDto)
        {
            var ProjectCatgory=await _ProjectCatgoryRepository.GetByIdAsync(id);
            if(ProjectCatgory is null)
                return NotFound(404,ApiResponse<string>.Error("Project Catgory"));
            var ProjectCatgoryDto=_mapper.Map<ProjectCatogory>(projectCatgoryDto);
            return Ok(ApiResponse<ProjectCatgoryDto>.Success(ProjectCatgoryDto));
        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,ProjectCatgoryDto projectCatgoryDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExistsProjectCatgory=await _ProjectCatgoryRepository.GetByIdAsync(id);
            if(ExistsProjectCatgory is null)
                return NotFound(404,ApiResponse<string>.Error("Project Catgory Not Found"));

            var ProjectCatgoryDto=_mapper.Map(projectCatgoryDto,ExistsProjectCatgory);

            var result=await _ProjectCatgoryRepository.UpdateAsync(ProjectCatgoryDto);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Project"));
            return Ok(ApiResponse<ProjectDto>.Success(ProjectCatgoryDto));
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var ProjectCatgory=await _ProjectCatgoryRepository.GetByIdAsync(id);
            if(ProjectCatgory is null)
                return NotFound(404,ApiResponse<string>.Error("Project Catgory Not Found"));

            var result=await _ProjectCatgoryRepository.DeleteAsync(ProjectCatgory);

            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Project Catgory"));

            return Ok(ApiResponse<string>.Success("Project Catgory Deleted Succesfully"));
        }
    }
}
