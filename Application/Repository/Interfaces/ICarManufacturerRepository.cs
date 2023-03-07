using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface ICarManufacturerRepository : IRepositoryBase<CarManufacturer>
{
    Task<IEnumerable<CarManufacturer>> GetAllCarManufacturersAsync();
    Task<CarManufacturer> GetCarManufacturerByIdAsync(int id);
}