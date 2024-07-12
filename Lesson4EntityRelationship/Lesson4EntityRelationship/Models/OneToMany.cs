using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson4EntityRelationship.Models
{
    #region Default covension

    //public class Category
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<Product> Products { get; set; }
    //}

    //public class Product
    //{
    //    public int Id { get; set; }
    //    public double Price { get; set; }
    //    public Category Category { get; set; }
    //}



    #endregion

    #region Data Annotation

    //public class Category
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<Product> Products { get; set; }
    //}

    //public class Product
    //{
    //    public int Id { get; set; }
    //    public double Price { get; set; }
    //    [ForeignKey(nameof(Category))]
    //    public int Id_Category { get; set; }
    //    public Category Category { get; set; }
    //}

    #endregion

    #region FluentApi

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }



    #endregion
}
