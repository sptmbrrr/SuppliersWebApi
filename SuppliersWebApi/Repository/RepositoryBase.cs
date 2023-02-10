using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SuppliersWebApi.Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected DataContext DataContext { get; set; }
    public RepositoryBase(DataContext dataContext)
    {
        this.DataContext = dataContext;
    }
    public void Delete(T entity)
    {
        this.DataContext.Set<T>()
                        .Remove(entity);
    }

    public IQueryable<T> FindAll()
    {
        return this.DataContext.Set<T>().AsNoTracking();
    }

    public void Create(T entity)
    {
        this.DataContext.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        this.DataContext.Set<T>()
                        .Update(entity);
    }

    public IQueryable<T> FindById(Expression<Func<T, bool>> expression)
    {
        return this.DataContext.Set<T>()
                          .Where(expression)
                          .AsNoTracking();
    }
}