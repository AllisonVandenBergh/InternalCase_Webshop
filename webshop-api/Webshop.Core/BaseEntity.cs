namespace Webshop.Core;

public class BaseEntity
{
    //public required Guid Id { get; init; }
    //public required DateTime CreatedDate { get; init; }
    //public required DateTime UpdatedDate { get; init; }

    public Guid Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}