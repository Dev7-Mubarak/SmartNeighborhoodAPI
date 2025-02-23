using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartNeighborhoodAPI.Services;


namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocksController : ControllerBase
    {
       
        readonly BlockServices _blockRepsitory;

        public BlocksController(BlockServices blockRepsitory)
        {
            _blockRepsitory = blockRepsitory;
        }

        [HttpPost("action")]
        public async Task<IActionResult>AddAsync(BlockDto blockDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
                 
            var resulte = await _blockRepsitory.AddAsync(blockDto);
            if (resulte.IsSuccess)
                return Ok(resulte);


            return BadRequest(resulte);
          
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var resulte = await _blockRepsitory.GetAll();
            if (resulte.IsSuccess)
                return Ok(resulte);

            return BadRequest(resulte);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id)
        {
            var resulte = await _blockRepsitory.GetByIdAsync(id);
            if (resulte.IsSuccess)
                return Ok(resulte);

            return BadRequest(resulte);

        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,BlockDto blockDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var resulte = await _blockRepsitory.UpdateAsync(id, blockDto);
            if (resulte.IsSuccess)
                return Ok(resulte);

            return BadRequest(resulte);
        }

        [HttpDelete("[action]{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var resulte = await _blockRepsitory.DeleteAsync(id);
            if (resulte.IsSuccess)
                return Ok(resulte);

            return BadRequest(resulte);
        }
    }

}
  