//using System.Net;

//namespace SmartNeighborhoodAPI.Services
//{
//    public class ComplainTypeService
//    {
//        private readonly ApplicationDbContext _context;
//        readonly IMapper _mapper;

//        public ComplainTypeService(ApplicationDbContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }
//        public async Task<ApiResponse<ComplainTypeDto>> AddAsync(ComplainTypeDto complainTypeDto)
//        {

//            var complainType = _mapper.Map<ComplainTypeDto>(complainTypeDto);
//            var ComplainType = _mapper.Map<ComplainType>(complainType);

//            await _context.AddAsync(ComplainType);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<ComplainTypeDto>.Success(complainType, "Added Successed");

//            return ApiResponse<ComplainTypeDto>.Error(HttpStatusCode.BadRequest, "ComplainType not add");


//        }
//        public async Task<ApiResponse<string>> DeleteAsync(int id)
//        {
//            var entity = await GetByIdAsync(id);
//            if (entity == null)
//                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ComplainType Not Found");

//            _context.Remove(entity);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<string>.Success("ComplainType Deleted Successfully");

//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the ComplainType");
//        }
//        public async Task<ApiResponse<IQueryable<ComplainType>>> GetAll()
//        {
//            var ComplainTypes = _context.ComplainTypes.Include("").AsNoTracking().ToList();
//            if (ComplainTypes.Count > 0)
//            {
//                var ComplainTypesDtos = _mapper.Map<IQueryable<ComplainType>>(ComplainTypes);
//                return ApiResponse<IQueryable<ComplainType>>.Success(ComplainTypesDtos);
//            //}

//            return ApiResponse<IQueryable<ComplainType>>.Error(HttpStatusCode.BadRequest, "No ComplainType Found");



//        }
//        public async Task<ApiResponse<ComplainTypeDto>> GetByIdAsync(int id)
//        {
//            var ComplainType = await _context.ComplainTypes.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
//            if (ComplainType == null)
//                return ApiResponse<ComplainTypeDto>.Error(HttpStatusCode.BadRequest, "ComplainType Not Found");


//            var ComplainTypeDto = _mapper.Map<ComplainTypeDto>(ComplainType);
//            return ApiResponse<ComplainTypeDto>.Success(ComplainTypeDto);
//        }
//        public async Task<ApiResponse<string>> UpdateAsync(int id, ComplainType ComplainType)
//        {
//            var ExsitComplainType = await _context.ComplainTypes.FirstOrDefaultAsync(x => x.Id == id);

//            if (ExsitComplainType is null)
//                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ComplainType Not Found");
//            var UpdateComplainType = _mapper.Map(ComplainType, ExsitComplainType);

//            _context.ComplainTypes.Update(UpdateComplainType);
//            if (await _context.SaveChangesAsync() > 0)
//                return ApiResponse<string>.Success("ComplainType Updated Successfully");

//            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update ComplainType");


//        }
//    }
//}
