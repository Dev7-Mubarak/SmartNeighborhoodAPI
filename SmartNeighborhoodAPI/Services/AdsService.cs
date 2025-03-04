using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class AdsService
    {
        private readonly ApplicationDbContext _context;
        readonly IMapper _mapper;

        public AdsService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResponse<AdDto>> AddAsync(AdDto AdDto)
        {

            var ad = _mapper.Map<AdDto>(AdDto);
            var Ad = _mapper.Map<Ad>(ad);

            await _context.AddAsync(Ad);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<AdDto>.Success(ad, "Added Successed");

            return ApiResponse<AdDto>.Error(HttpStatusCode.BadRequest, "Ad not add");


        }
        public async Task<ApiResponse<string>> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Ad Not Found");

            _context.Remove(entity);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Ad Deleted Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Delete the Ad");
        }
        public async Task<ApiResponse<IQueryable<AdDto>>> GetAll()
        {
            var Ads = _context.Ads.Include("").AsNoTracking().ToList();
            if (Ads.Count > 0)
            {
                var AdDtos = _mapper.Map<IQueryable<AdDto>>(Ads);
                return ApiResponse<IQueryable<AdDto>>.Success(AdDtos);
            }

            return ApiResponse<IQueryable<AdDto>>.Error(HttpStatusCode.BadRequest, "No Ad Found");



        }
        public async Task<ApiResponse<AdDto>> GetByIdAsync(int id)
        {
            var Ad = await _context.Ads.Include("").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (Ad == null)
                return ApiResponse<AdDto>.Error(HttpStatusCode.BadRequest, "Ad Not Found");


            var AdDto = _mapper.Map<AdDto>(Ad);
            return ApiResponse<AdDto>.Success(AdDto);
        }
        public async Task<ApiResponse<string>> UpdateAsync(int id, AdDto AdDto)
        {
            var ExsitAd = await _context.Ads.FirstOrDefaultAsync(x => x.Id == id);

            if (ExsitAd is null)
                return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Ad Not Found");
            var UpdateAd = _mapper.Map(AdDto, ExsitAd);

            _context.Ads.Update(UpdateAd);
            if (await _context.SaveChangesAsync() > 0)
                return ApiResponse<string>.Success("Ad Updated Successfully");

            return ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Faild To Update Ad");


        }
    }
}
