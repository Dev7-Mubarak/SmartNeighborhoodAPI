namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class ComplainDTo
    {
        public byte[] Image { get; set; }
        public string Outcome { get; set; }
        public int ComplainTypeId { get; set; }
        public string Notes { get; set; }
        public DateTime SessionDate { get; set; }
        public bool IsResolved { get; set; }
    }
}
