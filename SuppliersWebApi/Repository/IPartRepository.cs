using SuppliersWebApi.Models;

namespace SuppliersWebApi.Repository;

public interface IPartRepository : IRepositoryBase<Part>
{
    Task<IEnumerable<Part>> GetAllPartsAsync();
    Task<Part> GetPartByIdAsync(int id);
}