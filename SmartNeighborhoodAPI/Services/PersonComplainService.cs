using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class PersonComplainService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public PersonComplainService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<ApiResponse<PersonComplainDto>> AddAsync(PersonComplainDto PersonComplainDto)
        {

            var personComplain = _mapper.Map<PersonComplainDto>(PersonComplainDto);
            var PersonComplain = _mapper.Map<PersonComplain>(personComplain);

            await _context.AddAsync(PersonComplain);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<PersonComplainDto>.Success(personComplain, "Added Successed");

            return ApiResponse<PersonComplainDto>.Error(HttpStatusCode.BadRequest, "PersonComplain not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "PersonComplain Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("PersonComplain Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the PersonComplain");
        }
        public async Task<ApiResponse<IQueryable<PersonComplainDto>>> GetAll()
        {
            var PersonComplains = _context.PersonComplains.Include("").AsNoTracking().ToList();
            if (PersonComplains.Count > 0)
            {
                var PersonComplainDtos = _mapper.Map<IQueryable<PersonComplainDto>>(PersonComplains);
                return ApiResponse<IQueryable<PersonComplainDto>>.Success(PersonComplainDtos);
            }

            return ApiResponse<IQueryable<PersonComplainDto>>.Error(HttpStatusCode.BadRequest, "No PersonComplain Found");



        }
        public async Task<ApiResponse<PersonComplainDto>> GetByIdAsync(int id)
        {
            var PersonComplain = await _context.PersonComplains.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (PersonComplain == null)
                return ApiResponse<PersonComplainDto>.Error(HttpStatusCode.BadRequest, "PersonComplain Not Found");


            var PersonComplainDto = _mapper.Map<PersonComplainDto>(PersonComplain);
            return ApiResponse<PersonComplainDto>.Success(PersonComplainDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, PersonComplainDto PersonComplainDto)
        {
            var ExsitPersonComplain = await _context.PersonComplains.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitPersonComplain is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "PersonComplain Not Found");
            var UpdatePersonComplain = _mapper.Map(PersonComplainDto, ExsitPersonComplain);

            _context.PersonComplains.Update(UpdatePersonComplain);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("PersonComplain Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update PersonComplain");


        }
    }
}
