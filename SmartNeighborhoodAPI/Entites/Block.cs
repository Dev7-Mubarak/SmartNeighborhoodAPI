namespace OurProjectSmartNeiborhood.Entites
{
    public class Block
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<ProjectFamily> projectFamilies { get; set; }
    }
}
