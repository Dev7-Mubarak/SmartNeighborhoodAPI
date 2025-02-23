using Microsoft.AspNetCore.Identity;
using SmartNeighborhoodAPI.Entites;
using SmartNeighborhoodAPI.Helpers.DTOs;

namespace SmartNeighborhoodAPI.Services
{

    public class UserServices
    {
        #region Fields

        private readonly UserManager<AppUser> _userManager;

        #endregion

        #region Constructor
        public UserServices(UserManager<AppUser> userManager)
        {
                _userManager = userManager;
        }
        #endregion

        #region Method


        public async Task<ApiResponse<UserResponse>> Register(RegisterDto registerDto)
        {

            var existUser = await _userManager.FindByEmailAsync(registerDto.Email);
            if (existUser != null)
                return ApiResponse<UserResponse>.Error(400, "This Email Is Already Exist");

            AppUser user = new()
            {
                UserName = registerDto.Email,
                Email = registerDto.Email,
                IsActive = true,
                Gender = registerDto.Gender,
                Age = registerDto.Age

            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (result.Succeeded)
            {
                return ApiResponse<UserResponse>.Success( new UserResponse
                {
                    Id = user.Id,
                    Email = user.Email
                }, "User Created Successfully");
            }
            else
            {
                return ApiResponse<UserResponse>.Error(400, "User Creation Failed");
            }
        }
        public async Task<ApiResponse<UserResponse>> Login(LoginDto loginDto)
        {

            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
            {
                return ApiResponse<UserResponse>.Error(404, "User Not Found");
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!isPasswordValid)
            {
                return ApiResponse<UserResponse>.Error(401, "Unauthorized");
            }

            var userResponse = new UserResponse
            {
                Id = user.Id,
                Email = user.Email
            };

            return ApiResponse<UserResponse>.Success(userResponse, "User login successfully");

        }
        public async Task<ApiResponse<bool>> IsUserExistByEmail(string Email)
        {
            
             var resulte =  await _userManager.FindByEmailAsync(Email);
             if(resulte  == null)
                return ApiResponse<bool>.Error(404,"User Not Found");

            return ApiResponse<bool>.Success(true, "User Not Found");
        }

        #endregion
    }
}
