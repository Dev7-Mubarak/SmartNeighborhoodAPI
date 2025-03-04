using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class PersonService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public PersonService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<PersonDto>> AddAsync(PersonDto PersonDto)
        {

            var person = _mapper.Map<PersonDto>(PersonDto);
            var Person = _mapper.Map<Person>(person);

            await _context.AddAsync(Person);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<PersonDto>.Success(person, "Added Successed");

            return ApiResponse<PersonDto>.Error(HttpStatusCode.BadRequest, "Person not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Person Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Person Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the Person");
        }
        public async Task<ApiResponse<IQueryable<PersonDto>>> GetAll()
        {
            var Persons = _context.People.Include("").AsNoTracking().ToList();
            if (Persons.Count > 0)
            {
                var PersonDtos = _mapper.Map<IQueryable<PersonDto>>(Persons);
                return ApiResponse<IQueryable<PersonDto>>.Success(PersonDtos);
            }

            return ApiResponse<IQueryable<PersonDto>>.Error(HttpStatusCode.BadRequest, "No Person Found");



        }
        public async Task<ApiResponse<PersonDto>> GetByIdAsync(int id)
        {
            var Person = await _context.People.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (Person == null)
                return ApiResponse<PersonDto>.Error(HttpStatusCode.BadRequest, "Person Not Found");


            var PersonDto = _mapper.Map<PersonDto>(Person);
            return ApiResponse<PersonDto>.Success(PersonDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, PersonDto PersonDto)
        {
            var ExsitPerson = await _context.People.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitPerson is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Person Not Found");
            var UpdatePerson = _mapper.Map(PersonDto, ExsitPerson);

            _context.People.Update(UpdatePerson);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Person Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Person");


        }
    }
}
