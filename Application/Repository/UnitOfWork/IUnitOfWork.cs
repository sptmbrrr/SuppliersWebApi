using Application.Repository;

namespace Application.UnitOfWork;
public interface IUnitOfWork
{
    IPartRepository Parts { get; }
}