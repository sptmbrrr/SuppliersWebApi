using Application.Common.DTOs;
using Domain.Entity;

namespace Application.Common.Repository.Interfaces;

public interface IPartLevelRepository : IRepositoryBase<PartLevel>
{
    Task<IEnumerable<PartLevel>> GetAllPartLevelsAsync();
    Task<PartLevel> GetPartLevelByIdAsync(int id);
    Task CreatePartLevelAsync(PartLevelDTO partLevel);
    Task DeletePartLevelByAsync(int id);
    Task UpdatePartLevelAsync(PartLevelDTO partLevelDTO, int id);
}