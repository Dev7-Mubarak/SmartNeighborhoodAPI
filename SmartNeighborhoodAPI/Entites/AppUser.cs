using Microsoft.AspNetCore.Identity;

namespace SmartNeighborhoodAPI.Entites
{
    public class AppUser : IdentityUser
    {
        public bool IsActive { get; set; }
        public int PersonId { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Image { get; set; }
        public Person Person { get; set; }
    }
}
