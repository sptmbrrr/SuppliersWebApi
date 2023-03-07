using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface IPartLevelRepository : IRepositoryBase<PartLevel>
{
    Task<IEnumerable<PartLevel>> GetAllPartLevelsAsync();
    Task<PartLevel> GetPartLevelByIdAsync(int id);
}