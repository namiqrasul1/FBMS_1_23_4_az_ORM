namespace Lesson3CodeFirst.Models
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int RestaurantId { get; set; }
        public int? MediaId { get; set; }
        public Category Category { get; set; }
        public Restaurant Restaurant { get; set; }
        public Media Photo { get; set; }
    }
}