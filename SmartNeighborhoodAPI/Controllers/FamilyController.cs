using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyController : AppControllerBase
    {
        private readonly FamilyService _FamilyService;
        

        public FamilyController(FamilyService FamilyService)
        {
            _FamilyService = FamilyService;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddAsync(FamilyDto FamilyDto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));


            var result = await _FamilyService.AddAsync(FamilyDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _FamilyService.GetAll();
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _FamilyService.GetByIdAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);



        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, FamilyDto FamilyDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var result = await _FamilyService.UpdateAsync(id, FamilyDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _FamilyService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
