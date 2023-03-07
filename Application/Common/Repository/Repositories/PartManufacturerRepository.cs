using Microsoft.EntityFrameworkCore;
using Application.Common.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public class PartManufacturerRepository : RepositoryBase<PartManufacturer>, IPartManufacturerRepository
{
    public PartManufacturerRepository(DataContext context)
        : base(context) { }

    public Task CreatePartManufacturerAsync(PartManufacturerDTO partManufacturer)
    {
        throw new NotImplementedException();
    }

    public Task DeletePartManufacturerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PartManufacturer>> GetAllPartManufacturersAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<PartManufacturer> GetPartManufacturerByIdAsync(int id)
    {
        return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }

    public Task UpdatePartManufacturerAsync(PartManufacturerDTO partManufacturerDTO)
    {
        throw new NotImplementedException();
    }
}
