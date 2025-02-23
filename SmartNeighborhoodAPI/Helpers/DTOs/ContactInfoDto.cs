namespace SmartNeighborhoodAPI.Helpers.DTOs
{
    public class ContactInfoDto
    {
        [Required(ErrorMessage ="PhoneNumber is Required")]
        [MaxLength(9)]
        public string PhontNumber { get; set; }
        public bool IsPhoneNumber { get; set; }
        public bool IsWhatsappNumber { get; set; }
        [Required(ErrorMessage ="Person id is Required")]
        public int PersonId { get; set; }
    }
}
