namespace Lesson5Coding.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
