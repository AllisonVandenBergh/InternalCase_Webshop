namespace Webshop.Contracts.Features.V1.Products
{
	public class BaseEntity
	{
        public required Guid Id { get; init; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}