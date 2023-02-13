using Microsoft.AspNetCore.Mvc;
using Application.UnitOfWork;
using Application.DTOs;
using Domain.Entity;

namespace SuppliersWebApi.Controllers;

[ApiController]
[Route("api/parts")]
public class PartController : ControllerBase
{
    protected readonly IUnitOfWork _unitOfWork;
    public PartController(IUnitOfWork unitOfWork)
    {
        this._unitOfWork = unitOfWork;
    }
    [HttpGet]
    public async Task<IEnumerable<PartDTO>> GetAllParts()
    {
        return await _unitOfWork.Parts.GetAllPartsAsync();
    }
    [HttpGet("{id}")]
    public async Task<Part> GetPart(int id)
    {
        var part = await _unitOfWork.Parts.GetPartByIdAsync(id);
        return part;
    }
}
