namespace OurProjectSmartNeiborhood.Entites
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string? Job { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public byte[] Image { get; set; }
        public string BloodType { get; set; }
        public string? IdentityNumber { get; set; }
        public string TypeOfIdentity { get; set; }
        public string Status { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public List<FamilyMember> FamilyMembers { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public List<PersonComplain> PersonComplains { get; set; }


    }
}
