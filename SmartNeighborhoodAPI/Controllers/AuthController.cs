using Microsoft.AspNetCore.Identity;
using SmartNeighborhoodAPI.Entites;
using System.Net;

namespace SmartNeighborhoodAPI.Controllers
{
    public class AuthController : AppControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AuthService _authService;

        public AuthController(UserManager<AppUser> userManager, AuthService authService)
        {
            _userManager = userManager;
            _authService = authService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ValidationHelper.CreateErrorResponse(ModelState));
            }

            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
            {
                return NotFound(ApiResponse<string>.Error(HttpStatusCode.BadRequest, "User Not Found"));
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!isPasswordValid)
            {
                return Unauthorized(ApiResponse<string>.Error(HttpStatusCode.BadRequest, "Unauthorized"));
            }

            var userResponse = new UserResponse
            {
                Id = user.Id,
                Email = user.Email
            };

            return Ok(ApiResponse<UserResponse>.Success(userResponse, "User login successfully"));
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterDto registerDto) => Response(await _authService.Register(registerDto));

    }
}
