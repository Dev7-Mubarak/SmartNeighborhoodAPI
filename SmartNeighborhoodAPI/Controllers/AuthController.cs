using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartNeighborhoodAPI.Helpers;
using SmartNeighborhoodAPI.Helpers.DTOs;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManger;
        private readonly IWebHostEnvironment _webHost;
        private readonly string _imagePath;

        public AuthController(UserManager<IdentityUser> userManger, IWebHostEnvironment webHost)
        {
            _userManger = userManger;
            _webHost = webHost;
            _imagePath = _webHost.WebRootPath + FileSetting.UsersImagesPath;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                // refactor this setion
                var fieldErrors = ModelState.Keys.SelectMany(key =>
                {
                    var errorMessages = ModelState[key].Errors.Select(e => new FieldError(key, e.ErrorMessage)).ToList();
                    return errorMessages;
                }).ToList();

                return BadRequest(ApiResponse<object>.Error("Model validation failed", 400, fieldErrors));
            }

            var user = await _userManger.FindByEmailAsync(loginDto.Email);

            if (user == null)
            {
                return BadRequest(ApiResponse<object>.Error("User not found", 400));
            }

            var isPasswordValid = await _userManger.CheckPasswordAsync(user, loginDto.Password);

            if (!isPasswordValid)
            {
                return Unauthorized(ApiResponse<object>.Error("Invalid password", 401));
            }

            var userResponse = new UserResponse
            {
                Id = user.Email,
                Email = user.Email,
            };

            return Ok(ApiResponse<UserResponse>.Success(userResponse, "User login success"));
        }




        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {

            if (IsUserExistByEmail(registerDto.Email).Result.Value)
                return BadRequest("This Email Is Already Exist");

            IdentityUser user = new()
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email
            };

            //if (registerDto.PorfileImageUrl != null)
            //{
            //    var fileResult = await Utilities.SaveFileAsync(registerDto.PorfileImageUrl, _imagePath);

            //    if (fileResult.Succeeded)
            //        user.PorfileImageUrl = fileResult.FileName;
            //}

            IdentityResult result = await _userManger.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
                return BadRequest();

            UserDto userDto = new()
            {
                DisplayName = registerDto.UserName,
                Email = registerDto.Email,
            };

            return Ok(userDto);
        }


        [HttpGet("IsUserExist")]
        public async Task<ActionResult<bool>> IsUserExistByEmail(string Email)
        {
            return await _userManger.FindByEmailAsync(Email) is not null;
        }


    }
}
