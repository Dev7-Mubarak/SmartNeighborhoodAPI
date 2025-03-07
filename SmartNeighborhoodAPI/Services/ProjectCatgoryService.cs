//using System.Net;

//namespace SmartNeighborhoodAPI.Services
//{
//    public class ProjectCatgoryService
//    {
//        private readonly ApplicationDbContext _context;
//        readonly IMapper _mapper;

//        public ProjectCatgoryService(ApplicationDbContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }
//        public async Task<ApiResponse<ProjectCatgoryDto>> AddAsync(ProjectCatgoryDto ProjectCatgoryDto)
//        {

//            var projectCatgory = _mapper.Map<ProjectCatgoryDto>(ProjectCatgoryDto);
//            var ProjectCatgory = _mapper.Map<ProjectCatogory>(projectCatgory);

//            await _context.AddAsync(ProjectCatgory);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<ProjectCatgoryDto>.Success(projectCatgory, "Added Successed");

//            return ApiResponse<ProjectCatgoryDto>.Error(HttpStatusCode.BadRequest, "ProjectCatgory not add");


//        }
//        public async Task<ApiResponse<string>> DeleteAsync(int id)
//        {
//            var entity = await GetByIdAsync(id);
//            if (entity == null)
//                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ProjectCatgory Not Found");

//            _context.Remove(entity);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<string>.Success("ProjectCatgory Deleted Successfully");

//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the ProjectCatgory");
//        }
//        public async Task<ApiResponse<IQueryable<ProjectCatgoryDto>>> GetAll()
//        {
//            var ProjectCatgorys = _context.ProjectCatogories.Include("").AsNoTracking().ToList();
//            if (ProjectCatgorys.Count > 0)
//            {
//                var ProjectCatgoryDtos = _mapper.Map<IQueryable<ProjectCatgoryDto>>(ProjectCatgorys);
//                return ApiResponse<IQueryable<ProjectCatgoryDto>>.Success(ProjectCatgoryDtos);
//            }

//            return ApiResponse<IQueryable<ProjectCatgoryDto>>.Error(HttpStatusCode.BadRequest, "No ProjectCatgory Found");



//        }
//        public async Task<ApiResponse<ProjectCatgoryDto>> GetByIdAsync(int id)
//        {
//            var ProjectCatgory = await _context.ProjectCatogories.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
//            if (ProjectCatgory == null)
//                return ApiResponse<ProjectCatgoryDto>.Error(HttpStatusCode.BadRequest, "ProjectCatgory Not Found");


//            var ProjectCatgoryDto = _mapper.Map<ProjectCatgoryDto>(ProjectCatgory);
//            return ApiResponse<ProjectCatgoryDto>.Success(ProjectCatgoryDto);
//        }
//        public async Task<ApiResponse<string>> UpdateAsync(int id, ProjectCatgoryDto ProjectCatgoryDto)
//        {
//            var ExsitProjectCatgory = await _context.ProjectCatogories.FirstOrDefaultAsync(x => x.Id == id);

//            if (ExsitProjectCatgory is null)
//                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ProjectCatgory Not Found");
//            var UpdateProjectCatgory = _mapper.Map(ProjectCatgoryDto, ExsitProjectCatgory);

//            _context.ProjectCatogories.Update(UpdateProjectCatgory);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<string>.Success("ProjectCatgory Updated Successfully");

//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update ProjectCatgory");


//        }
//    }
//}
