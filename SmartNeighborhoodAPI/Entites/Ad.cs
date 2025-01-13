namespace OurProjectSmartNeiborhood.Entites
{
    public class Ad
    {
        public int Id { get; set; }
       
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedTime { get; set; }
       
        public int GroupId { get; set; }
        // About The Ad you could send it to Many Group and alos The Group Could Recieve Many Ad At the same time
        public List<Group> Groups { get; set; }

    }
}
