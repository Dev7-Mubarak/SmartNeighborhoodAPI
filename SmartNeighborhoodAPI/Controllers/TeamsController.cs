using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
       
        protected IBaseRepository<Team> _teamRepository;
        private readonly IMapper _mapper;
        public TeamsController(IBaseRepository<Team> teamRepository,IMapper mapper)
        {
            _teamRepository=teamRepository;
            _mapper=mapper;
        }
        [HttpPost("[action]")]

        public async Task<IActionResult>AddAsync(TeamDto teamDto)
        {
            if(!ModelState)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState);

            var Team=_mapper.Map<Team>(teamDto);

            var result=await _teamRepository.AddAsync(Team);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Team"));
            return Ok(ApiResponse<Team>.Success(Team));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var Teams=await _teamRepository.GetAll().ToListAsync();

            var TeamsDto=_mapper.Map<List<TeamDto>>(Teams);

            return Ok(ApiResponse<list<TeamDto>>.Success(Teams));
        }
        [HttpGet("[action]\{id:int}]")]
        public async Task<IActionResult>GetByIdAsync(TeamDto teamDto,int id)
        {
            var Team=await _teamRepository.GetByIdAsync(id);
            if(Team<=0)
                return NotFound(ApiResponse<string>.Error(404,"Team Not Found"));

            var TeamDto=_mapper.Map<Team>(teamDto);

            return Ok(ApiResponse<TeamDto>.Success(TeamDto));

        }
        [HttpPut("[action]\{id:int}")]
        public async Task<IActionResult>UpdateAsync(TeamDto teamDto,int id)
        {
            if(!ModelState)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExistsTeam=await _teamRepository.GetByIdAsync(id);
            if(ExistsTeam<=0)
                return NotFound(ApiResponse<string>.Error(404,"Team Not Found"));

            var TeamDto=_mapper.Map<Team>(teamDto);

            var result=await _teamRepository.UpdateAsync(TeamDto);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Update Team"));
            return Ok(ApiResponse<Team>.Success(TeamDto));
        }
        [HttpDelete("[action]\{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var Team=await _teamRepository.GetByIdAsync(id);
            if(Team<=0)
                return BadRequest(ApiResponse<string>.Success(500,"Team Not Found"));

            var result=await _teamRepository.DeleteAsync(Team);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Delete Team"));
            return Ok(ApiResponse<string>.Success("Team Deleted Succefully"));

        }


    }
       
}
