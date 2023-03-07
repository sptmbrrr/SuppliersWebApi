using Domain.Entity;

namespace Application.Common.DTOs;
public class PartLevelDTO
{
    public PartLevelDTO(PartLevel partLevel)
    {
        Id = partLevel.Id;
        C_Description = partLevel.C_Description;
    }
    public int Id { get; set; }
    public string C_Description { get; set; } = null!;
}