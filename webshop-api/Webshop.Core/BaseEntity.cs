namespace Webshop.Core
{
	public class BaseEntity
	{
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}