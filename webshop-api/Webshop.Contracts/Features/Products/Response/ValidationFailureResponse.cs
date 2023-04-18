using System;
namespace Webshop.Contracts.Features.Products.Response
{
    public class ValidationFailureResponse
    {
        public required IEnumerable<ValidationResponse> Errors { get; init; }
    }

    public class ValidationResponse
    {
        public required string PropertyName { get; init; }

        public required string Message { get; init; }
    }
}

