using Lesson2CodeFIrstExample.Models.Abstracts;

namespace Lesson2CodeFIrstExample.Models.Concretes
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string? Desc { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}
