using System.Linq.Expressions;

namespace SuppliersWebApi.Repository;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    IQueryable<TEntity> FindById(Expression<Func<TEntity,bool>> expression);
    IQueryable<TEntity> FindAll();
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);

}