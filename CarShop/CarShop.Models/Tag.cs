namespace CarShop.Models;

public class Tag : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Car> Cars { get; set; }

}
