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
            if (ModelState.IsValid)
            {
                var user = await _userManger.FindByEmailAsync(loginDto.Email);

                if (user != null)
                {
                    if (await _userManger.CheckPasswordAsync(user, loginDto.Password))
                        return Ok();
                    else
                        return Unauthorized();
                }
                else
                {
                    ModelState.AddModelError("", "User Name is inviled");
                }
            }

            return BadRequest(ModelState);
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

            // Return User Information
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
