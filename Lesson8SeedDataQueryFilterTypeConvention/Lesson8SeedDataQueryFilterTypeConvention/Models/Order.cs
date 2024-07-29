namespace Lesson8SeedDataQueryFilterTypeConvention.Models;

public class Order : BaseEntity
{
    public string OrderDetails { get; set; }
    public int? CustomerId { get; set; }
    public Customer Customer { get; set; }
    public ICollection<Product>? Products { get; set; }
}
