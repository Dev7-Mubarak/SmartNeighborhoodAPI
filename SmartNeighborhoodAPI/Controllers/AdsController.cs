


//using SmartNeighborhoodAPI.Helpers;

//namespace SmartNeighborhoodAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AdsController : ControllerBase
//    {
//        protected IBaseRepository<Ad> _AdRepository;

//        private readonly IMapper _mapper;
//        public AdsController(IBaseRepository<Ad> AdRepository,IMapper mapper)
//        {
//            _AdRepository = AdRepository;
//            _mapper = mapper;
//        }
//        [HttpPost("[action]")]
//        public async Task<IActionResult>AddAsync(AdDto adDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

//            var ad = _mapper.Map<Ad>(adDto);

//            var result =await  _AdRepository.AddAsync(ad);

//            if (result <= 0)
//                return BadRequest(ApiResponse<string>.Error(500, "Faild To Add Advertisment"));

//            return Ok(ApiResponse<Ad>.Success(ad));


//        }

//        [HttpGet("[action]")]
//        public async Task<IActionResult>GetAllAsync()
//        {
//            var Ads =await  _AdRepository.GetAll().ToListAsync();

//            var AdDtos = _mapper.Map <List<AdDto>> (Ads);

//            return Ok(ApiResponse<List<AdDto>>.Success(AdDtos));
//        }


//        [HttpGet("[action]/{id:int}")]
//        public async Task<IActionResult>GetByIdAsync(int id)
//        {
//            var ad = await _AdRepository.GetByIdAsync(id);
//            if (ad is null)
//                return NotFound(ApiResponse<string>.Error(404, "Ad Not Found"));

//            var AdDto = _mapper.Map<AdDto>(ad);

//            return Ok(ApiResponse<AdDto>.Success(AdDto));
//        }

//        [HttpPut("[action]/{id:int}")]
//        public async Task<IActionResult>UpdateAsync(int id,AdDto adDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
//            var ExsitAd = await _AdRepository.GetByIdAsync(id);

//            if (ExsitAd is null)
//                return NotFound(ApiResponse<string>.Error(404, "Ad Not Found");
//            var UpdateAd = _mapper.Map(adDto, ExsitAd);

//            var result =await  _AdRepository.UpdateAsync(UpdateAd);
//            if (result <= 0)
//                return BadRequest(ApiResponse<string>.Error(500, "Faild To Update Ad"));

//            return Ok(ApiResponse<Ad>.Success(UpdateAd));

//        }

//        [HttpDelete("[action]/{id:int}")]
//        public async Task<IActionResult>DeleteAsync(int id)
//        {
//            var Ad = await _AdRepository.GetByIdAsync(id);
//            if (Ad is null)
//                return NotFound(ApiResponse<string>.Error(404, "Ad Not Found"));

//            var result = await _AdRepository.DeleteAsync(Ad);

//            if (result <= 0)
//                return BadRequest(ApiResponse<string>.Error(500,"Faild To Delete Ad"));
//            return Ok(ApiResponse<string>.Success("Block Deleted Succesfully"));

//        }

       
//    }
//}
