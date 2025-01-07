namespace SmartNeighborhoodAPI.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public byte[]? Image { get; set; }
        public string IdentityNumber { get; set; }
        public string TypeOfIdentity { get; set; }
        public string Status { get; set; }
    }

}
