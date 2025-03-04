using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class FamilyService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public FamilyService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<FamilyDto>> AddAsync(FamilyDto FamilyDto)
        {

            var famliy = _mapper.Map<FamilyDto>(FamilyDto);
            var Family = _mapper.Map<Family>(famliy);

            await _context.AddAsync(Family);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<FamilyDto>.Success(famliy, "Added Successed");

            return ApiResponse<FamilyDto>.Error(HttpStatusCode.BadRequest, "Block not add");


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
        public async Task<ApiResponse<IQueryable<FamilyDto>>> GetAll()
        {
            var Family = _context.Families.Include("").AsNoTracking().ToList();
            if (Family.Count > 0)
            {
                var FamilyDtos = _mapper.Map<IQueryable<FamilyDto>>(Family);
                return ApiResponse<IQueryable<FamilyDto>>.Success(FamilyDtos);
            }

            return ApiResponse<IQueryable<FamilyDto>>.Error(HttpStatusCode.BadRequest, "No Block Found");



        }
        public async Task<ApiResponse<FamilyDto>> GetByIdAsync(int id)
        {
            var family = await _context.Families.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (family == null)
                return ApiResponse<FamilyDto>.Error(HttpStatusCode.BadRequest, "Block Not Found");


            var FamilyDto = _mapper.Map<FamilyDto>(family);
            return ApiResponse<FamilyDto>.Success(FamilyDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, FamilyDto FamilyDto)
        {
            var ExsitBlock = await _context.Families.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitBlock is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Block Not Found");
            var UpdateBlock = _mapper.Map(FamilyDto, ExsitBlock);

            _context.Families.Update(UpdateBlock);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Block Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Block");


        }
    }
}
