using Lesson3CodeFirst.Data;
using Lesson3CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

FoodyByteDbContext context = new();

//var category = new Category
//{
//    Name = "Product"
//};

//context.Categories.Add(category);
//context.SaveChanges();

//var restaurant = new Restaurant
//{
//    Name = "StepRest",
//    Address = new Address { Country = "Aze",  City = "Baku",  Street = "K.Rehimov 70" },
//    CloseTime = new TimeOnly(21,0),
//    OpenTime = new TimeOnly(09,00),
//};

//var dish = new Dish
//{
//    Name = "Free",
//    Description = "Dadli",
//    CategoryId = 1,
//    Price = 2,
//    Restaurant = restaurant,
//};

//context.Restaurants.Add(restaurant);
//context.Dishes.Add(dish);
//context.SaveChanges();


var dishes = context.Dishes.Include(d => d.Category).Include(d => d.Restaurant).ToList();

Console.WriteLine();