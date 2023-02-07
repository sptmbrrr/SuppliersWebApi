using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuppliersWebApi.Models;

namespace SuppliersWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PartController : ControllerBase
{
    private readonly DataContext _context;
    public PartController (
        DataContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Part>>> GetParts()
    {
        return await _context.Parts.ToListAsync();
    }
}