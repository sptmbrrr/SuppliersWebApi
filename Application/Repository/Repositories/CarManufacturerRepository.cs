using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Infrastructure.Persistence;
using Domain.Entity;

namespace Application.Repository;

public class CarManufacturerRepository : RepositoryBase<CarManufacturer>, ICarManufacturerRepository
{
    public CarManufacturerRepository(DataContext context)
        : base(context) { }
    public async Task<IEnumerable<CarManufacturer>> GetAllCarManufacturersAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<CarManufacturer> GetCarManufacturerByIdAsync(int id)
    {
        return await FindById(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }
}