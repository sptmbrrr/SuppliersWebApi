using Domain.Entity;

namespace Application.DTOs;
public class CarManufacturerDTO
{
    public CarManufacturerDTO(CarManufacturer carManufacturer)
    {
        this.Id = carManufacturer.Id;
        this.C_Name = carManufacturer.C_Name;
    }
    public int Id { get; set; }
    public string C_Name { get; set; }
}