using Microsoft.EntityFrameworkCore;
using Application.Common.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
{
    public SupplierRepository(DataContext context)
        : base(context) { }

    public Task CreateSupplierAsync(SupplierDTO supplier)
    {
        throw new NotImplementedException();
    }

    public Task DeleteSupplierAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<Supplier> GetSupplierByIdAsync(int id)
    {
        return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }

    public Task UpdateSupplierAsync(SupplierDTO supplier, int id)
    {
        throw new NotImplementedException();
    }
}