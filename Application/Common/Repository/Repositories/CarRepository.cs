using Microsoft.EntityFrameworkCore;
using Application.Common.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;
using Web.Models;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public class CarRepository : RepositoryBase<Car>, ICarRepository
{
    public CarRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<Car>> GetCarsAsync(CarParameters carParameters)
    {
        return await FindAll()
            .OrderBy(x => x.Id)
            .Skip((carParameters.PageNumber - 1) * carParameters.PageSize)
            .Take(carParameters.PageSize)
            .ToListAsync();
    }

    public async Task<Car> GetCarByIdAsync(int id)
    {
        return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }

    public Task CreateCarAsync(CarDTO car)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCarAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCarAsync(CarDTO car, int id)
    {
        throw new NotImplementedException();
    }
}
