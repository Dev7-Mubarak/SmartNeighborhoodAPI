using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class GroupService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public GroupService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<ApiResponse<GroupDto>> AddAsync(GroupDto GroupDto)
        {

            var group = _mapper.Map<GroupDto>(GroupDto);
            var Group = _mapper.Map<Group>(group);

            await _context.AddAsync(Group);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<GroupDto>.Success(group, "Added Successed");

            return ApiResponse<GroupDto>.Error(HttpStatusCode.BadRequest, "Group not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Group Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Group Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the Group");
        }
        public async Task<ApiResponse<IQueryable<GroupDto>>> GetAll()
        {
            var Groups = _context.Groups.Include("").AsNoTracking().ToList();
            if (Groups.Count > 0)
            {
                var GroupDtos = _mapper.Map<IQueryable<GroupDto>>(Groups);
                return ApiResponse<IQueryable<GroupDto>>.Success(GroupDtos);
            }

            return ApiResponse<IQueryable<GroupDto>>.Error(HttpStatusCode.BadRequest, "No Group Found");



        }
        public async Task<ApiResponse<GroupDto>> GetByIdAsync(int id)
        {
            var Group = await _context.Groups.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (Group == null)
                return ApiResponse<GroupDto>.Error(HttpStatusCode.BadRequest, "Group Not Found");


            var GroupDto = _mapper.Map<GroupDto>(Group);
            return ApiResponse<GroupDto>.Success(GroupDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, GroupDto GroupDto)
        {
            var ExsitGroup = await _context.Groups.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitGroup is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Group Not Found");
            var UpdateGroup = _mapper.Map(GroupDto, ExsitGroup);

            _context.Groups.Update(UpdateGroup);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Group Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Group");


        }
    }
}
