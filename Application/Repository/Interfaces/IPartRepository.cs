using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface IPartRepository : IRepositoryBase<Part>
{
    Task<IEnumerable<Part>> GetAllPartsAsync();
    Task<Part> GetPartByIdAsync(int id);
    Task CreatePartAsync(PartDTO part);
    Task DeletePartByIdAsync(int id);
    Task UpdatePartAsync(PartDTO part, int id);
}