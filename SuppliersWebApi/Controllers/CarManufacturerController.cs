using Microsoft.AspNetCore.Mvc;
using Domain.Entity;
using Application.Common.DTOs;
using Application.Common.UnitOfWork;

namespace Web.Controllers;

[ApiController]
[Route("api/carmanufacturers")]
public class CarManufacturerController : ControllerBase
{
    protected readonly IUnitOfWork _unitOfWork;
    public CarManufacturerController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IEnumerable<CarManufacturerDTO>> GetAllCarManufacturers()
    {
        var carManufacturers = await _unitOfWork.CarManufacturers.GetCarManufacturersAsync();
        var carManufacturerDTOs = new List<CarManufacturerDTO>();
        foreach(var carManufacturer in carManufacturers)
        {
            carManufacturerDTOs.Add(new CarManufacturerDTO(carManufacturer));
        }
        
        return carManufacturerDTOs;
    }
}
