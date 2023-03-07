using Domain.Entity;

namespace Application.Common.DTOs;
public class PartTypeDTO
{
    public PartTypeDTO(PartType partType)
    {
        Id = partType.Id;
        C_Description = partType.C_Description;
    }
    public int Id { get; set; }
    public string C_Description { get; set; } = null!;
}