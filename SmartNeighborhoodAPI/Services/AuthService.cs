using Microsoft.AspNetCore.Identity;
using SmartNeighborhoodAPI.Entites;
using System.Net;

namespace SmartNeighborhoodAPI.Services
{
    public class AuthService
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApiResponse<UserResponse>> Register(RegisterDto registerDto)
        {
            if (await _userManager.FindByEmailAsync(registerDto.Email) is not null)
                return ApiResponse<UserResponse>.Error(HttpStatusCode.Conflict, "User with this email already exists.");

            AppUser user = new()
            {
                Email = registerDto.Email,
                UserName = registerDto.Email,
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                return ApiResponse<UserResponse>.Error(HttpStatusCode.BadRequest, "Error acourse will create the user");
            }

            UserResponse userResponse = new()
            {
                Id = user.Id,
                Email = user.Email,
            };

            return ApiResponse<UserResponse>.Success(userResponse, "User registered successfully.");
        }
    }
}
