namespace OurProjectSmartNeiborhood.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<PersonComplain> PersonComplains { get; set; }
        public List<Ad> Ads { get; set; }
        public List<Complain> Complains { get; set; }

        public bool IsActive { get; set; }
    }
}
