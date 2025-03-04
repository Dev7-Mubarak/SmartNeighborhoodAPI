using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class FamilyMemberService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public FamilyMemberService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<FamilyMemberDto>> AddAsync(FamilyMemberDto FamilyMemberDto)
        {

            var familyMember = _mapper.Map<FamilyMemberDto>(FamilyMemberDto);
            var FamilyMember = _mapper.Map<FamilyMember>(familyMember);

            await _context.AddAsync(FamilyMember);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<FamilyMemberDto>.Success(familyMember, "Added Successed");

            return ApiResponse<FamilyMemberDto>.Error(HttpStatusCode.BadRequest, "FamilyMember not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "FamilyMember Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("FamilyMember Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the FamilyMember");
        }
        public async Task<ApiResponse<IQueryable<FamilyMember>>> GetAll()
        {
            var FamilyMembers = _context.FamilyMembers.Include("").AsNoTracking().ToList();
            if (FamilyMembers.Count > 0)
            {
                var FamilyMembersDtos = _mapper.Map<IQueryable<FamilyMember>>(FamilyMembers);
                return ApiResponse<IQueryable<FamilyMember>>.Success(FamilyMembersDtos);
            }

            return ApiResponse<IQueryable<FamilyMember>>.Error(HttpStatusCode.BadRequest, "No FamilyMember Found");



        }
        public async Task<ApiResponse<FamilyMemberDto>> GetByIdAsync(int id)
        {
            var FamilyMember = await _context.FamilyMembers.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (FamilyMember == null)
                return ApiResponse<FamilyMemberDto>.Error(HttpStatusCode.BadRequest, "FamilyMember Not Found");


            var FamilyMemberDto = _mapper.Map<FamilyMemberDto>(FamilyMember);
            return ApiResponse<FamilyMemberDto>.Success(FamilyMemberDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, FamilyMember FamilyMember)
        {
            var ExsitFamilyMember = await _context.FamilyMembers.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitFamilyMember is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "FamilyMember Not Found");
            var UpdateFamilyMember = _mapper.Map(FamilyMember, ExsitFamilyMember);

            _context.FamilyMembers.Update(UpdateFamilyMember);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("FamilyMember Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update FamilyMember");


        }
    }
}
