namespace OurProjectSmartNeiborhood.Entites
{
    public class ContactInfo
    {
        public int Id { get; set; }
       
        public string PhontNumber { get; set; }
        public string PhoneType { get; set; }
        public string? Email { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
