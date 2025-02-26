using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartNeighborhoodAPI.Entites;
using SmartNeighborhoodAPI.Helpers;
using SmartNeighborhoodAPI.Helpers.DTOs;
using SmartNeighborhoodAPI.Services;

namespace SmartNeighborhoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserServices _userServices;
        private readonly UserManager<IdentityUser> _userManger;
        private readonly IWebHostEnvironment _webHost;
        private readonly string _imagePath;

        public AuthController(UserManager<IdentityUser> userManger, IWebHostEnvironment webHost, UserServices userServices)
        {
            _userManger = userManger;
            _webHost = webHost;
            _imagePath = _webHost.WebRootPath + FileSetting.UsersImagesPath;
            _userServices = userServices;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            }

            var resulte = await _userServices.Login(loginDto);
            if (resulte.IsSuccess)
                return Ok(resulte);

            return BadRequest(resulte);
        }

        //[HttpPost("[action]")]
        //public async Task<IActionResult> Register(RegisterDto registerDto)
        //{

        //    if (IsUserExistByEmail(registerDto.Email).Result.Value)
        //        return BadRequest("This Email Is Already Exist");

        //    AppUser user = new()
        //    {
        //        UserName = registerDto.UserName,
        //        Email = registerDto.Email
        //    };

        //    if (registerDto.PorfileImageUrl != null)
        //    {
        //        var fileResult = await Utilities.SaveFileAsync(registerDto.PorfileImageUrl, _imagePath);

        //        if (fileResult.Succeeded)
        //            user.Image = fileResult.FileName;
        //    }


        //    var resulte = await _userServices.Register(registerDto);
        //    if (resulte.IsSuccess)
        //        return Ok(resulte);

        //    return BadRequest(resulte);


        //}

        [HttpGet("IsUserExist")]
        public async Task<ActionResult<bool>> IsUserExistByEmail(string Email)
        {
            var resulte = await _userServices.IsUserExistByEmail(Email);
            if (resulte.IsSuccess)
                return Ok(resulte);

            return BadRequest(resulte);
        }


    }
}
