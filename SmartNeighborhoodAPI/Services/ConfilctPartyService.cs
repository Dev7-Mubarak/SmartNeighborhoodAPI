using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class ConfilctPartyService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public ConfilctPartyService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<ConfilctPartyDto>> AddAsync(ConfilctPartyDto ConfilctPartyDto)
        {

            var confilctParty = _mapper.Map<ConfilctPartyDto>(ConfilctPartyDto);
            var ConfilctParty = _mapper.Map<ConfilctParty>(confilctParty);

            await _context.AddAsync(ConfilctParty);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<ConfilctPartyDto>.Success(confilctParty, "Added Successed");

            return ApiResponse<ConfilctPartyDto>.Error(HttpStatusCode.BadRequest, "ConfilctParty not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ConfilctParty Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("ConfilctParty Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the ConfilctParty");
        }
        public async Task<ApiResponse<IQueryable<ConfilctPartyDto>>> GetAll()
        {
            var ConfilctPartys = _context.ConfilctParties.Include("").AsNoTracking().ToList();
            if (ConfilctPartys.Count > 0)
            {
                var ConfilctPartyDtos = _mapper.Map<IQueryable<ConfilctPartyDto>>(ConfilctPartys);
                return ApiResponse<IQueryable<ConfilctPartyDto>>.Success(ConfilctPartyDtos);
            }

            return ApiResponse<IQueryable<ConfilctPartyDto>>.Error(HttpStatusCode.BadRequest, "No ConfilctParty Found");



        }
        public async Task<ApiResponse<ConfilctPartyDto>> GetByIdAsync(int id)
        {
            var ConfilctParty = await _context.ConfilctParties.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (ConfilctParty == null)
                return ApiResponse<ConfilctPartyDto>.Error(HttpStatusCode.BadRequest, "ConfilctParty Not Found");


            var ConfilctPartyDto = _mapper.Map<ConfilctPartyDto>(ConfilctParty);
            return ApiResponse<ConfilctPartyDto>.Success(ConfilctPartyDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, ConfilctPartyDto ConfilctPartyDto)
        {
            var ExsitConfilctParty = await _context.ConfilctParties.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitConfilctParty is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "ConfilctParty Not Found");
            var UpdateConfilctParty = _mapper.Map(ConfilctPartyDto, ExsitConfilctParty);

            _context.ConfilctParties.Update(UpdateConfilctParty);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("ConfilctParty Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update ConfilctParty");


        }
    }
}
