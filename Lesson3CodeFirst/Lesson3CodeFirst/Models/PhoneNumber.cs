namespace Lesson3CodeFirst.Models
{
    public class PhoneNumber : BaseEntity
    {
        public string Number { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}