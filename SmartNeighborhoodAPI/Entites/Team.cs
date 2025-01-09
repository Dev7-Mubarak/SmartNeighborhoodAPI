namespace OurProjectSmartNeiborhood.Entites
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
    }
}
