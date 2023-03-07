using Microsoft.EntityFrameworkCore;
using Application.Common.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public class PartTypeRepository : RepositoryBase<PartType>, IPartTypeRepository
{
    public PartTypeRepository(DataContext context)
        : base(context) { }

    public Task CreatePartType(PartTypeDTO partType)
    {
        throw new NotImplementedException();
    }

    public Task DeletePartTypeAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PartType>> GetAllPartTypesAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<PartType> GetPartTypeByIdAsync(int id)
    {
        return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }

    public Task UpdatePartTypeAsync(PartTypeDTO partType, int id)
    {
        throw new NotImplementedException();
    }
}
