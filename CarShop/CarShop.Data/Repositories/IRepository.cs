using CarShop.Models;
using System.Linq.Expressions;

namespace CarShop.Data.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    T? Get(int id);
    T? Get(Expression<Func<T, bool>> predicate);
    IQueryable<T> GetAll();
    List<T>? GetAll(Expression<Func<T, bool>> predicate);
    void Delete(int id);
    void Delete(T entity);
    void Update(T entity);
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    int SaveChanges();
}
