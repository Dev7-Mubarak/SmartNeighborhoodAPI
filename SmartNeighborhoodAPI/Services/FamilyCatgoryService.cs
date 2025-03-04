using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class FamilyCatgoryService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public FamilyCatgoryService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<FamilyCatgoryDto>> AddAsync(FamilyCatgoryDto FamilyCatgoryDto)
        {

            var familyCatgory = _mapper.Map<FamilyCatgoryDto>(FamilyCatgoryDto);
            var FamilyCatgory = _mapper.Map<FamilyCatgory>(familyCatgory);

            await _context.AddAsync(FamilyCatgory);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<FamilyCatgoryDto>.Success(familyCatgory, "Added Successed");

            return ApiResponse<FamilyCatgoryDto>.Error(HttpStatusCode.BadRequest, "FamilyCatgory not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "FamilyCatgory Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("FamilyCatgory Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the FamilyCatgory");
        }
        public async Task<ApiResponse<IQueryable<FamilyCatgoryDto>>> GetAll()
        {
            var FamilyCatgorys = _context.FamilyCatgories.Include("").AsNoTracking().ToList();
            if (FamilyCatgorys.Count > 0)
            {
                var FamilyCatgoryDtos = _mapper.Map<IQueryable<FamilyCatgoryDto>>(FamilyCatgorys);
                return ApiResponse<IQueryable<FamilyCatgoryDto>>.Success(FamilyCatgoryDtos);
            }

            return ApiResponse<IQueryable<FamilyCatgoryDto>>.Error(HttpStatusCode.BadRequest, "No FamilyCatgory Found");



        }
        public async Task<ApiResponse<FamilyCatgoryDto>> GetByIdAsync(int id)
        {
            var FamilyCatgory = await _context.FamilyCatgories.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (FamilyCatgory == null)
                return ApiResponse<FamilyCatgoryDto>.Error(HttpStatusCode.BadRequest, "FamilyCatgory Not Found");


            var FamilyCatgoryDto = _mapper.Map<FamilyCatgoryDto>(FamilyCatgory);
            return ApiResponse<FamilyCatgoryDto>.Success(FamilyCatgoryDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, FamilyCatgoryDto FamilyCatgoryDto)
        {
            var ExsitFamilyCatgory = await _context.FamilyCatgories.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitFamilyCatgory is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "FamilyCatgory Not Found");
            var UpdateFamilyCatgory = _mapper.Map(FamilyCatgoryDto, ExsitFamilyCatgory);

            _context.FamilyCatgories.Update(UpdateFamilyCatgory);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("FamilyCatgory Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update FamilyCatgory");


        }
    }
}
