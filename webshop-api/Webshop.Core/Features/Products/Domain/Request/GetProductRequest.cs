using System;
namespace Webshop.Core.Features.Products.Domain.Request
{
	public class GetProductRequest
	{
		public required Guid Id { get; init; }
	}
}

