
//using System.Net;

//public class ProjectService
//{
//    private readonly IMapper _mapper;
//    private readonly ApplicationDbContext _context;

//    public ProjectService(IMapper mapper, ApplicationDbContext context)
//    {
//        _mapper = mapper;
//        _context = context;
//    }


//    public async Task<ApiResponse<string>> AddAsync(ProjectDto projectDto)
//    {
//        var Project = _mapper.Map<Project>(projectDto);
//        await _context.Projects.AddAsync(Project);
//        if (await _context.SaveChangesAsync() > 0)
//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Failed To Add Project");
//        return ApiResponse<string>.Success("Added Succeseed");
//    }
//    public async Task<ApiResponse<IEnumerable<ProjectDto>>> GetAllAsync()
//    {
//        var Projects = await _context.Projects.AsNoTracking().ToListAsync();
//        var ProjectsDto = _mapper.Map<List<ProjectDto>>(Projects);
//        if (ProjectsDto == null)
//            return ApiResponse<IEnumerable<ProjectDto>>.Error(HttpStatusCode.BadRequest, "Not Data Found");

//        return ApiResponse<IEnumerable<ProjectDto>>.Success(ProjectsDto);

//    }
//    public async Task<ApiResponse<ProjectDto>> GetByIdAsync(int id, ProjectDto projectDto)
//    {
//        var Project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);
//        if (Project is null)
//            return ApiResponse<ProjectDto>.Error(HttpStatusCode.BadRequest, "Not found");
//        var ProjectDto = _mapper.Map<Project>(projectDto);

//        return ApiResponse<ProjectDto>.Success(projectDto);
//    }
//    public async Task<ApiResponse<string>> UpdateAsync(int id, ProjectDto projectDto)
//    {
//        var ExistsProject = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);
//        if (ExistsProject is null)
//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Project Not Found");

//        var ProjectDto = _mapper.Map(projectDto, ExistsProject);

//        _context.Projects.Update(ProjectDto);
//        if (await _context.SaveChangesAsync() > 0)
//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Failed To Update Project");

//        return ApiResponse<string>.Success("Update succed");
//    }
//    public async Task<ApiResponse<string>> DeleteAsync(int id)
//    {
//        var Project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

//        if (Project is null)
//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Project Not Found");

//        _context.Projects.Remove(Project);
//        if (_context.SaveChanges() >= 0)
//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Failed To Delete Project");

//        return ApiResponse<string>.Success("Project Deleted Succesfully");
//    }
//}