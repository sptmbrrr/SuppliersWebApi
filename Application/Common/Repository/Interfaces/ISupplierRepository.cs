using Application.Common.DTOs;
using Domain.Entity;

namespace Application.Common.Repository.Interfaces;

public interface ISupplierRepository : IRepositoryBase<Supplier>
{
    Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
    Task<Supplier> GetSupplierByIdAsync(int id);
    Task CreateSupplierAsync(SupplierDTO supplier);
    Task DeleteSupplierAsync(int id);
    Task UpdateSupplierAsync(SupplierDTO supplier, int id);
}