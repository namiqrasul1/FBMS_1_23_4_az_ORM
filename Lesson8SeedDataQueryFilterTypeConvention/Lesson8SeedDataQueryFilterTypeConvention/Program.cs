using Lesson8SeedDataQueryFilterTypeConvention.Data;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

var products = context.Products.ToList();
products = context.Products.IgnoreQueryFilters().ToList();

Console.WriteLine();