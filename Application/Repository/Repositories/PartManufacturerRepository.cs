using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;

namespace Application.Repository;

public class PartManufacturerRepository : RepositoryBase<PartManufacturer>, IPartManufacturerRepository
{
    public PartManufacturerRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<PartManufacturer>> GetAllPartManufacturersAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<PartManufacturer> GetPartManufacturerByIdAsync(int id)
    {
        return await FindById(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }
}
