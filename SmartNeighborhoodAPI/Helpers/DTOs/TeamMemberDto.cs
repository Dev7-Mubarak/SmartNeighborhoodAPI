namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class TeamMemberDto
    {
        public int TeamId { get; set; }

        public int MemberId { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string MemberJob { get; set; }
    }
}
