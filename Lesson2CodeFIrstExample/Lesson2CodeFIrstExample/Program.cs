using Lesson2CodeFIrstExample.Data;
using Lesson2CodeFIrstExample.Models.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

var dbContext = new AppDbContext();

//var product = new Product
//{
//    Id = 1,
//    Name = "Cola",
//    Desc = "Chox zererli ichki",
//    Price = 1
//};

//dbContext.Products.Add(product);
//dbContext.SaveChanges();


//var product = dbContext.Products.FirstOrDefault(p => p.Id == 1);
//Console.WriteLine(product?.Desc);
//dbContext.Products.Remove(product);
//dbContext.SaveChanges();

//var category = new Category
//{
//    Id = 1,
//    Name = "Nonalchohol"
//};
//var product = new Product
//{
//    Id = 1,
//    Name = "cola",
//    Category = category,
//    Desc = "zererli ichki",
//    Price = 1
//};


//dbContext.Products.Add(product);
//dbContext.SaveChanges();

//var category = dbContext.Categories.FirstOrDefault(c => c.Id == 1);
//Console.WriteLine(category.Name);


//var product = dbContext.Products.Include(p => p.Category).FirstOrDefault(c => c.Id == 1);

//Console.WriteLine(product.Name);

//var ct = dbContext.Categories.FirstOrDefault(c => c.Id == 1);

//var pr = new Product
//{
//    Id = 2,
//    Name = "Fanta",
//    Desc = "colanin tayi",
//    Price = 1,
//    Category = ct
//};

//dbContext.Products.Add(pr);
//dbContext.SaveChanges();

var ct = dbContext.Categories.AsNoTracking().Include(c => c.Products).FirstOrDefault(c => c.Id == 1);

Console.WriteLine(ct.Name);


// Data Source=STHQ0118-01;Initial Catalog=Library;Integrated Security=true;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False