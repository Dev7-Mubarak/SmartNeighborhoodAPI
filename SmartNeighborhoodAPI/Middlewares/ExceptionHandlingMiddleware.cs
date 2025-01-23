using System.Net;
using System.Text.Json;

namespace SmartNeighborhoodAPI.Helpers
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Proceed to the next middleware or request handler.
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log the exception.
                _logger.LogError(ex, "An unhandled exception occurred.");

                // Handle the exception and return a standardized error response.
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Set the response status code and content type.
            context.Response.ContentType = "application/json";

            // Determine status code based on exception type (can be extended for custom exceptions).
            var statusCode = exception switch
            {
                ArgumentNullException => (int)HttpStatusCode.BadRequest,
                ArgumentException => (int)HttpStatusCode.BadRequest,
                KeyNotFoundException => (int)HttpStatusCode.NotFound,
                _ => (int)HttpStatusCode.InternalServerError
            };

            // Build the error response using ApiResponse<T>.
            ApiResponse<string> errorResponse = ApiResponse<string>.Error(
                statusCode,
                "An error occurred while processing the request."
            );

            // Set the response status code.
            context.Response.StatusCode = statusCode;

            // Write the response as JSON.
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse, options));
        }
    }
}
