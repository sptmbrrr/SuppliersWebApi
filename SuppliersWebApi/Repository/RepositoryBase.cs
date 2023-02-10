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
        throw new NotImplementedException();
    }

    public IQueryable<T> FindAll()
    {
        return this.DataContext.Set<T>().AsNoTracking();
    }

    public void Insert(T entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> FindById(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }
}