using Lesson5Coding.Data;
using Lesson5Coding.Models;

var context = new AppDbContext();

//var category = new Category
//{
//    Name = "Nonacohol",
//};

//var products = new List<Product>
//{
//    new Product{ Name = "su", Desc = "vacib element", Category = category },
//    new Product{ Name = "cola", Desc = "zeher", Category = category },
//    new Product{ Name = "fanta", Desc = "zeher 2", Category = category },
//};

//context.AddRange(products);

//context.SaveChanges();

var product = context.Products.FirstOrDefault(p => p.Id == 3);

if(product is not null)
{
    product.Price = 2;
    product.UpdatedTime = DateTime.Now;
    context.Update(product);
    context.SaveChanges();
}