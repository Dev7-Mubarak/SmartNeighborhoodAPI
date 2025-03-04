using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;

namespace SmartNeighborhoodAPI.Helpers
{
    public static class ValidationHelper
    {
        public static ApiResponse<List<ErrorDetails>> CreateErrorResponse(ModelStateDictionary modelState)
        {
            List<ErrorDetails> errors = new List<ErrorDetails>();

            foreach (var state in modelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    errors.Add(new ErrorDetails(state.Key, error.ErrorMessage));
                }
            }

            return ApiResponse<List<ErrorDetails>>.Error(HttpStatusCode.BadRequest, "Validation errors occurred.", errors);
        }
    }

}
