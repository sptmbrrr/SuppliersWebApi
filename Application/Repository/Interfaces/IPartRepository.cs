using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface IPartRepository : IRepositoryBase<Part>
{
    Task<IEnumerable<Part>> GetAllPartsAsync();
    Task<Part> GetPartByIdAsync(int id);
}