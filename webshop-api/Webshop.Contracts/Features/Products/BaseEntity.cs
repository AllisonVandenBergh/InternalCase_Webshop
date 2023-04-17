namespace Webshop.Contracts.Features.Products
{
	public class BaseEntity
	{
        public required Guid Id { get; init; }

        public required DateTime CreatedDate { get; init; }

        public required DateTime UpdatedDate { get; init; }
    }
}