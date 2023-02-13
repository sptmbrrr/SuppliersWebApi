using Application.DTOs;
using Domain.Entity;

namespace Application.Repository;

public interface ICarRepository : IRepositoryBase<Car>
{
    Task<IEnumerable<Car>> GetAllCarsAsync();
    Task<Car> GetCarByIdAsync(int carId);
}