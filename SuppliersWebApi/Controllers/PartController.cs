using Microsoft.AspNetCore.Mvc;
using Domain.Entity;
using Application.Common.DTOs;
using Application.Common.UnitOfWork;

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
        var parts = await _unitOfWork.Parts.GetPartsAsync();
        var partDTOs = new List<PartDTO>();

        foreach (var part in parts)
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

    [HttpPost]
    public async Task CreatePart(PartDTO partDTO)
    {
        await _unitOfWork.Parts.CreatePartAsync(partDTO);
    }

    [HttpDelete]
    public async Task DeletePart(int id)
    {

    }

    [HttpPut]
    public async Task UpdatePart(PartDTO partDTO, int id)
    {

    }
}
