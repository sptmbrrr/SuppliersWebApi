using Microsoft.AspNetCore.Mvc;
using Application.UnitOfWork;
using Application.DTOs;
using Domain.Entity;

namespace Web.Controllers;

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
        var parts = await _unitOfWork.Parts.GetAllPartsAsync();
        var partDTOs = new List<PartDTO>();
        
        foreach(var part in parts)
        {
            partDTOs.Add(new PartDTO(part));                // fix!!!
        }

        return partDTOs;
    }

    [HttpGet("{id}")]
    public async Task<PartDTO> GetPart(int id)
    {
        var partDTO = new PartDTO(await _unitOfWork.Parts.GetPartByIdAsync(id));

        return partDTO;
    }
}
