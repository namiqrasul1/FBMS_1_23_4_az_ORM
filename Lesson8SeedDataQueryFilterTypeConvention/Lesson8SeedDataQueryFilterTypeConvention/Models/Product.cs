namespace Lesson8SeedDataQueryFilterTypeConvention.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Order>? Orders { get; set; }
}
