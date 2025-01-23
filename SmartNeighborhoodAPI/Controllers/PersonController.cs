using Microsoft.AspNetCore.Mvc;
using SmartNeighborhoodAPI.Helpers;
using SmartNeighborhoodAPI.Helpers.DTOs;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IBaseRepository<Person> _personRepositry;
        private readonly IMapper _mapper;

        public PersonController(IBaseRepository<Person> personRepositry, IMapper mapper)
        {
            _personRepositry = personRepositry;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddAsync(PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var person = _mapper.Map<Person>(personDto);

            var result = await _personRepositry.AddAsync(person);

            if (result <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Failed to add the person."));

            return Ok(ApiResponse<Person>.Success(person));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {
            var persons = await _personRepositry.GetAll().ToListAsync();
            var personDtos = _mapper.Map<List<PersonDto>>(persons);
            return Ok(ApiResponse<List<PersonDto>>.Success(personDtos));
        }

        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var person = await _personRepositry.GetByIdAsync(id);
            if (person == null)
                return NotFound(ApiResponse<string>.Error(404, "Person not found."));

            var personDto = _mapper.Map<PersonDto>(person);
            return Ok(ApiResponse<PersonDto>.Success(personDto));
        }

        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var existingPerson = await _personRepositry.GetByIdAsync(id);
            if (existingPerson == null)
                return NotFound(ApiResponse<string>.Error(404, "Person not found."));

            var updatedPerson = _mapper.Map(personDto, existingPerson);

            var result = await _personRepositry.UpdateAsync(updatedPerson);
            if (result <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Failed to update the person."));

            return Ok(ApiResponse<Person>.Success(updatedPerson));
        }

        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var person = await _personRepositry.GetByIdAsync(id);
            if (person == null)
                return NotFound(ApiResponse<string>.Error(404, "Person not found."));

            var result = await _personRepositry.DeleteAsync(id);
            if (result <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Failed to delete the person."));

            return Ok(ApiResponse<string>.Success("Person deleted successfully."));
        }
    }
}
