//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PersonComplainsController : ControllerBase
//    {
//        private readonly PersonComplainService _PersonComplainService;
        


//        public PersonComplainsController(PersonComplainService PersonComplainService)
//        {
//            _PersonComplainService = PersonComplainService;
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult> AddAsync(PersonComplainDto PersonComplainDto)
//        {

//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
//            var result = await _PersonComplainService.AddAsync(PersonComplainDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]")]
//        public async Task<IActionResult> GetAllAsync()
//        {
//            var result = await _PersonComplainService.GetAll();
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult> GetByIdAsync(int id)
//        {
//            var result = await _PersonComplainService.GetByIdAsync(id);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);



//        }
//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult> UpdateAsync(int id, PersonComplainDto PersonComplainDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var result = await _PersonComplainService.UpdateAsync(id, PersonComplainDto);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult> DeleteAsync(int id)
//        {
//            var result = await _PersonComplainService.DeleteAsync(id);
//            if (result.IsSuccess)
//                return Ok(result);
//            return BadRequest(result);
//        }
//    }
//}
