using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainTypesController : ControllerBase
    {
        private readonly ComplainTypeService _ComplainTypeService;
        


        public ComplainTypesController(ComplainTypeService ComplainTypeService)
        {
            _ComplainTypeService = ComplainTypeService;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddAsync(ComplainTypeDto ComplainTypeDto)
        {
            

            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var result = await _ComplainTypeService.AddAsync(ComplainTypeDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _ComplainTypeService.GetAll();
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _ComplainTypeService.GetByIdAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);



        }
        [HttpPut("[action]/{id:int}")]




        //public async Task<IActionResult> UpdateAsync(int id, ComplainTypeDto complainTypeDto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

        //    var result = await _ComplainTypeService.UpdateAsync(id, complainTypeDto);
        //    if (result.IsSuccess)
        //        return Ok(result);
        //    return BadRequest(result);
        //}



        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _ComplainTypeService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
    }

}
