namespace Webshop.Contracts.Features.Products.Request
{
    [Serializable]
    public class GetProductRequest
    {
        public required Guid Id { get; init; }
    }
}
