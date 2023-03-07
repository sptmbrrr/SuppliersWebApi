using Microsoft.EntityFrameworkCore;
using Application.Common.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public class PartLevelRepository : RepositoryBase<PartLevel>, IPartLevelRepository
{
    public PartLevelRepository(DataContext context)
        : base(context) { }

    public Task CreatePartLevelAsync(PartLevelDTO partLevel)
    {
        throw new NotImplementedException();
    }

    public Task DeletePartLevelByAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PartLevel>> GetAllPartLevelsAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<PartLevel> GetPartLevelByIdAsync(int id)
    {
        return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }

    public Task UpdatePartLevelAsync(PartLevelDTO partLevelDTO, int id)
    {
        throw new NotImplementedException();
    }
}