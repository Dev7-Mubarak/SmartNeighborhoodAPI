using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class TeamsService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public TeamsService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<TeamDto>> AddAsync(TeamDto TeamDto)
        {

            var team = _mapper.Map<TeamDto>(TeamDto);
            var Team = _mapper.Map<Team>(team);

            await _context.AddAsync(Team);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<TeamDto>.Success(team, "Added Successed");

            return ApiResponse<TeamDto>.Error(HttpStatusCode.BadRequest, "Team not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Team Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Team Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the Team");
        }
        public async Task<ApiResponse<IQueryable<TeamDto>>> GetAll()
        {
            var Teams = _context.Teams.Include("").AsNoTracking().ToList();
            if (Teams.Count > 0)
            {
                var TeamDtos = _mapper.Map<IQueryable<TeamDto>>(Teams);
                return ApiResponse<IQueryable<TeamDto>>.Success(TeamDtos);
            }

            return ApiResponse<IQueryable<TeamDto>>.Error(HttpStatusCode.BadRequest, "No Team Found");



        }
        public async Task<ApiResponse<TeamDto>> GetByIdAsync(int id)
        {
            var Team = await _context.Teams.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (Team == null)
                return ApiResponse<TeamDto>.Error(HttpStatusCode.BadRequest, "Team Not Found");


            var TeamDto = _mapper.Map<TeamDto>(Team);
            return ApiResponse<TeamDto>.Success(TeamDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, TeamDto TeamDto)
        {
            var ExsitTeam = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitTeam is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Team Not Found");
            var UpdateTeam = _mapper.Map(TeamDto, ExsitTeam);

            _context.Teams.Update(UpdateTeam);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Team Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Team");


        }
    }
}
