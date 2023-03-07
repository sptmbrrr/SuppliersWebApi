using Application.Common.DTOs;
using Domain.Entity;
using Web.Models;

namespace Application.Common.Repository.Interfaces;

public interface ICarRepository : IRepositoryBase<Car>
{
    Task<IEnumerable<Car>> GetCarsAsync(CarParameters carParameters);
    Task<Car> GetCarByIdAsync(int carId);
    Task CreateCarAsync(CarDTO car);
    Task DeleteCarAsync(int id);
    Task UpdateCarAsync(CarDTO car, int id);

}