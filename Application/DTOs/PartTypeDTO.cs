using Domain.Entity;

namespace Application.DTOs;
public class PartTypeDTO
{
    public PartTypeDTO(PartType partType)
    {
        this.Id = partType.Id;
        this.C_Description = partType.C_Description;
    }
    public int Id { get; set; }
    public string C_Description { get; set; } = null!;
}