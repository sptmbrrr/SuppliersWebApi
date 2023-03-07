using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface IPartManufacturerRepository : IRepositoryBase<PartManufacturer>
{
    Task<IEnumerable<PartManufacturer>> GetAllPartManufacturersAsync();
    Task<PartManufacturer> GetPartManufacturerByIdAsync(int id);
}