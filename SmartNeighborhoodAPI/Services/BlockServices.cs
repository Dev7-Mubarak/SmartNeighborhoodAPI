using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class BlockServices
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public BlockServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<BlockDto>> AddAsync(BlockDto blockDto)
        {

            var block = _mapper.Map<BlockDto>(blockDto);
            var Block = _mapper.Map<Block>(block);

            await _context.AddAsync(Block);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<BlockDto>.Success(block, "Added Successed");

            return ApiResponse<BlockDto>.Error(HttpStatusCode.BadRequest, "Block not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.NotFound, "Block Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Block Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the Block");
        }
        public async Task<ApiResponse<IQueryable<BlockDto>>> GetAll()
        {
            var Blocks = _context.Blocks.Include("").AsNoTracking().ToList();
            if (Blocks.Count > 0)
            {
                var BlockDtos = _mapper.Map<IQueryable<BlockDto>>(Blocks);
                return ApiResponse<IQueryable<BlockDto>>.Success(BlockDtos);
            }

            return ApiResponse<IQueryable<BlockDto>>.Error(HttpStatusCode.BadRequest, "No Block Found");

        }
        public async Task<ApiResponse<BlockDto>> GetByIdAsync(int id)
        {
            var block = await _context.Blocks.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (block == null)
                return ApiResponse<BlockDto>.Error(HttpStatusCode.BadRequest, "Block Not Found");


            var BlockDto = _mapper.Map<BlockDto>(block);
            return ApiResponse<BlockDto>.Success(BlockDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, BlockDto blockDto)
        {
            var ExsitBlock = await _context.Blocks.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitBlock is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Block Not Found");
            var UpdateBlock = _mapper.Map(blockDto, ExsitBlock);

            _context.Blocks.Update(UpdateBlock);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Block Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Block");


        }
    }
}
