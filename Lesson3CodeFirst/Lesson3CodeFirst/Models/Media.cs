namespace Lesson3CodeFirst.Models
{
    public class Media : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
        public Dish Dish { get; set; }

    }
}