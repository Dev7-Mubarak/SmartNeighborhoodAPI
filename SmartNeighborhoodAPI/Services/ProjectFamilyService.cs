//namespace SmartNeighborhoodAPI.Services
//{
//    public class ProjectFamilyService
//    {
//        private readonly ApplicationDbContext _context;
//        readonly IMapper _mapper;

//        public ProjectFamilyService(ApplicationDbContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;

//        }
//        public async Task<ApiResponse<ProjectFamilyDto>> AddAsync(ProjectFamilyDto ProjectFamilyDto)
//        {

//            var projectFamily = _mapper.Map<ProjectFamilyDto>(ProjectFamilyDto);
//            var ProjectFamily = _mapper.Map<ProjectFamily>(projectFamily);

//            await _context.AddAsync(ProjectFamily);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<ProjectFamilyDto>.Success(projectFamily, "Added Successed");

//            return ApiResponse<ProjectFamilyDto>.Error(HttpStatusCode.BadRequest, "ProjectFamily not add");


//        }
//        public async Task<ApiResponse<string>> DeleteAsync(int id)
//        {
//            var entity = await GetByIdAsync(id);
//            if (entity == null)
//                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ProjectFamily Not Found");

//            _context.Remove(entity);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<string>.Success("ProjectFamily Deleted Successfully");

//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the ProjectFamily");
//        }
//        public async Task<ApiResponse<IQueryable<ProjectFamilyDto>>> GetAll()
//        {
//            var ProjectFamilys = _context.ProjectFamilies.Include("").AsNoTracking().ToList();
//            if (ProjectFamilys.Count > 0)
//            {
//                var ProjectFamilyDtos = _mapper.Map<IQueryable<ProjectFamilyDto>>(ProjectFamilys);
//                return ApiResponse<IQueryable<ProjectFamilyDto>>.Success(ProjectFamilyDtos);
//            }

//            return ApiResponse<IQueryable<ProjectFamilyDto>>.Error(HttpStatusCode.BadRequest, "No ProjectFamily Found");



//        }
//        public async Task<ApiResponse<ProjectFamilyDto>> GetByIdAsync(int id)
//        {
//            var ProjectFamily = await _context.ProjectFamilies.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
//            if (ProjectFamily == null)
//                return ApiResponse<ProjectFamilyDto>.Error(HttpStatusCode.BadRequest, "ProjectFamily Not Found");


//            var ProjectFamilyDto = _mapper.Map<ProjectFamilyDto>(ProjectFamily);
//            return ApiResponse<ProjectFamilyDto>.Success(ProjectFamilyDto);
//        }
//        public async Task<ApiResponse<string>> UpdateAsync(int id, ProjectFamilyDto ProjectFamilyDto)
//        {
//            var ExsitProjectFamily = await _context.ProjectFamilies.FirstOrDefaultAsync(x => x.Id == id);

//            if (ExsitProjectFamily is null)
//                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ProjectFamily Not Found");
//            var UpdateProjectFamily = _mapper.Map(ProjectFamilyDto, ExsitProjectFamily);

//            _context.ProjectFamilies.Update(UpdateProjectFamily);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<string>.Success("ProjectFamily Updated Successfully");

//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update ProjectFamily");


//        }
//    }
//}
