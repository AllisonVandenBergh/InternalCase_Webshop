namespace Webshop.Core.Features.Products.Exceptions
{
	public class BadRequestException: Exception
	{
		public BadRequestException(string message): base(message)
		{
		}
	}
}
