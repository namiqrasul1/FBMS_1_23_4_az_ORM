using CarShop.Data.Data;
using CarShop.Data.Repositories;
using CarShop.Models;
using SimpleInjector;

namespace CarShop.Data;

public static class ServiceRegistration
{
    public static Container RegisterDataLayer(this Container container)
    {
        container.RegisterSingleton<AppDbContext>();
        container.RegisterSingleton<IRepository<Car>, Repository<Car>>();
        container.RegisterSingleton<IRepository<Tag>, Repository<Tag>>();

        return container;
    }
}
