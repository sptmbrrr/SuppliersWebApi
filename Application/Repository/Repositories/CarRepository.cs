using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;

namespace Application.Repository;

public class CarRepository : RepositoryBase<Car>, ICarRepository
{
    public CarRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<Car>> GetAllCarsAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<Car> GetCarByIdAsync(int id)
    {
        return await FindById(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }
}
