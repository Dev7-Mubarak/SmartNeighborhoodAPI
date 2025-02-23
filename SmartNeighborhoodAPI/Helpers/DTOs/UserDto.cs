namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class UserDto
    {
        [Required(ErrorMessage ="Display Name is required")]
        public string DisplayName { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress()]
        public string Email { get; set; }
        //public string Token { get; set; }
    }
}
