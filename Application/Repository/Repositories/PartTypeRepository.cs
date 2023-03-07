using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;

namespace Application.Repository;

public class PartTypeRepository : RepositoryBase<PartType>, IPartTypeRepository
{
    public PartTypeRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<PartType>> GetAllPartTypesAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<PartType> GetPartTypeByIdAsync(int id)
    {
        return await FindById(x=>x.Id.Equals(id)).FirstOrDefaultAsync();
    }
}
