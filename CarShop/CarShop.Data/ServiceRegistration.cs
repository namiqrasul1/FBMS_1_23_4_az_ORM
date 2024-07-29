using CarShop.Data.Data;
using CarShop.Data.Repositories;
using CarShop.Models;
using SimpleInjector;

namespace CarShop.Data;

public static class ServiceRegistration
{
    public static Container RegisterDataLayer(this Container container)
    {
        container.Register<AppDbContext>();
        container.Register<IRepository<Car>, Repository<Car>>();
        container.Register<IRepository<Tag>, Repository<Tag>>();

        return container;
    }
}
