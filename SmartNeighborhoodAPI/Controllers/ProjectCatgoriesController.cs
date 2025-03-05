//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProjectCatgoriesController : ControllerBase
//    {
//        private readonly ProjectCatgoryService _ProjectCatgoryService;
        


//        public ProjectCatgoriesController(ProjectCatgoryService ProjectCatgoryService)
//        {
//            _ProjectCatgoryService = ProjectCatgoryService;
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult> AddAsync(ProjectCatgoryDto ProjectCatgoryDto)
//        {

//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
//            var result = await _ProjectCatgoryService.AddAsync(ProjectCatgoryDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult> GetAllAsync()
//        {
//            var result = await _ProjectCatgoryService.GetAll();
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult> GetByIdAsync(int id)
//        {
//            var result = await _ProjectCatgoryService.GetByIdAsync(id);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);



//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult> UpdateAsync(int id, ProjectCatgoryDto ProjectCatgoryDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var result = await _ProjectCatgoryService.UpdateAsync(id, ProjectCatgoryDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult> DeleteAsync(int id)
//        {
//            var result = await _ProjectCatgoryService.DeleteAsync(id);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//    }
//}
