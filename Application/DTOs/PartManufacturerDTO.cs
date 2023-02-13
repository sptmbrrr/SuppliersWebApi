using Domain.Entity;

namespace Application.DTOs;
public class PartManufacturerDTO
{
    public PartManufacturerDTO(PartManufacturer partManufacturer)
    {
        this.Id = partManufacturer.Id;
        this.C_Name = partManufacturer.C_Name;
    }
    public int Id { get; set; }
    public string C_Name { get; set; } = null!;
}