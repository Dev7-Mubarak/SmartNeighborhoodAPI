using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class MemberTypeService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;


        public MemberTypeService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<MemberTypeDto>> AddAsync(MemberTypeDto MemberTypeDto)
        {

            var block = _mapper.Map<MemberTypeDto>(MemberTypeDto);
            var Block = _mapper.Map<Block>(block);

            await _context.AddAsync(Block);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<MemberTypeDto>.Success(block, "Added Successed");

            return ApiResponse<MemberTypeDto>.Error(HttpStatusCode.BadRequest, "Block not add");


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
        public async Task<ApiResponse<IQueryable<MemberTypeDto>>> GetAll()
        {
            var Blocks = _context.Blocks.Include("").AsNoTracking().ToList();
            if (Blocks.Count > 0)
            {
                var MemberTypeDtos = _mapper.Map<IQueryable<MemberTypeDto>>(Blocks);
                return ApiResponse<IQueryable<MemberTypeDto>>.Success(MemberTypeDtos);
            }

            return ApiResponse<IQueryable<MemberTypeDto>>.Error(HttpStatusCode.BadRequest, "No Block Found");



        }
        public async Task<ApiResponse<MemberTypeDto>> GetByIdAsync(int id)
        {
            var block = await _context.Blocks.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (block == null)
                return ApiResponse<MemberTypeDto>.Error(HttpStatusCode.BadRequest, "Block Not Found");


            var MemberTypeDto = _mapper.Map<MemberTypeDto>(block);
            return ApiResponse<MemberTypeDto>.Success(MemberTypeDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, MemberTypeDto MemberTypeDto)
        {
            var ExsitBlock = await _context.Blocks.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitBlock is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Block Not Found");
            var UpdateBlock = _mapper.Map(MemberTypeDto, ExsitBlock);

            _context.Blocks.Update(UpdateBlock);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Block Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Block");


        }
    }
}
