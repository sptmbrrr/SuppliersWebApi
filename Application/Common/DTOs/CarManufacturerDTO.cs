using Domain.Entity;

namespace Application.Common.DTOs;
public class CarManufacturerDTO
{
    public CarManufacturerDTO(CarManufacturer carManufacturer)
    {
        Id = carManufacturer.Id;
        C_Name = carManufacturer.C_Name;
    }
    public int Id { get; set; }
    public string C_Name { get; set; }
}