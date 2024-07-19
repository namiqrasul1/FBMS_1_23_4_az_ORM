using CarShop.Data.Data;
using CarShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarShop.Data.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    DbSet<T> Set => _context.Set<T>();
    public void Add(T entity)
    {
        Set.Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        Set.AddRange(entities);
    }

    public void Delete(int id)
    {
        var entity = Set.FirstOrDefault(x => x.Id == id);
        if(entity is not null)
            Set.Remove(entity);
    }

    public void Delete(T entity)
    {
        Set.Remove(entity);
    }

    public T? Get(int id)
    {
        return Set.FirstOrDefault(x => x.Id == id);
    }

    public T? Get(Expression<Func<T, bool>> predicate)
    {
        return Set.FirstOrDefault(predicate);
    }

    public IQueryable<T> GetAll()
    {
        return Set;
    }

    public List<T> GetAll(Expression<Func<T, bool>> predicate)
    {
        return Set.Where(predicate).ToList(); // [.. Set.Where(prerdicate)]
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    public void Update(T entity)
    {
        Set.Update(entity);
    }
}
