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
    public async Task<IEnumerable<Part>> GetParts()
    {
        return await _repository.GetAllPartsAsync();
    }
}
