using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;

namespace Application.Repository;

public class PartLevelRepository : RepositoryBase<PartLevel>, IPartLevelRepository
{
    public PartLevelRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<PartLevel>> GetAllPartLevelsAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<PartLevel> GetPartLevelByIdAsync(int id)
    {
        return await FindById(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }
}