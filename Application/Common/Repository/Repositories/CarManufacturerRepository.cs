using Microsoft.EntityFrameworkCore;
using Application.Common.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public class CarManufacturerRepository : RepositoryBase<CarManufacturer>, ICarManufacturerRepository
{
    public CarManufacturerRepository(DataContext context)
        : base(context) { }

    public Task CreateCarManufacturerAsync(CarManufacturerDTO carManufacturer)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCarManufacturerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CarManufacturer>> GetAllCarManufacturersAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<CarManufacturer> GetCarManufacturerByIdAsync(int id)
    {
        return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }

    public Task<IEnumerable<CarManufacturer>> GetCarManufacturersAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateCarManufacturerAsync(CarManufacturerDTO carManufacturer, int id)
    {
        throw new NotImplementedException();
    }
}