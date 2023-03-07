using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface ISupplierRepository : IRepositoryBase<Supplier>
{
    Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
    Task<Supplier> GetSupplierByIdAsync(int id);
}