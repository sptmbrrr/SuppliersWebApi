using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface IPartRepository : IRepositoryBase<PartDTO>
{
    Task<IEnumerable<PartDTO>> GetAllPartsAsync();
    Task<PartDTO> GetPartByIdAsync(int id);
}