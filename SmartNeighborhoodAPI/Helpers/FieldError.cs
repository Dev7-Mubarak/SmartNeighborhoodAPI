namespace SmartNeighborhoodAPI.Helpers
{
    public class FieldError
    {
        public string Field { get; set; }
        public string ErrorMessage { get; set; }

        public FieldError(string field, string errorMessage)
        {
            Field = field;
            ErrorMessage = errorMessage;
        }
    }

}
