using Application.Common.DTOs;
using Domain.Entity;

namespace Application.Common.Repository.Interfaces;

public interface IPartManufacturerRepository : IRepositoryBase<PartManufacturer>
{
    Task<IEnumerable<PartManufacturer>> GetAllPartManufacturersAsync();
    Task<PartManufacturer> GetPartManufacturerByIdAsync(int id);
    Task CreatePartManufacturerAsync(PartManufacturerDTO partManufacturer);
    Task DeletePartManufacturerAsync(int id);
    Task UpdatePartManufacturerAsync(PartManufacturerDTO partManufacturerDTO);
}