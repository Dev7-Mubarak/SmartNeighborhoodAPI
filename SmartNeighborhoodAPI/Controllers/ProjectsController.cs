//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProjectsController : ControllerBase
//    {
//        private readonly ProjectService  _ProjectService;

//        public ProjectsController(ProjectService projectService)
//        {
//            _ProjectService = projectService;
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult>AddAsync(ProjectDto projectDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
//            var result = await _ProjectService.AddAsync(projectDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetAllAsync()
//        {
//            var result=await _ProjectService.GetAllAsync();
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult>GetByIdAsync(int id,ProjectDto projectDto)
//        {
//            var result=await _ProjectService.GetByIdAsync(id,projectDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
            

            
//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult>UpdateAsync(int id,ProjectDto projectDto)
//        {
//            if(!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var result = await _ProjectService.UpdateAsync(id, projectDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult>DeleteAsync(int id)
//        {
//            var result = await _ProjectService.DeleteAsync(id);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//    }
//}
