using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfilctPartyController : ControllerBase
    {
        private readonly ConfilctPartyService _ConfilctPartyService;
        


        public ConfilctPartyController(ConfilctPartyService ConfilctPartyService)
        {
            _ConfilctPartyService = ConfilctPartyService;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddAsync(ConfilctPartyDto ConfilctPartyDto)
        {
            

            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var result = await _ConfilctPartyService.AddAsync(ConfilctPartyDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _ConfilctPartyService.GetAll();
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _ConfilctPartyService.GetByIdAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);



        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, ConfilctPartyDto ConfilctPartyDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var result = await _ConfilctPartyService.UpdateAsync(id, ConfilctPartyDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _ConfilctPartyService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
