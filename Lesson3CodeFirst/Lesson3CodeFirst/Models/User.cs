namespace Lesson3CodeFirst.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? MediaId { get; set; }
        public List<Review> Reviews { get; set; }
        public Media Media { get; set; }
        //public List<FavoritRestaurant> FavoritRestaurants { get; set; }


    }
}