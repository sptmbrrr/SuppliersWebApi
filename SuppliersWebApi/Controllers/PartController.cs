using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuppliersWebApi.Models;
using SuppliersWebApi.Repository;

namespace SuppliersWebApi.Controllers;

[ApiController]
[Route("api/parts")]
public class PartController : ControllerBase
{
    protected readonly IPartRepository _repository;
    public PartController(IPartRepository repository)
    {
        _repository = repository;
    }
    [HttpGet]
    public async Task<IEnumerable<Part>> GetAllParts()
    {
        return await _repository.GetAllPartsAsync();
    }
    [HttpGet("{id}")]
    public async Task<Part> GetPart(int id)
    {
        var part = await _repository.GetPartByIdAsync(id);
        // mapper to dto (di _mapper)
        return part;
    }
}
