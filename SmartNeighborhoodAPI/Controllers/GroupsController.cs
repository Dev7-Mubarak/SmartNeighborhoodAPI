using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        protected IBaseRepository<Group> _GroupRepository;
        private readonly IMapper _mapper;

        public GroupsController(IBaseRepository<Group> GroupRepository,IMapper mapper)
        {
            _GroupRepository = GroupRepository;
            _mapper=mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult>AddAsync(GroupDto groupDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            var Group=_mapper.Map<Group>(groupDto);

            var result=await _GroupRepository.AddAsync(Group);
            if(result<=0)
                return BadRequest(ApiResponse<string>.Error("Failed To Add Group")

            return Ok(ApiResponse<GroupDto>.Success(Group));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var Groups=await _GroupRepository.GetAll().ToListAsync();

            var GroupsDto=_mapper.Map<List<GroupDto>>(Groups);
            return Ok(ApiResponse<list<GroupDto>>.Success(Groups);
        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id,GroupDto groupDto)
        {
            var Group=await _GroupRepository.GetByIdAsync(id);
            if(Group is null)
                return NotFound(404,ApiResponse<string>.Error("Group Not Found"));
            var GroupDto=_mapper.Map<Group>(GroupDto);
            return Ok(ApiResponse<GroupDto>.Success(groupDto));
        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,GroupDto groupDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExistsGroup=await _GroupRepository.GetByIdAsync(id);
            if(ExistsGroup is null)
                return NotFound(404,ApiResponse<string>.Error("Group Not Found"));

            var GroupDto=_mapper.Map(groupDto,ExistsGroup);

            var result=await _GroupRepository.UpdateAsync(GroupDto);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Update Group"));
            return Ok(ApiResponse<Group>.Success(GroupDto));
        }
        [HttpDelete("[action]/{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var Group=await _GroupRepository.GetByIdAsync(id);
            if(Group is null)
                return NotFound(404,ApiResponse<string>.Error("Group Not found"));

            var result=await _GroupRepository.DeleteAsync(Group);
            if(result<=0)
                return BadRequest(500,ApiResponse<string>.Error("Failed To Delete Group"));

            return Ok(ApiResponse<string>.Success("Group Deleted Succesfully"));
        }
    }
}
