namespace Lesson3CodeFirst.Models
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; set; }
        public TimeOnly OpenTime { get; set; }
        public TimeOnly CloseTime { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<Review> Reviews { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}