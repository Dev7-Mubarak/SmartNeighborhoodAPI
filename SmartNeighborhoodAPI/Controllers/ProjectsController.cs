using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        protected IBaseRepository<Project> _ProjectRepository;

        private readonly IMapper _mapper
        public ProjectsController(IBaseRepository<Project> ProjectRepository,IMapper mapper)
        {
            _ProjectRepository = ProjectRepository;
            _mapper=mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(ProjectDto projectDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var Project=_mapper.Map<Project>(projectDto);
            var result=await _ProjectRepository.AddAsync(Project);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Project"));
            return Ok(ApiResponse<Project>.Success(Project));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var Projects=await _ProjectRepository.GetAll().ToListAsync();
            var ProjectsDto=_mapper.Map<List<ProjectDto>>(Projects);

            return Ok(ApiResponse<ProjectDto>.Success(Projects));
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id,ProjectDto projectDto)
        {
            var Project=await _ProjectRepository.GetByIdAsync(id);
            if(Project is null)
                return NotFoud(404,ApiResponse<string>.Error("Project Not Found");
            var ProjectDto=_mapper.Map<Project>(projectDto);

            return Ok(ApiResponse<ProjectDto>.Success(ProjectDto);
        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,ProjectDto projectDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExistsProject=await _ProjectRepository.GetByIdAsync(id);
            if(ExistsProject is null)
                return NotFound(404,ApiResponse<string>.Error("Project Not Found"));

            var ProjectDto=_mapper.Map(projectDto,ExistsProject);

            var result=await _ProjectRepository.UpdateAsync(ProjectDto);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Project");

            return Ok(ApiResponse<Project>.Success(ProjectDto));
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var Project =await _ProjectRepository.GetByIdAsync(id);

            if(Project is null)
                return NotFound(404,ApiResponse<string>.Error("Project Not Found"));

            var result=await _ProjectRepository.DeleteAsync(Project);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Project"));

            return Ok(ApiResponse<string>.Success("Project Deleted Succesfully"));
        }
    }
}
