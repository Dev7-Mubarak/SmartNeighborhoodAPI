namespace SmartNeighborhoodAPI.Helpers
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public T? Data { get; set; }
        public List<FieldError>? Errors { get; set; }

        public ApiResponse() { }

        public ApiResponse(int statusCode, string message, T data, bool succeeded, List<FieldError> errors = null)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
            Succeeded = succeeded;
            Errors = errors ?? new List<FieldError>();
        }

        public static ApiResponse<T> Success(T data, string message = "Request successful")
        {
            return new ApiResponse<T>
            {
                StatusCode = 200,
                Message = message,
                Data = data,
                Succeeded = true
            };
        }

        public static ApiResponse<T> Error(string message, int statusCode = 400, List<FieldError> errors = null)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                Message = message,
                Data = default,
                Succeeded = false,
                Errors = errors ?? new List<FieldError>()
            };
        }
    }



}
