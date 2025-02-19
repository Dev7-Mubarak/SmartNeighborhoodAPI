using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        protected IBaseRepository<TeamMember> _TeamMemberRepositroy;
        private readonly IMapper _mapper;


        public TeamMembersController(IBaseRepository<TeamMember> TeamMemberRepositroy,IMapper mapper)
        {
            _TeamMemberRepositroy = TeamMemberRepositroy;
            _mapper=mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(TeamMemberDto teamMemberDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var TeamMember=_mapper.Map<TeamMember>(teamMemberDto);
            var result=await _TeamMemberRepositroy.AddAsync(TeamMember);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error(500,"Failed To Add Team Member"));
            return Ok(ApiResponse<TeamMember>.Success(TeamMember));

        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var TeamMember=await _TeamMemberRepositroy.GetAll().ToListAsync();
            var TeamMemberDto=_mapper.Map<List<TeamMemberDto>>(TeamMember);

            return Ok(ApiResponse<List<TeamMemberDto>>.Success(TeamMemberDto));
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id,TeamMemberDto teamMemberDto)
        {
            var TeamMember=await _TeamMemberRepositroy.GetByIdAsync(id);
            if(TeamMember is null)
                return NotFound(404,ApiResponse<string>.Error("Team Member Not found"));
            var TeamMemberDto=_mapper.Map<TeamMember>(teamMemberDto);

            return Ok(ApiResponse<TeamMemberDto>.Success(TeamMemberDto));
        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,TeamMemberDto teamMemberDto)
        {

            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExistsTeamMember=await _TeamMemberRepositroy.GetByIdAsync(id);
            if(ExistsTeamMember is null)
                return  NotFound(404,ApiResponse<string>.Error("Team Mmeber Not Found"));

            var TeamMeberDto=_mapper.Map(teamMemberDto,ExistsTeamMember);

            var result=await _TeamMemberRepositroy.UpdateAsync(TeamMeberDto);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Team Member"));
            return Ok(ApiResponse<TeamMember>.Success(TeamMeberDto));
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var TeamMember=await _TeamMemberRepositroy.GetByIdAsync(id);
            if(TeamMember is null)
                return NotFound(404,ApiResponse<string>.Error("Team Member Not Found"));

            var result=await _TeamMemberRepositroy.DeleteAsync(TeamMember);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Team Member"));

            return Ok(ApiResponse<string>.Success("Team Member Deleted Succesfully"));
        }
    }
}
