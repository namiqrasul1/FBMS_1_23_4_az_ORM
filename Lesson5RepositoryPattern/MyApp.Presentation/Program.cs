using MyApp.Data.Models;
using MyApp.Data.Repositories;

IRepository<Product> repo = new Repository<Product>();

var product = new Product
{
    Name = "Asus Tuf",
    Category = new()
    {
        Name = "Electronic",
    },
    Description = "Laptop"
};

repo.Add(product);
repo.SaveChanges();