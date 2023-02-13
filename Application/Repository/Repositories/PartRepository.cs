using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;

namespace Application.Repository;

public class PartRepository : RepositoryBase<Part>, IPartRepository
{
    public PartRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<Part>> GetAllPartsAsync()
    {
        return await FindAll().ToListAsync();
    }

    public async Task<Part> GetPartByIdAsync(int id)
    {
        return await FindById(x => x.Id.Equals(id))
                    .FirstOrDefaultAsync();
    }
}