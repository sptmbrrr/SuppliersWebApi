using Microsoft.AspNetCore.Mvc;
using Application.UnitOfWork;
using Application.DTOs;
using Domain.Entity;

namespace Web.Controllers;

[ApiController]
[Route("api/partlevels")]
public class PartLevelController : ControllerBase
{
    protected readonly IUnitOfWork _unitOfWork;
    public PartLevelController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

/*    [HttpGet]
    public async Task<IEnumerable<PartLevelDTO>> GetAllPartLevel()
    {

    }*/
}