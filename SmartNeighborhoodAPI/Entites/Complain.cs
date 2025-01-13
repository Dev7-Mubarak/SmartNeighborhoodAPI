namespace OurProjectSmartNeiborhood.Entites
{
    public class Complain
    {
        public int Id { get; set; }
   
        public int UserId { get; set; }
        public User User { get; set; }

        public byte[] Image { get; set; }
        public string Outcome { get; set; }
        public int ComplainTypeId { get; set; }
        public ComplainType ComplainType { get; set; }
        public DateTime SessionDate { get; set; }
        public List<PersonComplain> PersonComplains { get; set; }
        public byte IsResolved { get; set; }
    }

}
