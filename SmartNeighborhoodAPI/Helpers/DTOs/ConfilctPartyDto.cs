namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class ConfilctPartyDto
    {
        [Required]
        [maxlength(30)]
        public string Name { get; set; }
    }
}
