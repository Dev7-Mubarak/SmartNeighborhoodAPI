namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage ="Name is reqired")]
        [MaxLength(30)]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Name is reqired")]
        [MaxLength(40)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Name is reqired")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Age is required")]
        public byte Age { get; set; }
        [Required(ErrorMessage ="Gender is required")]
        public bool Gender { get; set; }
        public IFormFile? PorfileImageUrl { get; set; }
    }
}
