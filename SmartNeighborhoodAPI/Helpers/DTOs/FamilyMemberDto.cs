namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class FamilyMemberDto
    {
        [Required(ErrorMessage ="Person id reqired")]
        public int PersonId { get; set; }
        [Required(ErrorMessage ="Fmaily Id reqired")]
        public int FamilyId { get; set; } 
        [Required(ErrorMessage ="Member Type Id reqired")]
        public int MemberTypeId { get; set; }
    }
}
