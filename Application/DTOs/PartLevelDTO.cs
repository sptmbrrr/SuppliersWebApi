using Domain.Entity;

namespace Application.DTOs;
public class PartLevelDTO
{
    public PartLevelDTO(PartLevel partLevel)
    {
        this.Id = partLevel.Id;
        this.C_Description = partLevel.C_Description;
    }
    public int Id { get; set; }
    public string C_Description { get; set; } = null!;
}