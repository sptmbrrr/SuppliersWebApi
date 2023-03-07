using Application.Common.DTOs;
using Domain.Entity;

namespace Application.Common.Repository.Interfaces;

public interface ICarManufacturerRepository : IRepositoryBase<CarManufacturer>
{
    Task<IEnumerable<CarManufacturer>> GetCarManufacturersAsync();
    Task<CarManufacturer> GetCarManufacturerByIdAsync(int id);
    Task CreateCarManufacturerAsync(CarManufacturerDTO carManufacturer);
    Task DeleteCarManufacturerAsync(int id);
    Task UpdateCarManufacturerAsync(CarManufacturerDTO carManufacturer, int id);
}