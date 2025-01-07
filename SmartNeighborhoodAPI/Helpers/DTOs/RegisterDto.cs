namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }
        public bool Gender { get; set; }
        public IFormFile? PorfileImageUrl { get; set; }
    }
}
