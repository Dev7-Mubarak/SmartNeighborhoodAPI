using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class FamilyTypeService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public FamilyTypeService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<ApiResponse<FamilyTypeDto>> AddAsync(FamilyTypeDto FamilyTypeDto)
        {

            var fmilyType = _mapper.Map<FamilyTypeDto>(FamilyTypeDto);
            var FamilyType = _mapper.Map<FamilyType>(fmilyType);

            await _context.AddAsync(FamilyType);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<FamilyTypeDto>.Success(fmilyType, "Added Successed");

            return ApiResponse<FamilyTypeDto>.Error(HttpStatusCode.BadRequest, "FamilyType not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "FamilyType Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("FamilyType Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the FamilyType");
        }
        public async Task<ApiResponse<IQueryable<FamilyTypeDto>>> GetAll()
        {
            var FamilyTypes = _context.FamilyTypes.Include("").AsNoTracking().ToList();
            if (FamilyTypes.Count > 0)
            {
                var FamilyTypeDtos = _mapper.Map<IQueryable<FamilyTypeDto>>(FamilyTypes);
                return ApiResponse<IQueryable<FamilyTypeDto>>.Success(FamilyTypeDtos);
            }

            return ApiResponse<IQueryable<FamilyTypeDto>>.Error(HttpStatusCode.BadRequest, "No FamilyType Found");



        }
        public async Task<ApiResponse<FamilyTypeDto>> GetByIdAsync(int id)
        {
            var FamilyType = await _context.FamilyTypes.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (FamilyType == null)
                return ApiResponse<FamilyTypeDto>.Error(HttpStatusCode.BadRequest, "FamilyType Not Found");


            var FamilyTypeDto = _mapper.Map<FamilyTypeDto>(FamilyType);
            return ApiResponse<FamilyTypeDto>.Success(FamilyTypeDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, FamilyTypeDto FamilyTypeDto)
        {
            var ExsitFamilyType = await _context.FamilyTypes.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitFamilyType is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "FamilyType Not Found");
            var UpdateFamilyType = _mapper.Map(FamilyTypeDto, ExsitFamilyType);

            _context.FamilyTypes.Update(UpdateFamilyType);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("FamilyType Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update FamilyType");


        }
    }
}
