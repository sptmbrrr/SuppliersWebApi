using Microsoft.AspNetCore.Mvc;
using Application.UnitOfWork;
using Application.DTOs;
using Domain.Entity;

namespace Web.Controllers;

[ApiController]
[Route("api/cars")]
public class CarController : ControllerBase
{
    protected readonly IUnitOfWork _unitOfWork;
    public CarController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet("get.{format}"), FormatFilter]
    [Produces("application/json", "application/xml", Type = typeof(List<string>))]
    public async Task<IEnumerable<CarDTO>> GetAllCars()
    {
        var cars = await _unitOfWork.Cars.GetAllCarsAsync();
        var carDTOs = new List<CarDTO>();
        foreach (var car in cars)
        {
            carDTOs.Add(new CarDTO(car));               // fix!!!
        }

        return carDTOs;
    }
}