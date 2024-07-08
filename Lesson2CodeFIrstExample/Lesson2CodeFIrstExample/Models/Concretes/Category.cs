using Lesson2CodeFIrstExample.Models.Abstracts;

namespace Lesson2CodeFIrstExample.Models.Concretes
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
