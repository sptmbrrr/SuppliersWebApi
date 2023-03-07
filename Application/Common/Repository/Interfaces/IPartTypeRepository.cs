using Application.Common.DTOs;
using Domain.Entity;

namespace Application.Common.Repository.Interfaces;

public interface IPartTypeRepository : IRepositoryBase<PartType>
{
    Task<IEnumerable<PartType>> GetAllPartTypesAsync();
    Task<PartType> GetPartTypeByIdAsync(int id);
    Task CreatePartType(PartTypeDTO partType);
    Task DeletePartTypeAsync(int id);
    Task UpdatePartTypeAsync(PartTypeDTO partType, int id);
}