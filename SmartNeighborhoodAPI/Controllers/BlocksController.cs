using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocksController : ControllerBase
    {
        protected IBaseRepository<Block> _BlockRepsitory;
        private readonly IMapper _mapper;
        public BlocksController(IBaseRepository<Block> BlockRepsitory,IMapper mapper)
        {
            _BlockRepsitory = BlockRepsitory;
            _mapper = mapper;
        }
        [HttpPost("action")]
        public async Task<IActionResult>AddAsync(BlockDto blockDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var block = _mapper.Map<BlockDto>(blockDto);

            var result = await _BlockRepsitory.AddAsync(block);
            if (result <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Faild To Add Block"));
            return Ok(ApiResponse<Block>.Success(block));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult>GetAllAsync()
        {
            var Blocks =await  _BlockRepsitory.GetAll().ToListAsync();

            var BlockDtos = _mapper.Map<List<BlockDto>>(Blocks);
            return Ok(ApiResponse<List<BlockDto>>.Success(BlockDtos));


        }
        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult>GetByIdAsync(int id)
        {
            var Block = await _BlockRepsitory.GetByIdAsync(id);
            if (Block is null)
                return NotFound(ApiResponse<string>.Error(500,"Block Not Found"));

            var BlockDto = _mapper.Map<BlockDto>(Block);

            return Ok(ApiResponse<BlockDto>.Success(BlockDto));

        }
        [HttpPut("[action]/{id:int}")]
        public async Task<IActionResult>UpdateAsync(int id,BlockDto blockDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));

            var ExsitBlock = await _BlockRepsitory.GetByIdAsync(id);

            if (ExsitBlock is null)
                return NotFound(ApiResponse<string>.Error(404, "Block Not Found"));
            var UpdateBlock = _mapper.Map(blockDto,ExsitBlock);

            var result =await  _BlockRepsitory.UpdateAsync(UpdateBlock);
            if (result <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Faild To Update Block"));
            return Ok(ApiResponse<Block>.Success(UpdateBlock));
        }

        [HttpDelete("[action]{id:int}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var Block =await  _BlockRepsitory.GetByIdAsync(id);

            if (Block is null)
                return NotFound(ApiResponse<string>.Error(404, "Block Not Found"));

            var result = await _BlockRepsitory.DeleteAsync(Block);
            if (result <= 0)
                return BadRequest(ApiResponse<string>.Error(500, "Faild To Delete the Block"));
            return Ok(ApiResponse<string>.Success("Block Deleted Successfully."));
        }
    }

}
  