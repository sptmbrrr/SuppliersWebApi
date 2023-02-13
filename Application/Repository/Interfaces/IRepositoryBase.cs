using System.Linq.Expressions;

namespace Application.Repository;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    IQueryable<TEntity> FindById(Expression<Func<TEntity, bool>> expression);
    IQueryable<TEntity> FindAll();
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);

}