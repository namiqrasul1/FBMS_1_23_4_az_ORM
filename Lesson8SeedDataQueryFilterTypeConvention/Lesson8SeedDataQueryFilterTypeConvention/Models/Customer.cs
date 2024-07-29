namespace Lesson8SeedDataQueryFilterTypeConvention.Models;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public ICollection<Order> Orders { get; set; }
}
