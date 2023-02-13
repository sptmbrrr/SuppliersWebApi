using Application.Repository;
using Infrastructure.Persistence;

namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(IPartRepository partRepository)
    {
        Parts = partRepository;
    }
    public IPartRepository Parts { get; set; }
}