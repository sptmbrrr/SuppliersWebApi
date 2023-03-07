using System.Linq.Expressions;

namespace Application.Common.Repository.Interfaces;

public interface IRepositoryBase<T> where T : class
{
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    IQueryable<T> FindAll();
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);

}