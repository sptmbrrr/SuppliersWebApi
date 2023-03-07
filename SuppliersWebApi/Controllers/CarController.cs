using Microsoft.AspNetCore.Mvc;
using Web.Models;
using AutoMapper;
using Application.Common.DTOs;
using Application.Common.UnitOfWork;

namespace Web.Controllers;

[ApiController]
[Route("api/cars")]
public class CarController : ControllerBase
{
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IMapper _mapper;
    public CarController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet("{format}"), FormatFilter]
    [Produces("application/json", "application/xml", Type = typeof(List<string>))]
    public async Task<IEnumerable<CarDTO>> GetAllCars([FromQuery] CarParameters carParameters)
    {
        var cars = await _unitOfWork.Cars.GetCarsAsync(carParameters);

        return _mapper.Map<List<CarDTO>>(cars);
    }
}