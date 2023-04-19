namespace Webshop.Contracts.Features.V1.Products.Request
{
    [Serializable]
    public class GetProductRequest
    {
        public required Guid Id { get; init; }
    }
}
