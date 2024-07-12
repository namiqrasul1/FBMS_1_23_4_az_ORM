namespace Lesson3CodeFirst.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; } 
    }
}
