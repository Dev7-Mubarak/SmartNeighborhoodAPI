namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyTypesController : ControllerBase
    {
        private readonly FamilyTypeService _FamilyTypeService;


        public FamilyTypesController(FamilyTypeService FamilyTypeService)
        {
            _FamilyTypeService = FamilyTypeService;

        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddAsync(FamilyTypeDto FamilyTypeDto)
        {
            var result = await _FamilyTypeService.AddAsync(FamilyTypeDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _FamilyTypeService.GetAll();
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _FamilyTypeService.GetByIdAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);



        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, FamilyTypeDto FamilyTypeDto)
        {

            var result = await _FamilyTypeService.UpdateAsync(id, FamilyTypeDto);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _FamilyTypeService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
    }
}



