using Domain.Entity;

namespace Application.Common.DTOs;
public class PartManufacturerDTO
{
    public PartManufacturerDTO(PartManufacturer partManufacturer)
    {
        Id = partManufacturer.Id;
        C_Name = partManufacturer.C_Name;
    }
    public int Id { get; set; }
    public string C_Name { get; set; } = null!;
}