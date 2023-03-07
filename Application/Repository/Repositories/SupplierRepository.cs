using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;

namespace Application.Repository;

public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
{
    public SupplierRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<Supplier> GetSupplierByIdAsync(int id)
    {
        return await FindById(x=>x.Id.Equals(id)).FirstOrDefaultAsync();
    }
}