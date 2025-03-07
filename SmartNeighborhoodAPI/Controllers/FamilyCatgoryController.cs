using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyCatgoryController : AppControllerBase
    {
        private readonly FamilyCatgoryService _FamilyCatgoryService;

        


        public FamilyCatgoryController(FamilyCatgoryService FamilyCatgoryService)
        {
            
            _FamilyCatgoryService = FamilyCatgoryService;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddAsync(string nameFamilyCatgory)
        {

            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));


   
            var result = await _FamilyCatgoryService.AddAsync(nameFamilyCatgory);
            return Response(result);

            
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {

            var result = await _FamilyCatgoryService.GetAll();
            return Response(result);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {

            var result = await _FamilyCatgoryService.GetByIdAsync(id);
            return Response(result);


        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, string nameFamilyCatgory)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));


            var result = await _FamilyCatgoryService.UpdateAsync(id , nameFamilyCatgory);
            return Response(result);
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {

            var result = await _FamilyCatgoryService.DeleteAsync(id);
            return Response(result);
        }
    }
}
