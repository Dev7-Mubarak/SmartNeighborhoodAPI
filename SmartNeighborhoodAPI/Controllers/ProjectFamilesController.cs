//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProjectFamilesController : ControllerBase
//    {
//        private readonly ProjectFamilyService _ProjectFamilyService;


//        public ProjectFamilesController(ProjectFamilyService ProjectFamilyService)
//        {
//            _ProjectFamilyService = ProjectFamilyService;
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult> AddAsync(ProjectFamilyDto ProjectFamilyDto)
//        {

//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
//            var result = await _ProjectFamilyService.AddAsync(ProjectFamilyDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult> GetAllAsync()
//        {
//            var result = await _ProjectFamilyService.GetAll();
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult> GetByIdAsync(int id)
//        {
//            var result = await _ProjectFamilyService.GetByIdAsync(id);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);



//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult> UpdateAsync(int id, ProjectFamilyDto ProjectFamilyDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var result = await _ProjectFamilyService.UpdateAsync(id, ProjectFamilyDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult> DeleteAsync(int id)
//        {
//            var result = await _ProjectFamilyService.DeleteAsync(id);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//    }
//}
