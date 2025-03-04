using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class TeamMemberService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;


        public TeamMemberService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<TeamMemberDto>> AddAsync(TeamMemberDto TeamMemberDto)
        {

            var block = _mapper.Map<TeamMemberDto>(TeamMemberDto);
            var Block = _mapper.Map<Block>(block);

            await _context.AddAsync(Block);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<TeamMemberDto>.Success(block, "Added Successed");

            return ApiResponse<TeamMemberDto>.Error(HttpStatusCode.BadRequest, "Block not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Block Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Block Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the Block");
        }
        public async Task<ApiResponse<IQueryable<TeamMemberDto>>> GetAll()
        {
            var Blocks = _context.Blocks.Include("").AsNoTracking().ToList();
            if (Blocks.Count > 0)
            {
                var TeamMemberDtos = _mapper.Map<IQueryable<TeamMemberDto>>(Blocks);
                return ApiResponse<IQueryable<TeamMemberDto>>.Success(TeamMemberDtos);
            }

            return ApiResponse<IQueryable<TeamMemberDto>>.Error(HttpStatusCode.BadRequest, "No Block Found");



        }
        public async Task<ApiResponse<TeamMemberDto>> GetByIdAsync(int id)
        {
            var block = await _context.Blocks.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (block == null)
                return ApiResponse<TeamMemberDto>.Error(HttpStatusCode.BadRequest, "Block Not Found");


            var TeamMemberDto = _mapper.Map<TeamMemberDto>(block);
            return ApiResponse<TeamMemberDto>.Success(TeamMemberDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, TeamMemberDto TeamMemberDto)
        {
            var ExsitBlock = await _context.Blocks.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitBlock is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Block Not Found");
            var UpdateBlock = _mapper.Map(TeamMemberDto, ExsitBlock);

            _context.Blocks.Update(UpdateBlock);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Block Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Block");


        }
    }
}
