using Microsoft.EntityFrameworkCore;
using Domain.Entity;
using Infrastructure.Persistence;
using System.Linq.Expressions;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected DataContext DataContext { get; set; }
    public RepositoryBase(DataContext dataContext)
    {
        DataContext = dataContext;
    }
    public void Delete(T entity)
    {
        DataContext.Set<T>().Remove(entity);
    }

    public IQueryable<T> FindAll()
    {
        return DataContext.Set<T>().AsNoTracking();
    }

    public void Create(T entity)
    {
        DataContext.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        DataContext.Set<T>().Update(entity);
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return DataContext.Set<T>()
                          .Where(expression)
                          .AsNoTracking();
    }
}
