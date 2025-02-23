using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private readonly ProjectServices _projectServices;
        public ProjectsController(IBaseRepository<Project> ProjectRepository, IMapper mapper, ProjectServices projectServices)
        {

            _projectServices = projectServices;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddAsync(ProjectDto projectDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var reulte = await  _projectServices.AddAsync(projectDto); 
            if(reulte.IsSuccess)
                return Ok(reulte);

            return BadRequest(reulte);
            //var Project = _mapper.Map<Project>(projectDto);
            //var result = await _ProjectRepository.AddAsync(Project);
            //if (result <= 0)
            //    return BadRequest(ApiResponse<string>.Error(500, "Failed To Add Project"));
            //return Ok(ApiResponse<Project>.Success(Project));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _projectServices.GetAllAsync();
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id, ProjectDto projectDto)
        {
            var result=await _projectServices.GetByIdAsync(id, projectDto);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result);

            
        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, ProjectDto projectDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var result= await _projectServices.UpdateAsync(id,projectDto);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            

            var result= await _projectServices.DeleteAsync(id);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
