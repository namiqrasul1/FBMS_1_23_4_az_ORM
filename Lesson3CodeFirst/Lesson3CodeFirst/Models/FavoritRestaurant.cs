namespace Lesson3CodeFirst.Models
{
    public class FavoritRestaurant
    {
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public User User { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
