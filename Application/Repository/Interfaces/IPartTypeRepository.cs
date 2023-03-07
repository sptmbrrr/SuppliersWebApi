using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface IPartTypeRepository : IRepositoryBase<PartType>
{
    Task<IEnumerable<PartType>> GetAllPartTypesAsync();
    Task<PartType> GetPartTypeByIdAsync(int id);
}